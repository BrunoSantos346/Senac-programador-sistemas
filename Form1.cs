namespace login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textboxEmail.Text;
            labelResultado.Text = usuario;
            string senha = textBoxSenha.Text;


            
            
            if (usuario == "Bruno123" && senha == "1234")
            {
                labelResultado.Text = "Autenticado com Sucesso";
                labelResultado.ForeColor = Color.Green;
            }
            
            
            
            if (usuario == null || usuario == "")
            {
                labelResultado.Text = "Usuario é Obrigatorio!!";
                labelResultado.ForeColor = Color.Red; 
                return;
            }

            

        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
