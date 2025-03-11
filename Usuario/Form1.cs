namespace Usuario
{
    public partial class Form1 : Form
        // Declaração de Classe
    {

        List<Usuario> usuarios = new List<Usuario>();

        public Form1()
        {
            InitializeComponent();
            usuarios.Add(new Usuario() { Email = "Neymar.jr@email.com", Senha = "Brun@123" });
            usuarios.Add(new Usuario() { Email = "Pablo.vitar@email.com", Senha = "12345abc" });
            usuarios.Add(new Usuario() { Email = "Sukuna.silva@email.com", Senha = "Sete7Sete" });

        }

        private const int V = -1;
        private const string V1 = "Usuario Criado";

        List<string> listausuario = new List<string>() { "Neymar jr", "Pablo vitar", "Sukuna silva", "Bruno" };
        List<string> listaSenhas = new List<string>() { "Bruna", "1234", "777", };

        // Usuario Cadastrado

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonUser_Click(object sender, EventArgs e)


        {

            bool Autenticação = false;
            string Usuario = textBoxUsuario.Text;
            string Senha = textBoxSenha.Text;





            if (string.IsNullOrEmpty(Usuario) || string.IsNullOrEmpty(Senha))
            {
                labelUsuario.Text = "Usuario Ou Senha Icorretos";
                labelUsuario.ForeColor = Color.Red;


                
            }
            if (string.IsNullOrEmpty(Usuario))
            {

                labelUser.Text = "Usuario Obrigatório";
                labelUser.ForeColor = Color.Red;

            }
            if (string.IsNullOrEmpty(Senha))
            {
                labelSen.Text = "Senha Obrigatória";
                labelSen.ForeColor = Color.Red;
                return;
            }
            for (int i = 0; i < usuarios.Count; i++)
            {

                if (usuarios[i].Email == Usuario && usuarios[i].Senha == Senha)
                {
                    Autenticação = true;
                }
                
                


            }
            for(int i = 0;i < listaSenhas.Count;i++)
            {
                if (usuarioBuscado)
                {
                    
                    labelSen.Text = "Senha Incorreta!!!";
                    labelSen.ForeColor = Color.Red;
                    usuarioBuscado = true;
                    
                }
                else
                {
                    labelUsuario.Text = "Logado";
                    labelUsuario.ForeColor= Color.Green;
                    usuarioBuscado = true;
                }
            }





        }
    }
}
