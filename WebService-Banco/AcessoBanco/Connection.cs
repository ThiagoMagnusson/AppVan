using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoBanco
{
    public class Connection
    {

        public DbConnection conectar()
        {   
            MySqlConnection conexao = new MySqlConnection(
                string.Format("Persist Security Info=False;Database={0};uid={1};pwd={2};" +
                "Server={3};Port={4}", ConexaoConfig.Banco, ConexaoConfig.Usuario, ConexaoConfig.Senha, ConexaoConfig.HostName, ConexaoConfig.Porta)
            );
            conexao.Open();

            return conexao;

        }


    }
}
