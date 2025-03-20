using CadastroCliente;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        List<EndereçoCliente> Endereço = [];
        List<Cliente> Clientes = [];
        List<int> ListaID = new List<int>();



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


        }




        public bool ValidarCampo()
        {
            if (string.IsNullOrEmpty(textBoxNome.Text))
            {
               

                MessageBox.Show("O Nome é Obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textBoxNome.Text.Contains("1,2,3,4,5,6,7,8,9,0,@,$,#,&,%,!"))
            {
                MessageBox.Show("!!!!!O Nome não pode Conter Numeros ou Caracteres Especiais!!!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!radioButtonPF.Checked || radioButtonPJ.Checked)
            {
                MessageBox.Show("!!!Selecione Todas as Opções!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrEmpty(DataNascimento.Text))
            {
                DataNascimento.Text = "00/00/0000";
                MessageBox.Show("!!!Data de Nascimento em Branco!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Regex.IsMatch(DataNascimento.Text, "@,/,$,"))
            {
                MessageBox.Show("!!!Não e Permitido o Uso de Caracteres!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(TelefoneBox.Text))
            {
                TelefoneBox.Text = "(00) 00000000";
                MessageBox.Show("!!! Numero  de Telefone Obrigatorio!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Genero.SelectedIndex == -1)
            {
                MessageBox.Show("!!!Selecione uma da Opções!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(Etnia.SelectedIndex == -1)
            {
                MessageBox.Show("!!!Selecione uma Das opções de Etinia, Por favor!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(string.IsNullOrEmpty(Logradouro.Text))
            {
                MessageBox.Show("!!!O campo 'Logradoro' é Obrigatório!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(string.IsNullOrEmpty(Numero.Text))
            {
                Numero.Text = "0";
                MessageBox.Show("\"!!!O campo 'Numero' é Obrigatório!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(EstadoBox.SelectedIndex == -1)
            {
                MessageBox.Show("!!!O campo 'Estado' é Obrigatório Selecione uma Das Opções!!!","Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if(string.IsNullOrEmpty(Cep.Text))
            {
                Cep.Text = "00000-000";
                MessageBox.Show("!!!O campo 'CEP' é Obrigatório!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(Complemento.Text))
            {
                MessageBox.Show("!!!O campo 'Complemento' é Obrigatório!!!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            if(string.IsNullOrEmpty(Municipio.Text))
            {
                MessageBox.Show("!!!O campo 'Municipio' é Obrigatório!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(Bairro.Text))
            {
                MessageBox.Show("!!!O campo 'Bairro' é Obrigatório!!!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("!!!Cadastro Realizado Com Sucesso!!!","Cadastro Finalizado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return true;
            }
            



        }
        public int ProximoID = 1;
        public int GeraID()
        {
            int NovoID = ProximoID;
            ProximoID++;
            return NovoID;

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
        public string AdicionarCliente ()
        {
            GeneroCliente GeneroSelecionado = (GeneroCliente)Genero.SelectedIndex;
            Etnia EtniaSelecionada = (Etnia)Etnia.SelectedIndex;
            TipoCliente Tipo = radioButtonPF.Checked ? TipoCliente.PF : TipoCliente.Pj;

            var Email = textBoxEmail.Text;
            var Telefone = TelefoneBox.Text;

            Clientes.Add(new Cliente() { Nome = textBoxNome.Text, DataNascimento = DataNascimento.Text, GeneroCliente = GeneroSelecionado, Etnia = EtniaSelecionada, Tipo = Tipo, Estrageiro = checkBoxEstrageiro.Checked });
            Endereço.Add(new EndereçoCliente() { Bairro = Bairro.Text, Cep = Cep.Text, Complemento = Complemento.Text, Estado = EstadoBox.Text, Municipio = Municipio.Text, Logradouro = Logradouro.Text, Numero = Numero.Text });
            textBoxEmail.Clear();
            textBoxNome.Clear();
            TelefoneBox.Clear();
            Bairro.Clear();
            Cep.Clear();
            Municipio.Clear();
            Complemento.Clear();

            foreach (Cliente cliente in Clientes)
            {
                if (Email.Equals(Email, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("!!!Esse Email Ja Foi Cadastrado!!!","Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                if(Telefone.Equals(Telefone,StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("!!! Esse Numero Ja Esta Sendo Usado","Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }


            }return textBoxEmail.ToString();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
            ValidarCampo();
            AdicionarCliente();
            GeraID();
            
            
        }



    }
}
  