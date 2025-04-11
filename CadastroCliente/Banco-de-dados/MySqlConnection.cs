namespace CadastroCliente.Banco_de_dados
{
    internal class MySqlConnection
    {
        private string connectionString;

        public MySqlConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}