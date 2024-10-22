using ApiIntegracaoEntity.Pardini;
using Microsoft.AspNetCore.Mvc;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;


namespace ApiIntegracao.Controllers
{
    [Route("api/IntegracaoPardini")]
    [ApiController]
    public class IntegracaoLabPardiniController : ControllerBase
    {
        [HttpGet("get-pedido")]
        public async Task<IActionResult> GetPedido()
        {
            Registro registro = new Registro();

            registro.Lote = new RegistroLote();
            registro.ID = "00000";
            registro.Lote.CodLab = "LAB123";
            registro.Lote.CodLoteLab = "1111";
            registro.Lote.Pedido = [new RegistroLotePedido()];

            var login = "1200";
            var passwd = "5990";

            string xml = SerializeToXml(registro);

            using (var service = new PardiniService.XMLServerSoapClient())
            {
                var resposta = await service.getPedidoAsync("12000", "5990", "");
            }


            return Ok("Teste");
        }


        public static string SerializeToXml(object obj)
        {
            var serializer = new XmlSerializer(obj.GetType());

            using (var stringWriter = new StringWriter())
            {
                serializer.Serialize(stringWriter, obj);
                return stringWriter.ToString();
            }
        }

        private void ValidarXmlSchema(string xml)
        {
            string xsdFile = Path.Combine(Directory.GetCurrentDirectory(), "xml", "Registro.xsd");

            
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.Schemas.Add(null, xsdFile); 
            settings.ValidationType = ValidationType.Schema;  
            settings.ValidationEventHandler += new ValidationEventHandler(ValidationEventHandler);

            try
            {
                
                using (StringReader stringReader = new StringReader(xml))
                {
                    
                    using (XmlReader reader = XmlReader.Create(stringReader, settings))
                    {
                        
                        while (reader.Read()) { }  // A leitura valida o XML
                    }
                }

                Console.WriteLine("XML é válido.");
            }
            catch (XmlException ex)
            {
                Console.WriteLine("Erro ao ler o XML: " + ex.Message);
            }
        }

        private static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Error)
            {
                Console.WriteLine("Erro de validação: " + e.Message);
            }
            else
            {
                Console.WriteLine("Aviso de validação: " + e.Message);
            }
        }

        public static bool ValidateXml(string xmlFile, string xsdFile)
        {
            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.Add(null, xsdFile); // Adiciona o XSD

            XDocument doc = XDocument.Load(xmlFile);
            bool isValid = true;

            doc.Validate(schemaSet, (o, e) =>
            {
                isValid = false;
                Console.WriteLine($"{e.Severity}: {e.Message}");
            });

            return isValid;
        }

        private string ConvertXmlToString(XmlDocument xmlDoc)
        {
            StringWriter stringWriter = new StringWriter();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            settings.Indent = false;

            using (XmlWriter writer = XmlWriter.Create(stringWriter, settings))
            {
                xmlDoc.WriteTo(writer);
            }

            return stringWriter.ToString();
        }

    }
}
