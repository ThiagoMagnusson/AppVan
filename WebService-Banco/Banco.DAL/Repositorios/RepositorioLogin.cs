using Banco.DAL.Repositorios.Base;
using Banco.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.DAL.Repositorios
{
    public class RepositorioLogin : Repositorio<Login>
    {
        
        public Login PesquisaPorUsuario(string usuario)
        {
            IQueryable<Login> pesquisa = Pesquisar(l => l.Usuario == usuario);

            Adicionar(new Login()
            {
                Usuario = "AMAURI"
                ,Senha = "123456"
            });

            IEnumerable<Login> pesquisa2 = PesquisarTodos().ToList();
            
            return this.Pesquisar(l => l.Usuario == usuario).ToList().FirstOrDefault();
        }

        public Login PesquisaPorUsuario(Login lg)
        {
            return this.PesquisaPorUsuario(lg.Usuario);
        }


    }
}
