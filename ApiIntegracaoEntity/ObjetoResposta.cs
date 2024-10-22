using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegracaoEntity
{
    public class ObjetoResposta
    {
        public ObjetoResposta()
        {
                
        }

        public ObjetoResposta(dynamic resposta,List<string> erros = null)
        {
            this.Resposta = resposta;
            this.Erros = erros;
        }

        public dynamic Resposta { get; set; }
        public List<string> Erros { get; set; } = null;
    }
}
