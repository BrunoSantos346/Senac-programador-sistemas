namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxOp�oes.Items.Add("Circunfer�ncia");
            comboBoxOp�oes.Items.Add("Esfera");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Valida��o dos TextBox 

            labelErro.Text = "";

            if (radioButton1_CheckedChanged != null)
            {
                string Resultado = labelResultadoCircun.Text;
                string Perimetro = textBoxPerimetro.Text;


                if (string.IsNullOrEmpty(Perimetro) || !Perimetro.All(char.IsNumber))
                {
                    labelErro.Text = "Insira um valor V�lido";
                    labelErro.ForeColor = Color.Red;
                    return;
                }
                if (radioButton2_CheckedChanged != null)
                {
                    string Raio = textBoxRaio.Text;

                    if (string.IsNullOrEmpty(Raio) || !Raio.All(char.IsNumber))
                    {
                        labelErro.Text = "Insira um valor V�lido";
                        labelErro.ForeColor = Color.Red;
                        return;
                    }
                }
                if (radioButton3_CheckedChanged != null)
                {
                    string Diametro = textBoxDiametro.Text;
                    if (string.IsNullOrEmpty(Diametro) || !Diametro.All(char.IsNumber))
                    {
                        labelErro.Text = "Insira um valor V�lido";
                        labelErro.ForeColor = Color.Red;
                        return;
                    }

                }
                if (radioButton4_CheckedChanged != null)
                {
                    string Area = textBoxArea.Text;

                    if (!string.IsNullOrEmpty(Area) || Area.All(char.IsNumber))
                    {
                        labelErro.Text = "Insira um valor V�lido";
                        labelErro.ForeColor = Color.Red;
                        return;
                    }
                    labelErro.Text = "Insira um valor V�lido";
                    labelErro.ForeColor = Color.Red;
                    return;
                }







            }
        }

        private void radioButton2_CheckedChanged1(object sender, EventArgs e)
        {
            textBoxRaio.Enabled = true;
        }

        private void radioButton1_CheckedChanged1(object sender, EventArgs e)
        {
            textBoxPerimetro.Enabled = true;
        }

        private void radioButton3_CheckedChanged1(object sender, EventArgs e)
        {
            textBoxDiametro.Enabled = true;
        }

        private static void buttoncalcularEsfera_Click1(object sender, EventArgs e)
        {

        }

        private void comboBoxOp�oes_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (comboBoxOp�oes.SelectedItem == null)
            {
                labelErro.Text = "Escolha uma das Op�oes";
                return;
            }

            if (comboBoxOp�oes.SelectedItem.ToString() == "Circunfer�ncia")
            {
                Circunfer�ncia.Visible = true;
                Esfera.Visible = false;
                Circunfer�ncia.BringToFront();
                Esfera.SendToBack();
                return;
            }

            if (comboBoxOp�oes.SelectedItem.ToString() == "Esfera")
            {
                Esfera.Visible = true;
                Circunfer�ncia.Visible = false;
                Esfera.BringToFront();
                Circunfer�ncia.SendToBack();
                return;
            }
        }

        private static void textBox5_TextChanged1(object sender, EventArgs e)
        {

        }

        private static void radioButtonCircuferencia_CheckedChanged1(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged1(object sender, EventArgs e)
        {
            textBoxArea.Enabled = true;
        }
    } 
}
