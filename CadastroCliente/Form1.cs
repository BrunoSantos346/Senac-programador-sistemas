namespace CadastroCliente
{
    public partial class Form1 : Form
    {

        List<Cliente> Clientes = [];


        public Form1()
        {

            InitializeComponent();
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
                MessageBox.Show("O Nome é Obrigatório","Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public string AtualizarCampos()
        {
           textBoxNome.Clear();
           textBoxEmail.Clear();
           textBoxNomeSocial.Clear();
           Telefone.Clear();
           Municipio.Clear();
           Estado.Items.Clear();
           Genero.Items.Clear();
           Etnia.Items.Clear();
            

           
            return textBoxNome.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
