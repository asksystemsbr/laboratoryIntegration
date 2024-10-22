using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegracaoEntity.DiagnosticosBrasil
{
    //ct_ConfirmacaoPedidoEtiqueta
    public class DadosRespostaRecebeAtendimentoDBViewModel
    {
        private StatusLote[] statusLoteField;

        private ConfirmacaoPedidoEtiqueta confirmacaoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        public StatusLote[] StatusLote
        {
            get
            {
                return this.statusLoteField;
            }
            set
            {
                this.statusLoteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ConfirmacaoPedidoEtiqueta Confirmacao
        {
            get
            {
                return this.confirmacaoField;
            }
            set
            {
                this.confirmacaoField = value;
            }
        }
    }

    public partial class StatusLote
    {

        private string numeroLoteField;

        private string arquivoSolicitacaoPedidosField;

        private StatusLotePedido[] pedidosField;

        private System.DateTime dataHoraGravacaoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string NumeroLote
        {
            get
            {
                return this.numeroLoteField;
            }
            set
            {
                this.numeroLoteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string ArquivoSolicitacaoPedidos
        {
            get
            {
                return this.arquivoSolicitacaoPedidosField;
            }
            set
            {
                this.arquivoSolicitacaoPedidosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        public StatusLotePedido[] Pedidos
        {
            get
            {
                return this.pedidosField;
            }
            set
            {
                this.pedidosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public System.DateTime DataHoraGravacao
        {
            get
            {
                return this.dataHoraGravacaoField;
            }
            set
            {
                this.dataHoraGravacaoField = value;
            }
        }
    }

    public partial class ConfirmacaoPedidoEtiqueta
    {

        private ConfirmacaoPedidoEtiquetaItem[] confirmacaoPedidov2Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        public ConfirmacaoPedidoEtiquetaItem[] ConfirmacaoPedidov2
        {
            get
            {
                return this.confirmacaoPedidov2Field;
            }
            set
            {
                this.confirmacaoPedidov2Field = value;
            }
        }
    }

    public partial class ConfirmacaoPedidoEtiquetaItem
    {

        private string numeroAtendimentoApoiadoField;

        private StatusConfirmacaoEnum_v2 statusField;

        private ErroIntegracao[] erroIntegracaoField;

        private string numeroAtendimentoDBField;

        private AmostraEtiqueta[] amostrasField;

        private ConfirmacaoProcedimento[] procedimentosField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string NumeroAtendimentoApoiado
        {
            get
            {
                return this.numeroAtendimentoApoiadoField;
            }
            set
            {
                this.numeroAtendimentoApoiadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public StatusConfirmacaoEnum_v2 Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        public ErroIntegracao[] ErroIntegracao
        {
            get
            {
                return this.erroIntegracaoField;
            }
            set
            {
                this.erroIntegracaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string NumeroAtendimentoDB
        {
            get
            {
                return this.numeroAtendimentoDBField;
            }
            set
            {
                this.numeroAtendimentoDBField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        public AmostraEtiqueta[] Amostras
        {
            get
            {
                return this.amostrasField;
            }
            set
            {
                this.amostrasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 5)]
        public ConfirmacaoProcedimento[] Procedimentos
        {
            get
            {
                return this.procedimentosField;
            }
            set
            {
                this.procedimentosField = value;
            }
        }
    }

    public enum StatusConfirmacaoEnum_v2
    {

        /// <remarks/>
        NaoProcessado,

        /// <remarks/>
        Processado,

        /// <remarks/>
        PedidoReenviado,
    }

    public partial class ErroIntegracao
    {

        private string codigoField;

        private string descricaoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Descricao
        {
            get
            {
                return this.descricaoField;
            }
            set
            {
                this.descricaoField = value;
            }
        }
    }

    public partial class AmostraEtiqueta : Amostra
    {

        private string etiquetaAmostraField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string EtiquetaAmostra
        {
            get
            {
                return this.etiquetaAmostraField;
            }
            set
            {
                this.etiquetaAmostraField = value;
            }
        }
    }
    public partial class StatusLotePedido
    {

        private string nomePacienteField;

        private string numeroAtendimentoDBField;

        private string numeroAtendimentoApoiadoField;

        private string postoColetaField;

        private StatusLoteProcedimento[] procedimentosField;

        private ErroIntegracao[] erroPedidoField;

        private ConfirmacaoProcedimento[] errosProcedimentosField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string NomePaciente
        {
            get
            {
                return this.nomePacienteField;
            }
            set
            {
                this.nomePacienteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string NumeroAtendimentoDB
        {
            get
            {
                return this.numeroAtendimentoDBField;
            }
            set
            {
                this.numeroAtendimentoDBField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string NumeroAtendimentoApoiado
        {
            get
            {
                return this.numeroAtendimentoApoiadoField;
            }
            set
            {
                this.numeroAtendimentoApoiadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string PostoColeta
        {
            get
            {
                return this.postoColetaField;
            }
            set
            {
                this.postoColetaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        public StatusLoteProcedimento[] Procedimentos
        {
            get
            {
                return this.procedimentosField;
            }
            set
            {
                this.procedimentosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 5)]
        public ErroIntegracao[] ErroPedido
        {
            get
            {
                return this.erroPedidoField;
            }
            set
            {
                this.erroPedidoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 6)]
        public ConfirmacaoProcedimento[] ErrosProcedimentos
        {
            get
            {
                return this.errosProcedimentosField;
            }
            set
            {
                this.errosProcedimentosField = value;
            }
        }
    }

    public partial class ConfirmacaoProcedimento
    {

        private string codigoExameDBField;

        private StatusConfirmacaoEnum_v2 statusField;

        private ErroIntegracao[] erroIntegracaoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string CodigoExameDB
        {
            get
            {
                return this.codigoExameDBField;
            }
            set
            {
                this.codigoExameDBField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public StatusConfirmacaoEnum_v2 Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        public ErroIntegracao[] ErroIntegracao
        {
            get
            {
                return this.erroIntegracaoField;
            }
            set
            {
                this.erroIntegracaoField = value;
            }
        }
    }

    public partial class Amostra
    {

        private string numeroAmostraField;

        private string examesField;

        private string contadorAmostraField;

        private string rGPacienteDBField;

        private string nomePacienteField;

        private string meioColetaField;

        private string grupoInterfaceField;

        private string materialField;

        private string regiaoColetaField;

        private string volumeField;

        private string prioridadeField;

        private string tipoCodigoBarrasField;

        private string codigoInstrumentoField;

        private string origemField;

        private bool flagAmostraMaeField;

        private string textoAmostraMaeField;

        private System.DateTime dataSistemaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string NumeroAmostra
        {
            get
            {
                return this.numeroAmostraField;
            }
            set
            {
                this.numeroAmostraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Exames
        {
            get
            {
                return this.examesField;
            }
            set
            {
                this.examesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string ContadorAmostra
        {
            get
            {
                return this.contadorAmostraField;
            }
            set
            {
                this.contadorAmostraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string RGPacienteDB
        {
            get
            {
                return this.rGPacienteDBField;
            }
            set
            {
                this.rGPacienteDBField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string NomePaciente
        {
            get
            {
                return this.nomePacienteField;
            }
            set
            {
                this.nomePacienteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string MeioColeta
        {
            get
            {
                return this.meioColetaField;
            }
            set
            {
                this.meioColetaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string GrupoInterface
        {
            get
            {
                return this.grupoInterfaceField;
            }
            set
            {
                this.grupoInterfaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string Material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string RegiaoColeta
        {
            get
            {
                return this.regiaoColetaField;
            }
            set
            {
                this.regiaoColetaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string Volume
        {
            get
            {
                return this.volumeField;
            }
            set
            {
                this.volumeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string Prioridade
        {
            get
            {
                return this.prioridadeField;
            }
            set
            {
                this.prioridadeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string TipoCodigoBarras
        {
            get
            {
                return this.tipoCodigoBarrasField;
            }
            set
            {
                this.tipoCodigoBarrasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string CodigoInstrumento
        {
            get
            {
                return this.codigoInstrumentoField;
            }
            set
            {
                this.codigoInstrumentoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string Origem
        {
            get
            {
                return this.origemField;
            }
            set
            {
                this.origemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public bool FlagAmostraMae
        {
            get
            {
                return this.flagAmostraMaeField;
            }
            set
            {
                this.flagAmostraMaeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string TextoAmostraMae
        {
            get
            {
                return this.textoAmostraMaeField;
            }
            set
            {
                this.textoAmostraMaeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public System.DateTime DataSistema
        {
            get
            {
                return this.dataSistemaField;
            }
            set
            {
                this.dataSistemaField = value;
            }
        }
    }

    public partial class StatusLoteProcedimento
    {

        private string codigoExameDBField;

        private string identificacaoExameApoiadoField;

        private string materialField;

        private string descricaoExameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string CodigoExameDB
        {
            get
            {
                return this.codigoExameDBField;
            }
            set
            {
                this.codigoExameDBField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string IdentificacaoExameApoiado
        {
            get
            {
                return this.identificacaoExameApoiadoField;
            }
            set
            {
                this.identificacaoExameApoiadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string DescricaoExame
        {
            get
            {
                return this.descricaoExameField;
            }
            set
            {
                this.descricaoExameField = value;
            }
        }
    }
}
