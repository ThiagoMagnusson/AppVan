using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ObjResposta<TRetorno>
    {
        public ObjResposta()
        {
            sucesso = false;
        }

        public bool sucesso { get; set; }

        public TRetorno objeto;

        public string Mensagem { get; set; }

    }
}
