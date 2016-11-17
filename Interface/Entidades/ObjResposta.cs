using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ObjResposta<TEntidade>
    {
        public HttpStatusCode StatusResposta { get; set; }

        public string Mensagem { get; set; }
        
        //TEntidade Entidade;

        public string Corpo { get; set; }
    }
}
