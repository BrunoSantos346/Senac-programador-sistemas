namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxV1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            string primeiroNumero = textBoxV1.Text;
            string segundoNumero = textBoxV2.Text;
            char operacao = textBoxV2.Text[0];

            double V1 = Convert.ToDouble(primeiroNumero);
            double V2 = Convert.ToDouble(segundoNumero);

            double resultado = V1 + V2;
            labelReseultado.Text = resultado.ToString();


            switch (operacao)
            {

                case '+':
                    resultado = V1 + V2;
                    break;
                case '-':
                    resultado = V1 - V2;
                    break;
                case '*':
                    resultado = V1 * V2;
                    break;
                case '/':
                    if (V2 != 0)
                    {
                        resultado = V1 / V2;
                    }
                    else
                    {
                        labelReseultado.Text = "Erro: Divisão por zero!";
                        return;
                    }
                    break;
                default:
                    labelReseultado.Text = "Erro: Operação inválida!";
                    return;
            }

            // Exibe o resultado no labelResultado
            labelReseultado.Text = resultado.ToString();

            string resultado2 = labelReseultado.Text;

            Form2 novoForm = Form2();
            novoForm.ShowDialog(labelReseultado);
            this.Hide();



        }

        private Form2 Form2()
        {
            throw new NotImplementedException();
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
    }


}

