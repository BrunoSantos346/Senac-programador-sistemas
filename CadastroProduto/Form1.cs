using CadastroProduto.Repositorio;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace CadastroProduto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void buttonCadastrar_Click(object sender, EventArgs e)
        {
            adicinandoProduto();
        }

        private void adicionarProduto()
        {
            string nome = textBoxProduto.Text.Trim();
            string precoTexto = maskedTextBox1.Text.Replace("R$", "").Trim().Replace(",", ".");

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(precoTexto))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }
            decimal preco;

            if (!decimal.TryParse(precoTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out preco))
            {
                MessageBox.Show("Preço inválido.");
                return;
            }
            preco.ToString("C", new CultureInfo("pt-BR"));
            dataGridViewProduto.Rows.Add(nome, preco.ToString("C"));






        }

        public void adicinandoProduto()
        {
            string nome = textBoxProduto.Text;
            DateTime dataProduto = DateTime.Now;
            string precoTexto = maskedTextBox1.Text
            .Replace("R$", "")
            .Trim()
            .Replace(",", ".");

            decimal preco;

            if (decimal.TryParse(precoTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out preco))
            {
                MessageBox.Show("Preço inválido. Digite um valor válido.");
                return;

            }
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "INSERT INTO produto (nome, data_produto, preco) VALUES (@nome, @data_produto, @preco)";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@data_produto", dataProduto);
                    cmd.Parameters.AddWithValue("@preco", preco);

                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
}
