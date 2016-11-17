using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService.Models;

namespace AcessoBanco
{
    public class GerenciadoConexao
    {

        private DbConnection conexao;
        private string tabela;

        public GerenciadoConexao(string table)
        {
            Connection banco = new Connection();
            this.conexao = banco.conectar();
            this.tabela = table;
        }

        public void Dispose()
        {
            if (conexao != null)
            {
                conexao.Dispose();
            }
        }

        public Collection<Usuario> PesquisaUsuarioWhere(string Where)
        {
            string select = "select * from "+ this.tabela +" where "+ Where;
            DbCommand comando = conexao.CreateCommand();
            comando.CommandText = select;
            DbDataReader pesquisa = comando.ExecuteReader();

            Collection<Usuario> usuarios = new Collection<Usuario>();

            using (pesquisa)
            {
                if (pesquisa.Read())
                {
                    while (true)
                    {
                        Usuario user = new Usuario();
                        user.id_Usuario = pesquisa.GetInt32(0);
                        user.Login = pesquisa.GetString(1);
                        user.Senha = pesquisa.GetString(2);
                        usuarios.Add(user);

                        if (pesquisa.NextResult() == false)
                        {
                            break;
                        }                        
                    }
                }
            }
            
            return usuarios;
        }
        


    }
}
