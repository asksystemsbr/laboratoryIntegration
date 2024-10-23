using Microsoft.AspNetCore.Mvc;
using ApiIntegracaoEntity.DiagnosticosBrasil;
using AutoMapper;
using DiagnosticoBrasilService;
using ApiIntegracaoEntity;
using ApiIntegracaoEntity.Log;
using ApiIntegracaoLab.Config;
using Microsoft.Extensions.Options;

namespace ApiIntegracaoLab.Controllers
{
    [Route("api/IntegracaoDB")]
    [ApiController]
    public class IntegracaoLabDiagnosticosBrasilController : ControllerBase
    {
        private readonly CosmosDbService _cosmosDbService;
        private readonly LabDbConfig _labDbConfig;
        private readonly IMapper _mapper;

        public IntegracaoLabDiagnosticosBrasilController(IMapper mapper, CosmosDbService cosmosDbService,IOptions<LabDbConfig> labDbConfig)
        {
                _mapper = mapper;
                _cosmosDbService = cosmosDbService;
                _labDbConfig = labDbConfig.Value;
        }

        [HttpPost("recebe-pedido")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> PostAsync(DadosRequestRecebeAtendimentoDBViewModel dadosRequesteRecebeAtendimentoDB)
        {
            using var service = new DiagnosticoBrasilService.wsrvProtocoloDBSyncClient();
            var dadosRequest = _mapper.Map<ct_Atendimento>(dadosRequesteRecebeAtendimentoDB);

            try
            {
                dadosRequest.CodigoSenhaIntegracao = _labDbConfig.CodigoSenhaIntegracao;
                dadosRequest.CodigoApoiado = _labDbConfig.CodigoApoiado;
                var retorno = await service.RecebeAtendimentoAsync(dadosRequest);

                var dadosRespostaRecebeAtendimento = _mapper.Map<DadosRespostaRecebeAtendimentoDBViewModel>(retorno);

                try
                {
                    Log log = new Log(dadosRespostaRecebeAtendimento);
                    log.partitionKey = "recebe-pedido";
                    await _cosmosDbService.AddDocumentAsync(log, log.partitionKey);
                }
                catch
                {
                    ;
                }

                return Ok(dadosRespostaRecebeAtendimento);
            }
            catch (Exception ex) {
                ;
                return Problem(ex.Message,null,null,"Houve um erro no processamento.");
            }

        }

        [HttpPost("envia-laudo-atendimento")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> PostAsync(DadosRequestEnviaLaudoAtendimentoDBViewModel dadosRequestEnviaLaudoAtendimentoViewModel)
        {
            using var service = new DiagnosticoBrasilService.wsrvProtocoloDBSyncClient();
            var dadosRequest = _mapper.Map<ct_EnviaLaudoAtendimentoRequest_v2>(dadosRequestEnviaLaudoAtendimentoViewModel);

            try
            {
                dadosRequest.CodigoSenhaIntegracao = _labDbConfig.CodigoSenhaIntegracao;
                dadosRequest.CodigoApoiado = _labDbConfig.CodigoApoiado;
                var retorno = await service.EnviaLaudoAtendimentoAsync(dadosRequest);

                var dadosRespostaEnviaLaudoAtendimento = _mapper.Map<List<DadosRespostaEnviaLaudoAtendimentoDBViewModel>>(retorno.ToList());
                
                try
                {
                    Log log = new Log(dadosRespostaEnviaLaudoAtendimento);
                    log.partitionKey = "envia-laudo-atendimento";
                    await _cosmosDbService.AddDocumentAsync(log, log.partitionKey);
                }
                catch
                {
                    ;
                }
                return Ok(dadosRespostaEnviaLaudoAtendimento);
            }
            catch (Exception ex)
            {
                ;
                return Problem(ex.Message, null, null, "Houve um erro no processamento.");
            }
        }

        [HttpPost("envia-lote-resultados")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> PostAsync(string loteResultado = "")
        {
            using var service = new DiagnosticoBrasilService.wsrvProtocoloDBSyncClient();
            var dadosRequest = new ct_EnviaLoteResultadosRequest_v2();

            try
            {
                dadosRequest.CodigoSenhaIntegracao = _labDbConfig.CodigoSenhaIntegracao;
                dadosRequest.CodigoApoiado = _labDbConfig.CodigoApoiado;
                dadosRequest.LoteResultado = loteResultado;
                var retorno = await service.EnviaLoteResultadosAsync(dadosRequest);

                var dadosRespostaEnviaLaudoAtendimento = _mapper.Map<DadosRespostaLoteResultadosDBViewModel>(retorno);

                try
                {
                    Log log = new Log(dadosRespostaEnviaLaudoAtendimento);
                    log.partitionKey = "envia-lote-resultados";
                    await _cosmosDbService.AddDocumentAsync(log, log.partitionKey);
                }
                catch
                {
                    ;
                }

                return Ok(dadosRespostaEnviaLaudoAtendimento);
            }
            catch (Exception ex)
            {
                ;
                return Problem(ex.Message, null, null, "Houve um erro no processamento.");
            }
        }

        [HttpPost("reimprimir-etiquetas")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> PostAsync(DadosRequestEnviaAmostrasAtendimentoViewModel dadosRequestEnviaAmostrasAtendimentoViewModel)
        {
            using var service = new DiagnosticoBrasilService.wsrvProtocoloDBSyncClient();
            var dadosRequest = _mapper.Map<ct_EnviaAmostrasAtendimentoRequest>(dadosRequestEnviaAmostrasAtendimentoViewModel);

            try
            {
                dadosRequest.CodigoSenhaIntegracao = _labDbConfig.CodigoSenhaIntegracao;
                dadosRequest.CodigoApoiado = _labDbConfig.CodigoApoiado;
               
                var retorno = await service.EnviaAmostrasAsync(dadosRequest);

                var dadosRespostaEnviaLaudoAtendimento = _mapper.Map<DadosRespostaEnviaAmostrasAtendimentoDBViewModel>(retorno);

                try
                {
                    Log log = new Log(dadosRespostaEnviaLaudoAtendimento);
                    log.partitionKey = "reimprimir-etiquetas";
                    await _cosmosDbService.AddDocumentAsync(log, log.partitionKey);
                }
                catch
                {
                    ;
                }

                return Ok(dadosRespostaEnviaLaudoAtendimento);
            }
            catch (Exception ex)
            {
                ;
                return Problem(ex.Message, null, null, "Houve um erro no processamento.");
            }
        }

        [HttpPost("consulta-status-atendimento")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> PostAsync(DadosRequestConsultaAtendimentoStatusDBViewModel dadosRequestConsultaAtendimentoStatusDBViewModel)
        {
            using var service = new DiagnosticoBrasilService.wsrvProtocoloDBSyncClient();
            var dadosRequest = _mapper.Map<ct_ConsultaAtendimentoStatusRequest_v1>(dadosRequestConsultaAtendimentoStatusDBViewModel);

            try
            {
                dadosRequest.CodigoSenhaIntegracao = _labDbConfig.CodigoSenhaIntegracao;
                dadosRequest.CodigoApoiado = _labDbConfig.CodigoApoiado;

                var retorno = await service.ConsultaStatusAtendimentoAsync(dadosRequest);

                var dadosRespostaEnviaLaudoAtendimento = _mapper.Map<DadosRespostaConsultaAtendimentoStatusDBViewModel>(retorno);

                try
                {
                    Log log = new Log(dadosRespostaEnviaLaudoAtendimento);
                    log.partitionKey = "consulta-status-atendimento";
                    await _cosmosDbService.AddDocumentAsync(log, log.partitionKey);
                }
                catch
                {
                    ;
                }

                return Ok(dadosRespostaEnviaLaudoAtendimento);
            }
            catch (Exception ex)
            {
                ;
                return Problem(ex.Message, null, null, "Houve um erro no processamento.");
            }
        }

        [HttpPost("lista-procedimentos-pendentes")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> PostAsync(DadosRequestListaProcedimentosPendentesDBViewModel dadosRequestListaProcedimentosPendentesDBViewModel)
        {
            using var service = new DiagnosticoBrasilService.wsrvProtocoloDBSyncClient();
            var dadosRequest = _mapper.Map<ct_ListaProcedimentosPendentesRequest_v2>(dadosRequestListaProcedimentosPendentesDBViewModel);

            try
            {
                dadosRequest.CodigoSenhaIntegracao = _labDbConfig.CodigoSenhaIntegracao;
                dadosRequest.CodigoApoiado = _labDbConfig.CodigoApoiado;

                var retorno = await service.ListaProcedimentosPendentesAsync(dadosRequest);

                var dadosRespostaEnviaLaudoAtendimento = _mapper.Map<DadosRespostaListaProcedimentosPendentesDBViewModel>(retorno);

                try
                {
                    Log log = new Log(dadosRespostaEnviaLaudoAtendimento);
                    log.partitionKey = "lista-procedimentos-pendentes";
                    await _cosmosDbService.AddDocumentAsync(log, log.partitionKey);
                }
                catch
                {
                    ;
                }

                return Ok(dadosRespostaEnviaLaudoAtendimento);
            }
            catch (Exception ex)
            {
                ;
                return Problem(ex.Message, null, null, "Houve um erro no processamento.");
            }
        }

        [HttpPost("envia-amostras-procedimentos-pendentes")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> PostAsync(DadosRequestEnviaAmostrasProcedimentosPendentesDBViewModel dadosRequestEnviaAmostrasProcedimentosPendentes)
        {
            using var service = new DiagnosticoBrasilService.wsrvProtocoloDBSyncClient();
            var dadosRequest = _mapper.Map<ct_EnviaAmostrasProcedimentosPendentesRequest_v2>(dadosRequestEnviaAmostrasProcedimentosPendentes);

            try
            {
                dadosRequest.CodigoSenhaIntegracao = _labDbConfig.CodigoSenhaIntegracao;
                dadosRequest.CodigoApoiado = _labDbConfig.CodigoApoiado;

                var retorno = await service.EnviaAmostrasProcedimentosPendentesAsync(dadosRequest);

                var dadosRespostaEnviaLaudoAtendimento = _mapper.Map<DadosRespostaEnviaAmostrasProcedimentosPendentesDBViewModel>(retorno);

                try
                {
                    Log log = new Log(dadosRespostaEnviaLaudoAtendimento);
                    log.partitionKey = "envia-amostras-procedimentos-pendentes";
                    await _cosmosDbService.AddDocumentAsync(log, log.partitionKey);
                }
                catch
                {
                    ;
                }

                return Ok(dadosRespostaEnviaLaudoAtendimento);
            }
            catch (Exception ex)
            {
                ;
                return Problem(ex.Message, null, null, "Houve um erro no processamento.");
            }
        }

        [HttpPost("relatorio-requisicoes-enviadas")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> PostAsync(DadosRequestRelatorioRequisicoesEnviadasDBViewModel dadosRequestRelatorioRequisicoesEnviadasDBViewModel)
        {
            using var service = new DiagnosticoBrasilService.wsrvProtocoloDBSyncClient();
            var dadosRequest = _mapper.Map<ct_RelatorioRequisicoesRequest_v2>(dadosRequestRelatorioRequisicoesEnviadasDBViewModel);

            try
            {
                dadosRequest.CodigoSenhaIntegracao = _labDbConfig.CodigoSenhaIntegracao;
                dadosRequest.CodigoApoiado = _labDbConfig.CodigoApoiado;

                var retorno = await service.RelatorioRequisicoesEnviadasAsync(dadosRequest);

                var dadosRespostaEnviaLaudoAtendimento = _mapper.Map<DadosRespostaRelatorioRequisicoesEnviadasDBViewModel>(retorno);

                return Ok(dadosRespostaEnviaLaudoAtendimento);
            }
            catch (Exception ex)
            {
                ;
                return Problem(ex.Message, null, null, "Houve um erro no processamento.");
            }
        }


    }
}
