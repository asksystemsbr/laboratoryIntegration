using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegracaoEntity.DiagnosticosBrasil
{
    public class DadosRespostaListaProcedimentosPendentesDBViewModel
    {
        private PedidoMPPV2[] listaPedidosField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        public PedidoMPPV2[] ListaPedidos
        {
            get
            {
                return this.listaPedidosField;
            }
            set
            {
                this.listaPedidosField = value;
            }
        }
    }

    public partial class PedidoMPPV2
    {

        private string nomePacienteField;

        private string numeroAtendimentoApoiadoField;

        private string numeroAtendimentoDBField;

        private System.DateTime dataHoraPedidoField;

        private ProcedimentoMPPV2[] listaProcedimentoMPPField;

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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public System.DateTime DataHoraPedido
        {
            get
            {
                return this.dataHoraPedidoField;
            }
            set
            {
                this.dataHoraPedidoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        public ProcedimentoMPPV2[] ListaProcedimentoMPP
        {
            get
            {
                return this.listaProcedimentoMPPField;
            }
            set
            {
                this.listaProcedimentoMPPField = value;
            }
        }
    }

    public partial class ProcedimentoMPPV2
    {

        private string codigoExameDBField;

        private int sequenciaExameDBField;

        private string statusField;

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
        public int SequenciaExameDB
        {
            get
            {
                return this.sequenciaExameDBField;
            }
            set
            {
                this.sequenciaExameDBField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Status
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
    }

}
