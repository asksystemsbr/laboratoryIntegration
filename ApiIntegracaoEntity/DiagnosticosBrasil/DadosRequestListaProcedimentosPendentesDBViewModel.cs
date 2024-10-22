using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegracaoEntity.DiagnosticosBrasil
{
    public class DadosRequestListaProcedimentosPendentesDBViewModel
    {
        private System.DateTime dtInicialField;

        private System.DateTime dtFinalField;

        public System.DateTime dtInicial
        {
            get
            {
                return this.dtInicialField;
            }
            set
            {
                this.dtInicialField = value;
            }
        }

        public System.DateTime dtFinal
        {
            get
            {
                return this.dtFinalField;
            }
            set
            {
                this.dtFinalField = value;
            }
        }
    }
}
