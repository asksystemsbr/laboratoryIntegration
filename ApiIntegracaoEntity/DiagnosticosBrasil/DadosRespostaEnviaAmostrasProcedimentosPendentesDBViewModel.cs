using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegracaoEntity.DiagnosticosBrasil
{
    public class DadosRespostaEnviaAmostrasProcedimentosPendentesDBViewModel
    {
        private ListaAmostrasEtiquetasPedido[] pedidosAmostrasField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        public ListaAmostrasEtiquetasPedido[] PedidosAmostras
        {
            get
            {
                return this.pedidosAmostrasField;
            }
            set
            {
                this.pedidosAmostrasField = value;
            }
        }
    }

    public partial class ListaAmostrasEtiquetasPedido
    {

        private string numeroAtendimentoApoiadoField;

        private string numeroAtendimentoDBField;

        private AmostraEtiqueta amostrasField;

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
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        public AmostraEtiqueta Amostras
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
    }
}
