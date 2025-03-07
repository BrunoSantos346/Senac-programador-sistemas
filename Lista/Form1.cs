using System;
using System.Diagnostics.Eventing.Reader;

namespace Lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int V = -1;
        private const string V1 = "Usuario Criado";
        List<string> listausuario = new List<string>() { "Neymar jr", "Pablo vitar", "Sukuna silva", "Bruno" };
        List<string> listaSenhas = new List<string>() { "Bruna", "1234", "777", };
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string UsuarioBuscado = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            if (string.IsNullOrEmpty(UsuarioBuscado))
            {
                labelUsuario.Text = "Usuario Obrigatório!!!";
                labelUsuario.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrEmpty(senha))
            {
                labelSenha.Text = "Senha Obrigatória!!";
                labelSenha.ForeColor = Color.Red;
            }

            int posicaodousuario = -1;

            for (int i = 0; i < listausuario.Count; i++)
            {
                if (UsuarioBuscado == listausuario[i])
                {
                    posicaodousuario = i;
                }

                if (posicaodousuario > -1 && senha == listaSenhas[posicaodousuario])
                {
                    labelResultado.Text = "Autenticado com Sucesso";
                    labelResultado.ForeColor = Color.Green;
                }
                else
                {
                    labelResultado.Text = "Usuario ou senha incorretos!!!!";
                    labelResultado.ForeColor = Color.Red;
                }
            }







































        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelResultadocadastro_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string letrasMinusculas = "abcdefghijklmnopqrstuvwxyz";
            string letrasMaiusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numeros = "0123456789";
            string caracteresEspeciais = "!@#$%^&*()-_=+[]{}|;:,.<>?";
            string SenhaNova = textBoxCriarSenha.Text;
            string Novousuario = textBoxEmail.Text;
            string Novasenha = textBoxCriarSenha.Text;
            string todosOsCaracteres = letrasMinusculas + letrasMaiusculas + numeros + caracteresEspeciais;



            if (string.IsNullOrEmpty(Novousuario))
            {
                labelEmailC.Text = "Email Obrigatório!!!";
                labelEmailC.ForeColor = Color.Red;

                
            }
            if (string.IsNullOrEmpty(Novasenha))
            {
                labelSenhaC.Text = "Senha Obrigatória!!!!";
                labelSenhaC.ForeColor = Color.Red;


            }
            
            bool PosicaonovosUsuarios = false;

            for (int i = 0; i < listausuario.Count; i++)
            {

                if (Novousuario == listausuario[i])
                {
                   
                    PosicaonovosUsuarios = true;
                    
                }

            }
            if(!PosicaonovosUsuarios)
            {
                listausuario.Add(Novousuario);
                listaSenhas.Add(Novasenha);
                labelResultadocadastro.Text = "Cadastrado com sucesso";
            }
            else
            {
                labelResultadocadastro.Text = "Usuario ja existe";
            }
            if (Novasenha.Length < 8)
            {

                labelSenhaC.Text = "Minimo 8 caracteres";
                 

                
            }
            bool CaracteresEspecial = false;

            for (int i = 0; i < listaSenhas.Count; i++)
            {
                
                
                if (Novasenha == listaSenhas[i])
                {

                    caracteresEspeciais.Contains(listaSenhas[i]);
                    listaSenhas.Add(Novasenha);
                }
                if (Novasenha.Any(todosOsCaracteres => caracteresEspeciais.Contains(todosOsCaracteres)))
                {
                    labelSenhaC.Text = "Senha Boa";



                }
                else
                {
                    labelSenhaC.Text = "Senha Fraca";
                }



                if (!PosicaonovosUsuarios)
                {
                    listausuario.Add(Novousuario);
                    listaSenhas.Add(Novasenha);
                    labelResultadocadastro.Text = "Cadastrado com sucesso";
                }
                else
                {
                    labelResultadocadastro.Text = "Usuario ja existe";
                }




            }



            



            









        }


    }



}
