namespace Esfera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool validarform()
        {
            Erro.Text = "";
            return false;
        }



        private void Perimetro_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCalculo.Enabled = true;
        }

        private void Area_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCalculo.Enabled = true;
        }

        private void Raio_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCalculo.Enabled = true;
        }

        private void Volume_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCalculo.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Erro.Text = "";
            
            double raionum = double.Parse(textBoxCalculo.Text);
            double resultado;

            if (Perimetro.Checked)
            {
                resultado  = 2 * 3.14 * raionum;
                Resultado.Text = $"Resultado: {resultado:F2}";
            }
            else if (Area.Checked)
            {
                resultado = 3.14 * Math.Pow(raionum, 2);
                Resultado.Text = $"Resultado: {resultado:F2}";
            }

            else if (Volume.Checked)
            {
                resultado = 4 / 3 * 3.14 * Math.Pow(raionum, 3);
                Resultado.Text = $"Resultado: {resultado:F2}";

            }
            else if(Diametro.Checked)
            {
                resultado = 2 * raionum;
                Resultado.Text = $"Resultado: {resultado:F2}";
            }
            else
            {
                Erro.Text = "Selecione uma Opção";
            }

        }

        private void Diametro_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
