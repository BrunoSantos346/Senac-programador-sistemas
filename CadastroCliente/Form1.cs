using CadastroCliente;
using System.Diagnostics;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        List<EndereçoCliente> Endereço = [];
        List<Cliente> Clientes = [];
        private readonly BindingSource BindingSource = [];





        public Form1()
        {

            InitializeComponent();




            Genero.Items.Add("Masculino");
            Genero.Items.Add("Feminino");
            Genero.Items.Add("Outros");


            // Cliente 1
            EndereçoCliente EndereçoBruno = new() { Logradouro = "Rua 123", Numero = "15", Cep = "656578", Bairro = "Morro do Alemão", Estado = "São Paulo", Municipio = "São Paulo", Complemento = "C" };
            Cliente Bruno = new Cliente() { ID = 01, Nome = "Bruno", DataNascimento = "12/03/1998", GeneroCliente = GeneroCliente.Masculino, Endereco = EndereçoBruno, Tipo = TipoCliente.PF, Estrageiro = false, Etnia = global::Etnia.Negro };
            Clientes.Add(Bruno);

            // Cliente 2

            EndereçoCliente EndereçoNala = new EndereçoCliente() { Logradouro = "Rua limo", Numero = "20", Cep = "123456", Bairro = "Morro da Rocinha", Estado = "Rio de Janeiro", Municipio = "Rio Janeiro", Complemento = "B" };
            Cliente Nala = new Cliente() { ID = 02, Nome = "Nala", DataNascimento = "30/05/71", GeneroCliente = GeneroCliente.Feminino, Endereco = EndereçoNala, Tipo = TipoCliente.PF, Estrageiro = false, Etnia = global::Etnia.Branco };
            Clientes.Add(Nala);

            //Cliente 3

            EndereçoCliente EndereçoAndersonSilva = new EndereçoCliente() { Bairro = "Meier", Logradouro = "Rua Dos Anjos", Cep = "898786", Complemento = "Casa 2", Estado = "Rio de Janeiro", Municipio = "Rio Janeiro", Numero = "456" };
            Cliente AndersonSilva = new Cliente() { Nome = "Anderson", DataNascimento = "25/07/54", Endereco = EndereçoAndersonSilva, Tipo = TipoCliente.Pj, GeneroCliente = GeneroCliente.Masculino, Estrageiro = false, Etnia = global::Etnia.Negro };
            Clientes.Add(AndersonSilva);

            BindingSource.DataSource = Clientes;
            dataGridView1.DataSource = BindingSource;
        }




        public bool ValidarCampo()
        {
            if (!textBoxNome.Text.Any(char.IsWhiteSpace) || textBoxNome.Text.Any(char.IsNumber) || textBoxNome.Text.Any(char.IsPunctuation))
            {

                MessageBox.Show("O Nome é Obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!radioButtonPF.Checked && !radioButtonPJ.Checked)
            {
                MessageBox.Show("!!!Informe se Voce e Pessoa Fisíca ou Jurídica!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string Email = textBoxEmail.Text;

            if (string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("!!!Campo De Email é Obrigatório!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!Email.Contains("@"))
            {
                MessageBox.Show("!!!O Email Deve Conter '@'!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(DataNascimento.Text))
            {
                DataNascimento.Text = "00/00/0000";
                MessageBox.Show("!!!Data de Nascimento em Branco!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Regex.IsMatch(DataNascimento.Text, "@,/,$,"))
            {
                MessageBox.Show("!!!Insira uma Data Valída!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(TelefoneBox.Text))
            {
                TelefoneBox.Text = "(00) 00000000";
                MessageBox.Show("!!! Numero  de Telefone Obrigatorio!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Genero.SelectedIndex == -1)
            {
                MessageBox.Show("!!!Selecione uma da Opções!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Etnia.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma das opções de etnia, por favor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else if (string.IsNullOrEmpty(Logradouro.Text))
            {
                MessageBox.Show("!!!O campo 'Logradoro' é Obrigatório!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(Numero.Text))
            {
                Numero.Text = "0";
                MessageBox.Show("\"!!!O campo 'Numero' é Obrigatório!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (EstadoBox.SelectedIndex == -1)
            {
                MessageBox.Show("!!!O campo 'Estado' é Obrigatório Selecione uma Das Opções!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else if (string.IsNullOrEmpty(Cep.Text))
            {
                Cep.Text = "00000-000";
                MessageBox.Show("!!!O campo 'CEP' é Obrigatório!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(Complemento.Text))
            {
                MessageBox.Show("!!!O campo 'Complemento' é Obrigatório!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(Municipio.Text))
            {
                MessageBox.Show("!!!O campo 'Municipio' é Obrigatório!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(Bairro.Text))
            {
                MessageBox.Show("!!!O campo 'Bairro' é Obrigatório!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("!!!Cadastro Realizado Com Sucesso!!!", "Cadastro Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return true;




        }
        public string AtualizarCampos()
        {
            textBoxNome.Clear();
            textBoxEmail.Clear();
            textBoxNomeSocial.Clear();
            TelefoneBox.Clear();
            Municipio.Clear();
            EstadoBox.Items.Clear();
            Genero.Items.Clear();
            Etnia.Items.Clear();



            return textBoxNome.ToString();
        }
        public string AdicionarCliente()
        {
            GeneroCliente GeneroSelecionado = (GeneroCliente)Genero.SelectedIndex;
            Etnia EtniaSelecionada = (Etnia)Etnia.SelectedIndex;
            TipoCliente Tipo = radioButtonPF.Checked ? TipoCliente.PF : TipoCliente.Pj;

            var Email = textBoxEmail.Text;
            var Telefone = TelefoneBox.Text;

            Clientes.Add(new Cliente() { ID = Clientes.Max(Cliente => Cliente.ID) + 1, Email = textBoxEmail.Text, Telefone = TelefoneBox.Text, Nome = textBoxNome.Text, DataNascimento = DataNascimento.Text, GeneroCliente = GeneroSelecionado, Etnia = EtniaSelecionada, Tipo = Tipo, Estrageiro = checkBoxEstrageiro.Checked });
            Endereço.Add(new EndereçoCliente() { Bairro = Bairro.Text, Cep = Cep.Text, Complemento = Complemento.Text, Estado = EstadoBox.Text, Municipio = Municipio.Text, Logradouro = Logradouro.Text, Numero = Numero.Text });



            return "Cliente Cadastrado Com Sucesso";

        }
        public bool ValidarEmail()
        {
            for (int i = 0; i < Clientes.Count; i++)
            {
                if (Clientes[i].Email == textBoxEmail.Text)
                {
                    MessageBox.Show("Esse Email ja esta Sendo Usado","Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        public bool ValidarTelefone()
        {
            for (int i = 0; i < Clientes.Count; i++)
            {
                if (Clientes[i].Telefone == TelefoneBox.Text)
                {
                    MessageBox.Show("Esse Telefone ja esta Sendo Usado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            ValidarCampo();
            ValidarEmail();
            ValidarTelefone();
            AdicionarCliente();
            AtualizarCampos();



            BindingSource.ResetBindings(false);
        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        
        
    }


}


