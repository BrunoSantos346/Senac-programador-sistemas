using CadastroCliente.Banco_de_dados;
using CadastroCliente.Dominío;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CadastroCliente.Repositorio
{
    internal class RepositorioCliente
    {
        public List<Cliente> ListarCliente()
        {
            var clientes = new List<Cliente>();

            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                // listas de clientes 

                string query = "SELECT c.*, e.logradouro, e.numero, e.complemento, e.bairro, e.municipio, e.estado, e.cep FROM cliente c JOIN endereco e ON c.id_endereco = e.id;";

                using var cmd = new MySqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var nomeSocial = !reader.IsDBNull("nome_social") ? reader.GetString("nome_social") : "";
                    var complemento = !reader.IsDBNull("complemento") ? reader.GetString("complemento") : "";


                    clientes.Add(new Cliente
                    {
                        ID = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        DataNascimento = reader.GetDateTime("data_nascimento"),
                        Email = reader.GetString("email"),
                        Telefone = reader.GetString("telefone"),
                        Tipo = (TipoCliente)reader.GetInt32("tipo"),
                        Etnia = (Etnia)reader.GetInt32("etnia"),
                        GeneroCliente = (GeneroCliente)reader.GetInt32("genero"),
                        Estrageiro = reader.GetBoolean("estrangeiro"),
                        Endereco = new EndereçoCliente()
                        {
                            Id_endereco = reader.GetInt32("id_endereco"),
                            Logradouro = reader.GetString("logradouro"),
                            Numero = reader.GetString("numero"),
                            Complemento = complemento,
                            Bairro = reader.GetString("bairro"),
                            Municipio = reader.GetString("municipio"),
                            Estado = reader.GetString("estado"),
                            Cep = reader.GetString("cep")
                        }
                    });
                }
            }
            return clientes;
        }
        public void InserirClientePorId(Cliente Novocliente)
        {
            using (var conn = DataBase.GetConnection())
            {
                conn.Open();



                // Inserindo Novo Endereço

                string queryEndereco = "INSERT INTO endereco (logradouro, numero, bairro, municipio, estado, cep, complemento) " +
                                        "VALUES (@logradouro, @numero, @bairro, @municipio, @estado, @cep, @complemento);";
                using (var cmd = new MySqlCommand(queryEndereco, conn))
                {
                    cmd.Parameters.AddWithValue("@logradouro", Novocliente.Endereco.Logradouro);
                    cmd.Parameters.AddWithValue("@numero", Novocliente.Endereco.Numero);
                    cmd.Parameters.AddWithValue("@bairro", Novocliente.Endereco.Bairro);
                    cmd.Parameters.AddWithValue("@municipio", Novocliente.Endereco.Municipio);
                    cmd.Parameters.AddWithValue("@estado", Novocliente.Endereco.Estado);
                    cmd.Parameters.AddWithValue("@cep", Novocliente.Endereco.Cep);
                    cmd.Parameters.AddWithValue("@complemento", Novocliente.Endereco.Complemento);
                    cmd.ExecuteNonQuery();
                }

                int Idendereco = -1;
                string queryIdEndereco = "SELECT id FROM endereco " +
                                          "WHERE logradouro = @logradouro " +
                                          "AND numero = @numero " +
                                          "AND bairro = @bairro " +
                                          "AND municipio = @municipio " +
                                          "AND estado = @estado " +
                                          "AND cep = @cep " +
                                          "AND complemento = @complemento;";

                using (var cmd = new MySqlCommand(queryIdEndereco, conn))
                {
                    cmd.Parameters.AddWithValue("@logradouro", Novocliente.Endereco.Logradouro);
                    cmd.Parameters.AddWithValue("@numero", Novocliente.Endereco.Numero);
                    cmd.Parameters.AddWithValue("@bairro", Novocliente.Endereco.Bairro);
                    cmd.Parameters.AddWithValue("@municipio", Novocliente.Endereco.Municipio);
                    cmd.Parameters.AddWithValue("@estado", Novocliente.Endereco.Estado);
                    cmd.Parameters.AddWithValue("@cep", Novocliente.Endereco.Cep);
                    cmd.Parameters.AddWithValue("@complemento", Novocliente.Endereco.Complemento);
                    using (var reader = cmd.ExecuteReader())
                    {
                        Idendereco = reader.Read() ? reader.GetInt32("id") : -1;
                    }
                }
                // Adicionando Novos Clientes

                string query = "INSERT INTO cliente (nome, nome_social, data_nascimento, email, telefone, tipo, etnia, genero, estrangeiro, id_endereco) " +
                                    "VALUES (@nome, @nome_social, @data_nascimento, @email, @telefone, @tipo, @etnia, @genero, @estrangeiro, @id_endereco);";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", Novocliente.Nome);
                    cmd.Parameters.AddWithValue("@nome_social", Novocliente.NomeSocial);
                    cmd.Parameters.AddWithValue("@data_nascimento", Novocliente.DataNascimento);
                    cmd.Parameters.AddWithValue("@email", Novocliente.Email);
                    cmd.Parameters.AddWithValue("@telefone", Novocliente.Telefone);
                    cmd.Parameters.AddWithValue("@tipo", Novocliente.Tipo);
                    cmd.Parameters.AddWithValue("@etnia", Novocliente.Etnia);
                    cmd.Parameters.AddWithValue("@genero", Novocliente.GeneroCliente);
                    cmd.Parameters.AddWithValue("@estrangeiro", Novocliente.Estrageiro);
                    cmd.Parameters.AddWithValue("@id_endereco", Novocliente);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}



