using Banco.Entidades;
using Logica;
using Logica.Autenticacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace WebService.Controllers
{
    public class LoginController : ApiController
    {

        private GerenciadorLogin genLogin;

        public LoginController()
        {
            genLogin = new GerenciadorLogin();
        }

        [HttpPost]
        public HttpResponseMessage Autenticar()
        {
            HttpResponseMessage resposta;

            //Capturando o login no contexto da aplicacao
            Login login = this.Request.Content.ReadAsAsync<Login>().Result;

            //Metodo que autentica o login
            ObjResposta<Login> autenticacao = genLogin.Autenticar(login);


            if (autenticacao.sucesso)
            {
                resposta = Request.CreateResponse<string>(HttpStatusCode.OK, autenticacao.Mensagem);
            }
            else
            {
                resposta = Request.CreateResponse<string>(HttpStatusCode.Forbidden, autenticacao.Mensagem);
            }

            return resposta;
        }


    }
}