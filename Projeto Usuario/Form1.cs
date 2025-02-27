namespace Projeto_Usuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Resultado_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string nome = textBoxName.Text;
            string senha = textBoxSenha.Text;
            string CPF = textBoxCPF.Text;
            string resultado = labeResuktado.Text;









            if (senha == string.Empty)
            {
                labelSenha.Text = "*Senha obrigatória!!";
                labelSenha.ForeColor = Color.Red;
                return;

            }

            if (email == string.Empty)
            {
                labelEmail.Text = "*Email Obrigatorio!!";
                labelEmail.ForeColor = Color.Red;
                return;
            }


            if (nome == null || nome == "")
            {
                labelNome.Text = "*Nome Obrigaório!!";
                labelNome.ForeColor = Color.Red;

            }

            else if (CPF == string.Empty)
            {
                labelCPF.Text = "*CPF é Obrigatório!!";
                labelCPF.ForeColor = Color.Red;

                labeResuktado.Text = "Preencha todos os Campos!!!";
                labeResuktado.ForeColor = Color.Red;
                textBoxCPF.Clear();
                textBoxEmail.Clear();
                textBoxName.Clear();
                textBoxSenha.Clear();

            }
            else
            {
                labeResuktado.Text = "Conta criada com Sucesso";
                labeResuktado.ForeColor = Color.Green;
                
            }
































        }
    }
}
