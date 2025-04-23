using CadastroProduto.Dominío;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProduto.Repositorio
{
    internal class Repositorio
    {
        public void CadastrarProduto(string Nome, DateTime data_produto, decimal preco)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "INSERT INTO produto (nome,data_produto) VALUES (@nome, @data_produto, @preco)";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nome", Nome);
                    cmd.Parameters.AddWithValue("@data_produto", data_produto);
                    cmd.Parameters.AddWithValue("@preco", preco );
                    cmd.ExecuteNonQuery();
                }
            }
        }

        

        
    }
}
