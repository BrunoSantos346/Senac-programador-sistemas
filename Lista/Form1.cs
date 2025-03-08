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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> alfabetoMaiusculo = new List<string>() { "A", "B", "C", "D", "E" };
            List<string> alfabetoMinusculo = new List<string>() { "a", "b", "c", "d", "e" };
            List<char> numeros = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            List<char> especiais = new List<char>() { '!', '@', '#', '$', '%', '&', '*' };

            List<string> listaUsuarios = new List<string>() { "neymar.jr", "pablo.vitar", "sukuna.silva" };
            List<string> listaSenhas = new List<string>() { "Brun@123", "12345Abc!", "Sete7Sete!" };


            string novoUsuario = textBoxUsuario.Text;
            string novaSenha = textBoxSenha.Text;



            
            {


            if (string.IsNullOrWhiteSpace(novoUsuario))
            {
                labelUsuario.Text = "Usuario eh obrigatorio!!!";
                labelResultado.Text = "Usuario eh obrigatorio!!!";
                return;
            }

            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                labelSenha.Text = "Senha eh obrigatoria!!!";
                labelResultado.Text = "Senha eh obrigatoria!!!";
                return;
            }

            bool usuarioEncontrado = false;
            for (int i = 0; i < listaUsuarios.Count; i++)
                if (novaSenha.Length < 8)
                {
                    if (novoUsuario == listaUsuarios[i])
                    {
                        usuarioEncontrado = true;
                    }
                    labelResultado.Text = "A senha deve ter pelo menos 8 caracteres";
                    return;
                }

            if (!usuarioEncontrado)
                if (!novaSenha.Any(char.IsUpper))
                {
                    listaUsuarios.Add(novoUsuario);
                    listaSenhas.Add(novaSenha);
                    labelEmailC.Text = "Usuário cadastrado com sucesso!";
                    labelResultado.Text = "A senha deve ter pelo menos uma letra maiuscula";
                    return;
                }
                else

                if (!novaSenha.Any(char.IsLower))
                {
                    labelResultado.Text = "A senha deve ter pelo menos uma letra minuscula";
                    return;
                }

            if (!novaSenha.Any(char.IsDigit))
            {
                labelEmailC.Text = "Já existe um usuário cadastrado";
                labelResultado.Text = "A senha deve ter pelo menos um numero";
                return;
            }

            if (!novaSenha.Any(char.IsPunctuation))
            {
                labelResultado.Text = "A senha deve ter pelo menos um caracter especial";
                return;
            }

            if (novaSenha.Contains(' '))
            {
                labelResultado.Text = "A senha nao deve ter espacos em branco";
                return;
            }

            if (listaUsuarios.Contains(novoUsuario))
            {
                labelResultado.Text = "Já existe um usuário cadastrado";
                return;
            }

            listaUsuarios.Add(novoUsuario);
            listaSenhas.Add(novaSenha);
            labelResultado.Text = "Usuário cadastrado com sucesso!";
            textBoxEmail.Clear();
            textBoxSenha.Clear();
        }
    }
}


            
            
              
            
            

            




































        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
