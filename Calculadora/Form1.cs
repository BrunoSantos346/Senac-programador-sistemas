namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Adi��o");
            comboBox1.Items.Add("Subtra��o");
            comboBox1.Items.Add("Divis�o");
            comboBox1.Items.Add("Multiplica��o");
            comboBox1.SelectedIndex = 0;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxV1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {

            try
            {




                double numero1 = Convert.ToDouble(textBoxV2.Text);
                double numero2 = Convert.ToDouble(textBoxV2.Text);
                string opera�ao2 = comboBox1.SelectedItem.ToString();
                double resultado = 0;





                labelReseultado.Text = resultado.ToString();


                switch (opera�ao2)
                {


                    case "Adi��o":
                        resultado = numero1 + numero2;
                        break;

                    case "Subtra��o":
                        resultado = numero1 - numero2;
                        break;

                    case "Multiplica��o":
                        resultado = numero1 * numero2;
                        break;

                    case "Divis�o":

                        resultado = numero1 / numero2;




                        if (numero2 != 0)
                        {
                            resultado = numero1 / numero1;
                        }
                        else
                        {
                            labelReseultado.Text = "Erro: Divis�o por zero!";
                            return;
                        }
                        break;
                    default:
                        labelReseultado.Text = "Erro: Opera��o inv�lida!";
                        return;
                }

                labelReseultado.Text = " Resultado " + resultado.ToString();


                string resultado2 = labelReseultado.Text;
            }
            catch (Exception ex)
            {
                labelReseultado.Text += ex.Message;

            }



        }



        private void buttonAbrir_Click(object sender, EventArgs e)
        {
        }

        private void labelReseultado_Click(object sender, EventArgs e)
        {

        }

        private void labelReseultado_Click_1(object sender, EventArgs e)
        {

        }





        private void buttonForm2_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        private void labelReseultado_Click_2(object sender, EventArgs e)
        {

        }
    }


}

