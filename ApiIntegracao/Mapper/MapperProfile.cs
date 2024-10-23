using ApiIntegracaoEntity.DiagnosticosBrasil;
using AutoMapper;
using DiagnosticoBrasilService;
using System.Runtime.CompilerServices;

namespace ApiIntegracaoLab.Mapper
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<DadosRequestRecebeAtendimentoDBViewModel, ct_Atendimento>()
            .ForMember(dest => dest.Pedido, opt => opt.MapFrom(src => src.Pedido)).ReverseMap();

            CreateMap<DadosRespostaRecebeAtendimentoDBViewModel, ct_RecebeAtendimentoEtiquetaResponse>().ReverseMap();
          
            // Mapeamento da propriedade aninhada
            CreateMap<Pedido, ct_Pedido_v2>().ReverseMap();
            CreateMap<Paciente, ct_Paciente_v2>().ReverseMap();
            CreateMap<Questionario, ct_Questionario_v2>().ReverseMap(); ;
            CreateMap<Solicitante, ct_Solicitante_v2>().ReverseMap(); ;
            CreateMap<Procedimento, ct_Procedimento_v2>().ReverseMap();
            CreateMap<AmostraColeta, ct_AmostraColeta_v2>().ReverseMap();

            CreateMap<StatusLote, ct_StatusLote_v2>().ReverseMap();
            CreateMap<ConfirmacaoPedidoEtiqueta, ct_ConfirmacaoPedidoEtiqueta>().ReverseMap();
            CreateMap<StatusLotePedido, ct_StatusLotePedido_v2>().ReverseMap();
            CreateMap<ConfirmacaoPedidoEtiquetaItem, ct_ConfirmacaoPedidoEtiqueta_v2>().ReverseMap();
            CreateMap<ErroIntegracao, ct_ErroIntegracao_v2>().ReverseMap();
            CreateMap<AmostraEtiqueta, ct_AmostraEtiqueta_v2>().ReverseMap();
            CreateMap<ConfirmacaoProcedimento, ct_ConfirmacaoProcedimento_v2>().ReverseMap();
            CreateMap<Amostra, ct_Amostra_v2>().ReverseMap();
            CreateMap<StatusLoteProcedimento, ct_StatusLoteProcedimento_v2>().ReverseMap();

            CreateMap<DadosRequestEnviaLaudoAtendimentoDBViewModel, ct_EnviaLaudoAtendimentoRequest_v2>().ReverseMap();
            CreateMap<DadosRespostaEnviaLaudoAtendimentoDBViewModel, ct_Resultado_v2>().ReverseMap();

            CreateMap<DadosRespostaLoteResultadosDBViewModel, ct_LoteResultados>().ReverseMap();
            CreateMap<LoteResultadosV1, ct_LoteResultados_v1>().ReverseMap();
            CreateMap<LoteResultadosV2, ct_LoteResultados_v2>().ReverseMap();
            CreateMap<ResultadoV1, ct_Resultado_v1>().ReverseMap();
            CreateMap<ResultadoV2, ct_Resultado_v2>().ReverseMap();
            CreateMap<ResultadoProcedimentosV1, ct_ResultadoProcedimentos_v1>().ReverseMap();
            CreateMap<ResultadoProcedimentosV2, ct_ResultadoProcedimentos_v2>().ReverseMap();
            CreateMap<ResultadoProcedimentos, ct_ResultadoProcedimentos_v2>().ReverseMap();
            CreateMap<ResultadoTextoV1, ct_ResultadoTexto_v1>().ReverseMap();
            CreateMap<ResultadoTextoV2, ct_ResultadoTexto_v2>().ReverseMap();
            CreateMap<ResultadoImagemV1, ct_ResultadoImagem_v1>().ReverseMap();
            CreateMap<ResultadoImagemV2, ct_ResultadoImagem_v2>().ReverseMap();
            CreateMap<DadosRequestEnviaAmostrasAtendimentoViewModel, ct_EnviaAmostrasAtendimentoRequest>().ReverseMap();

            CreateMap<DadosRespostaEnviaAmostrasAtendimentoDBViewModel, ct_RecebeAtendimentoEtiquetaResponse>().ReverseMap();
            CreateMap<DadosRequestConsultaAtendimentoStatusDBViewModel, ct_ConsultaAtendimentoStatusRequest_v1>().ReverseMap();
            CreateMap<DadosRespostaConsultaAtendimentoStatusDBViewModel, ct_DadosStatusAtendimento>().ReverseMap();
            CreateMap<DadosStatusPedidoV1, ct_DadosStatusPedido_v1>().ReverseMap();
            CreateMap<DadosStatusProcedimentoV1, ct_DadosStatusProcedimento_v1>().ReverseMap();
            CreateMap<DadosRequestListaProcedimentosPendentesDBViewModel,ct_ListaProcedimentosPendentesRequest_v2>().ReverseMap();
            CreateMap<DadosRespostaListaProcedimentosPendentesDBViewModel, ct_ListaProcedimentosPendentesResponse_v2>().ReverseMap();
            CreateMap<PedidoMPPV2, ct_PedidoMPP_v2>().ReverseMap();
            CreateMap<ProcedimentoMPPV2, ct_ProcedimentoMPP_v2>().ReverseMap();
            CreateMap<DadosRequestEnviaAmostrasProcedimentosPendentesDBViewModel,ct_EnviaAmostrasProcedimentosPendentesRequest_v2>().ReverseMap();
            CreateMap<DadosRespostaEnviaAmostrasProcedimentosPendentesDBViewModel,ct_EnviaAmostrasEtiquetasProcedimentosPendentesResponse_v2>().ReverseMap();
            CreateMap<ListaAmostrasEtiquetasPedido,ct_ListaAmostrasEtiquetasPedido_v2>().ReverseMap();
            CreateMap<DadosRequestRelatorioRequisicoesEnviadasDBViewModel,ct_RelatorioRequisicoesRequest_v2>().ReverseMap();
            CreateMap<DadosRespostaRelatorioRequisicoesEnviadasDBViewModel,ct_RelatorioRequisicoesResponse_v2?>().ReverseMap();





        }
        
    }
}
