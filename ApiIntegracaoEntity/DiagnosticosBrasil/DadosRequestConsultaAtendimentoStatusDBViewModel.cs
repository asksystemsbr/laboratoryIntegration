using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegracaoEntity.DiagnosticosBrasil
{
    public class DadosRequestConsultaAtendimentoStatusDBViewModel
    {
        private string numeroAtendimentoApoiadoField;

        private string procedimentoField;

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

        public string Procedimento
        {
            get
            {
                return this.procedimentoField;
            }
            set
            {
                this.procedimentoField = value;
            }
        }
    }
}
