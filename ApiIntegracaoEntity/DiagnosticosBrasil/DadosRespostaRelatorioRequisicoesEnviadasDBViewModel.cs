using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegracaoEntity.DiagnosticosBrasil
{
    public class DadosRespostaRelatorioRequisicoesEnviadasDBViewModel
    {
        private byte[] relatorioPDFField;

        public byte[] RelatorioPDF
        {
            get
            {
                return this.relatorioPDFField;
            }
            set
            {
                this.relatorioPDFField = value;
            }
        }
    }
}
