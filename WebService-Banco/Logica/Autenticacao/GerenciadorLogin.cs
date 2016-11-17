using Banco.DAL.Repositorios;
using Banco.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Autenticacao
{
    public class GerenciadorLogin
    {
        RepositorioLogin repLogin;


        public ObjResposta<Login> Autenticar(Login AutenticLogin)
        {
            ObjResposta<Login> resposta = new ObjResposta<Login>();
            Login Pesqlogin;

            using (RepositorioLogin repLogin = new RepositorioLogin())
            {
                Pesqlogin = repLogin.PesquisaPorUsuario(AutenticLogin.Usuario);
            }

            if (Pesqlogin != null)
            {
                if (Pesqlogin.Senha.Trim().Equals(Pesqlogin.Senha.Trim()))
                {
                    resposta.sucesso = true;
                    resposta.Mensagem = "Usuario Autenticado com Sucesso";
                    resposta.objeto.Id = Pesqlogin.Id;
                }
            }
            else
            {
                resposta.Mensagem = "Login ou Senha invalidos";
            }

            return resposta;
        }

    }
}
