using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegracaoEntity.DiagnosticosBrasil
{
    public class DadosRequestRelatorioRequisicoesEnviadasDBViewModel
    {
        private System.DateTime dataInicialField;

        private System.DateTime dataFinalField;


        public System.DateTime DataInicial
        {
            get
            {
                return this.dataInicialField;
            }
            set
            {
                this.dataInicialField = value;
            }
        }


        public System.DateTime DataFinal
        {
            get
            {
                return this.dataFinalField;
            }
            set
            {
                this.dataFinalField = value;
            }
        }
    }
}
