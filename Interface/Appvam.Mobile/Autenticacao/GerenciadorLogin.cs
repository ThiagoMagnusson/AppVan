using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appvam.Mobile.Autenticacao
{
    public class GerenciadorLogin
    {
        AcessoWebService acessoWS;

        public GerenciadorLogin()
        {
            this.acessoWS = new AcessoWebService();
        }


        public ObjResposta<Login> Autenticar(Login login)
        {
            ObjResposta<Login> retorno = new ObjResposta<Login>();

            ObjResposta<string> execucao = acessoWS.Executar("Login/Autenticar", login);

            retorno.Mensagem = execucao.Corpo;
            retorno.StatusResposta = execucao.StatusResposta;

            return retorno;
        }


       


    }
}
