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
        }

        private void textBoxAP_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double lado;
            if (!double.TryParse(textBoxAP.Text, out lado ) || lado <= 0)
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
                    return ;
                    

            }

            labelResultado.Text = $"Resultado:{resultado}";
        }
    }
}
