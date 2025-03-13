namespace Calculadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            comboBox1.Items.Add("Área");
            comboBox1.Items.Add("Perímetro");
            comboBox1.Items.Add("Volume");
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.Add("Quadrado");
            comboBox2.Items.Add("Retângulo");
            comboBox2.SelectedIndex = 1;
        }

        private void textBoxAP_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double lado;
            if (!double.TryParse(textBoxAP.Text, out lado) || lado <= 0)
            {
                MessageBox.Show("Por favor, Insira um Valor válido para lado do quadrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string operacao = comboBox1.SelectedItem.ToString();
            double resultado = 0;

            switch (operacao)
            {
                case "Perímetro":

                    resultado = 4 * lado;
                    break;

                case "Área":
                    resultado = lado * lado;
                    break;
                case "Volume":
                    resultado = lado * lado * lado;
                    break;
                default:
                    MessageBox.Show("Selecione uma opção valída.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;


            }

            labelResultado.Text = $"Resultado:{resultado}";
        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica qual figura foi selecionada
                if (comboBox2.SelectedItem.ToString() == "Retângulo")
                {
                    // Para o retângulo, usamos largura e comprimento
                    double largura = Convert.ToDouble(textBox2.Text);
                    double comprimento = Convert.ToDouble(textBox2.Text);

                    // Para Calcular a área do retângulo
                    double area = largura * comprimento;
                    labelCalcularRQ.Text = "Área: " + area.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Quadrado")
                {
                    // Para o quadrado, usamos o lado (o mesmo valor para largura e comprimento)
                    double lado = Convert.ToDouble(textBox1.Text);

                    // Calcular a área do quadrado
                    double area = lado * lado;
                    labelCalcularRQ.Text = "Área: " + area.ToString();

                    string Resultadofinal = Convert.ToString(labelCalcularRQ.Text);
                }
            }
           
             catch(Exception ex)
            {
                MessageBox.Show("Por Favor Insira Um valor Válidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Alterar os controles dependendo da seleção
            if (comboBox2.SelectedItem.ToString() == "Retângulo")
            {
                textBox1.Visible = true;  // Exibe o campo para o comprimento
            }
            else if (comboBox2.SelectedItem.ToString() == "Quadrado")
            {
                textBox2.Visible = false; // Não Exibe o Segundo Campo

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
