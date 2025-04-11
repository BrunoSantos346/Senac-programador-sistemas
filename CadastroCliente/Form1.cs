using System.ComponentModel;
using CadastroCliente.Domin�o;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {

        List<Cliente> Clientes = [];
        private readonly BindingSource BindingSource = [];





        public Form1()
        {

            InitializeComponent();




            Genero.Items.Add("Masculino");
            Genero.Items.Add("Feminino");
            Genero.Items.Add("Outros");


            // Cliente 1
            Endere�oCliente Endere�oBruno = new() { Logradouro = "Rua 123", Numero = "15", Cep = "656578", Bairro = "Morro do Alem�o", Estado = "S�o Paulo", Municipio = "S�o Paulo", Complemento = "C" };
            Cliente Bruno = new Cliente() { ID = 01, Nome = "Bruno", DataNascimento = "12/03/1998", GeneroCliente = GeneroCliente.Masculino, Endereco = Endere�oBruno, Tipo = TipoCliente.PF, Estrageiro = false, Etnia = global::Etnia.Negro };
            Clientes.Add(Bruno);

            // Cliente 2

            Endere�oCliente Endere�oNala = new Endere�oCliente() { Logradouro = "Rua limo", Numero = "20", Cep = "123456", Bairro = "Morro da Rocinha", Estado = "Rio de Janeiro", Municipio = "Rio Janeiro", Complemento = "B" };
            Cliente Nala = new Cliente() { ID = 02, Nome = "Nala", DataNascimento = "30/05/71", GeneroCliente = GeneroCliente.Feminino, Endereco = Endere�oNala, Tipo = TipoCliente.PF, Estrageiro = false, Etnia = global::Etnia.Branco };
            Clientes.Add(Nala);

            //Cliente 3

            Endere�oCliente Endere�oAndersonSilva = new Endere�oCliente() { Bairro = "Meier", Logradouro = "Rua Dos Anjos", Cep = "898786", Complemento = "Casa 2", Estado = "Rio de Janeiro", Municipio = "Rio Janeiro", Numero = "456" };
            Cliente AndersonSilva = new Cliente() { Nome = "Anderson", DataNascimento = "25/07/54", Endereco = Endere�oAndersonSilva, Tipo = TipoCliente.Pj, GeneroCliente = GeneroCliente.Masculino, Estrageiro = false, Etnia = global::Etnia.Negro };
            Clientes.Add(AndersonSilva);

            BindingSource.DataSource = Clientes;
            dataGridView1.DataSource = BindingSource;
        }




        public bool ValidarCampo()
        {
            if (!textBoxNome.Text.Any(char.IsWhiteSpace) || textBoxNome.Text.Any(char.IsPunctuation))
            {

                Erro.Text = "O Campo Nome � Obrigatorio";
                return false;
            }
            if (!radioButtonPF.Checked && !radioButtonPJ.Checked)
            {
                Erro.Text = "Informe Se voc� � Uma Pessoa Jurid�ca ou Fis�ca";
                return false;
            }

            string Email = textBoxEmail.Text;

            if (string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                Erro.Text = "O Campo Email � Obrigat�rio";
                return false;
            }
            if (!Email.Contains("@"))
            {
                Erro.Text = "Insira um Email Valido";
                return false;
            }


            if (DataNascimento.Text.Contains(" "))
            {
                Erro.Text = "O campo Data e Obrigat�rio";
                return false;
            }
            

            if (string.IsNullOrEmpty(TelefoneBox.Text))
            {
                Erro.Text = "Insira um Telefone Val�do";
                return false;
            }



            if (Genero.SelectedIndex == -1)
            {
               Erro.Text = "Informe Seu Gen�ro";
               return false;
            }
            if (Etnia.SelectedIndex == -1)
            {
                Erro.Text = "Informe Sua Etnia";
                return false;

            }
            if (string.IsNullOrEmpty(Logradouro.Text))
            {
                Erro.Text = "Informe O Logradouro Do Seu Endere�o";
                return false;
            }
            if (string.IsNullOrEmpty(Numero.Text))
            {

                Erro.Text = "Informe o Numero Do Seu Endere�o";
                return false;
            }
            if (EstadoBox.SelectedIndex == -1)
            {
                Erro.Text = "Informe Seu Estado";
                return false;

            }
            if (string.IsNullOrEmpty(Complemento.Text))
            {
                Erro.Text = "Informe o Complemento Do Seu Endere�o";
                return false;
            }
            if (string.IsNullOrEmpty(Municipio.Text))
            {
                Erro.Text = "Informe seu Municipio";
                return false;
            }
            if (string.IsNullOrEmpty(Bairro.Text))
            {
                Erro.Text = "Infomer Seu Bairro";
                return false;
            }

            else
            {
                MessageBox.Show("!!!Cadastro Realizado Com Sucesso!!!", "Cadastro Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return true;














        }
        public string AdicionarCliente()
        {
            GeneroCliente GeneroSelecionado = (GeneroCliente)Genero.SelectedIndex;
            Etnia EtniaSelecionada = (Etnia)Etnia.SelectedIndex;
            TipoCliente Tipo = radioButtonPF.Checked ? TipoCliente.PF : TipoCliente.Pj;

            var Email = textBoxEmail.Text;
            var Telefone = TelefoneBox.Text;

            Clientes.Add(new Cliente()
            {
                ID = Clientes.Max(Cliente => Cliente.ID) + 1,
                Email = textBoxEmail.Text,
                Telefone = TelefoneBox.Text,
                Nome = textBoxNome.Text,
                DataNascimento = DataNascimento.Text,
                GeneroCliente
                = GeneroSelecionado,
                Etnia = EtniaSelecionada,
                Tipo = Tipo,
                Estrageiro = checkBoxEstrageiro.Checked,
                Endereco =  { Bairro =  Bairro.Text, Cep = Cep.Text, Complemento = Complemento.Text, Estado = EstadoBox.Text, Municipio = Municipio.Text, Logradouro = Logradouro.Text, Numero = Numero.Text }


            });
            



            return "Cliente Cadastrado Com Sucesso";

        }
        public bool ValidarTelefone()
        {
            foreach (Cliente cliente in Clientes)
            {
                if (cliente.Telefone == TelefoneBox.Text)
                {
                    Erro.Text = "Este Telefone ja esta em Uso";
                    return false;
                }

            }
            return true;






        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (ValidarCampo() || ValidarTelefone() || ValidarEmail()) { return; }
            AdicionarCliente();
            BindingSource.ResetBindings(false);
            dataGridView1.Refresh();
            







        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        public bool ValidarEmail()
        {
            foreach (Cliente cliente in Clientes)
            {
                if (cliente.Email == textBoxEmail.Text)
                {
                    Erro.Text = "Este Email ja Est� em Uso";
                    return false;

                }

            }
            return true;


        }
    }
}



