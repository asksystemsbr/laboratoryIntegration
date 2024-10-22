using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegracaoEntity.DiagnosticosBrasil
{
    public class DadosRespostaEnviaAmostrasAtendimentoDBViewModel
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

   


}
