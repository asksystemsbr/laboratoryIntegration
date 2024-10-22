using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegracaoEntity.DiagnosticosBrasil
{
    public class DadosRespostaConsultaAtendimentoStatusDBViewModel
    {
        private DadosStatusPedidoV1 pedidoField;

        private DadosStatusProcedimentoV1[] listaProcedimentoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public DadosStatusPedidoV1 Pedido
        {
            get
            {
                return this.pedidoField;
            }
            set
            {
                this.pedidoField = value;
            }
        }

      
        public DadosStatusProcedimentoV1[] ListaProcedimento
        {
            get
            {
                return this.listaProcedimentoField;
            }
            set
            {
                this.listaProcedimentoField = value;
            }
        }
    }

    public partial class DadosStatusPedidoV1
    {

        private string numeroAtendimentoField;

        private string observacaoField;

        private string numeroPedidoField;

        private string registroExternoField;

        private string registroField;

        public string NumeroAtendimento
        {
            get
            {
                return this.numeroAtendimentoField;
            }
            set
            {
                this.numeroAtendimentoField = value;
            }
        }

        public string Observacao
        {
            get
            {
                return this.observacaoField;
            }
            set
            {
                this.observacaoField = value;
            }
        }

        public string NumeroPedido
        {
            get
            {
                return this.numeroPedidoField;
            }
            set
            {
                this.numeroPedidoField = value;
            }
        }

        public string RegistroExterno
        {
            get
            {
                return this.registroExternoField;
            }
            set
            {
                this.registroExternoField = value;
            }
        }

        public string Registro
        {
            get
            {
                return this.registroField;
            }
            set
            {
                this.registroField = value;
            }
        }
    }

    public partial class DadosStatusProcedimentoV1
    {

        private string codigoExameDBField;

        private string identificacaoExameApoiadoField;

        private System.Nullable<System.DateTime> dataHoraRecepcaoOrigemField;

        private System.Nullable<System.DateTime> dataHoraCheckoutField;

        private System.Nullable<System.DateTime> dataHoraRecepcaoUPField;

        private System.Nullable<System.DateTime> dataHoraLiberacaoTecnicaField;

        private System.Nullable<System.DateTime> dataHoraLiberacaoClinicaField;

        private System.Nullable<System.DateTime> dataHoraDivulgacaoField;

        private System.Nullable<System.DateTime> dataHoraImpressaoField;

        private string statusProducaoField;

        private string tipoMPPField;

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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 2)]
        public System.Nullable<System.DateTime> DataHoraRecepcaoOrigem
        {
            get
            {
                return this.dataHoraRecepcaoOrigemField;
            }
            set
            {
                this.dataHoraRecepcaoOrigemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<System.DateTime> DataHoraCheckout
        {
            get
            {
                return this.dataHoraCheckoutField;
            }
            set
            {
                this.dataHoraCheckoutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 4)]
        public System.Nullable<System.DateTime> DataHoraRecepcaoUP
        {
            get
            {
                return this.dataHoraRecepcaoUPField;
            }
            set
            {
                this.dataHoraRecepcaoUPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 5)]
        public System.Nullable<System.DateTime> DataHoraLiberacaoTecnica
        {
            get
            {
                return this.dataHoraLiberacaoTecnicaField;
            }
            set
            {
                this.dataHoraLiberacaoTecnicaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 6)]
        public System.Nullable<System.DateTime> DataHoraLiberacaoClinica
        {
            get
            {
                return this.dataHoraLiberacaoClinicaField;
            }
            set
            {
                this.dataHoraLiberacaoClinicaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 7)]
        public System.Nullable<System.DateTime> DataHoraDivulgacao
        {
            get
            {
                return this.dataHoraDivulgacaoField;
            }
            set
            {
                this.dataHoraDivulgacaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 8)]
        public System.Nullable<System.DateTime> DataHoraImpressao
        {
            get
            {
                return this.dataHoraImpressaoField;
            }
            set
            {
                this.dataHoraImpressaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string StatusProducao
        {
            get
            {
                return this.statusProducaoField;
            }
            set
            {
                this.statusProducaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string TipoMPP
        {
            get
            {
                return this.tipoMPPField;
            }
            set
            {
                this.tipoMPPField = value;
            }
        }
    }
}
