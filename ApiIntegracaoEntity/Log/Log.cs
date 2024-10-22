using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegracaoEntity.Log
{
    public class Log
    {
        public string id { get; set; }
        public object documento {  get; set; }

        public string partitionKey { get; set; }


        public Log(object documento) {
            id = Guid.NewGuid().ToString();
            this.documento = documento;
        }


    }
}
