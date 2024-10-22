using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegracaoEntity.DiagnosticosBrasil
{
    public class DadosRequestEnviaAmostrasProcedimentosPendentesDBViewModel
    {
        private PedidoMPPV2 amostrasField;

        public PedidoMPPV2 Amostras
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
