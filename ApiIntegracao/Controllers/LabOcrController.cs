using Azure.AI.Vision.ImageAnalysis;
using Azure;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ApiIntegracaoLab.Config;
using Microsoft.Extensions.Options;

namespace ApiIntegracaoLab.Controllers
{
    [Route("ocr/imagem")]
    [ApiController]
    public class LabOcrController : ControllerBase
    {
        private readonly LabOcrImageConfig _labOcrImageConfig;

        //private const string endpoint = "https://ocr-labsl.cognitiveservices.azure.com/";
        //private const string apiKey = "1mmjYXnIUgi3PTtG2wRrII5ZvyxHlxL9iTBMjcSgchN5iclfIiDzJQQJ99AKACZoyfiXJ3w3AAAFACOGgDxM";

        public LabOcrController(IOptions<LabOcrImageConfig> labDbConfig)
        {
            _labOcrImageConfig = labDbConfig.Value;
        }

        [HttpPost("upload")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> UploadImagem([FromForm] IFormFile file)
        {

            if (file == null || file.Length == 0)
                return BadRequest("Nenhum arquivo foi enviado.");

            try
            {
                using var stream = file.OpenReadStream();
                var client = new ImageAnalysisClient(new Uri(_labOcrImageConfig.EndpointUri), new AzureKeyCredential(_labOcrImageConfig.PrimaryKey));
                var result = await PerformOCRImagem(client, stream);

                return Ok(new { text = result });
            }
            catch (RequestFailedException ex)
            {
                return StatusCode(500, $"Erro na API do Azure: {ex.Message}");
            }
        }


        private async Task<string> PerformOCRImagem(ImageAnalysisClient client, Stream pdfStream)
        {
            var options = new ImageAnalysisOptions
            {
                Language = "pt"
            };

            var response = await client.AnalyzeAsync(BinaryData.FromStream(pdfStream), VisualFeatures.Read, options);

            // Processando o resultado
            var textResult = "";
            foreach (DetectedTextBlock block in response.Value.Read.Blocks)
            {
                foreach (DetectedTextLine line in block.Lines)
                {
                    foreach (DetectedTextWord word in line.Words)
                    {
                        textResult += word.Text + " ";
                    }
                    textResult += "\n";
                }
            }

            return textResult;
        }
    }
}
