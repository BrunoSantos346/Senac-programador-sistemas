
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            radioButtonPerimetro = new RadioButton();
            textBoxPerimetro = new TextBox();
            textBoxRaio = new TextBox();
            textBoxDiametro = new TextBox();
            textBoxArea = new TextBox();
            radioButtonRaio = new RadioButton();
            radioButtonDiametro = new RadioButton();
            radioButtonArea = new RadioButton();
            buttonCalcularCircuferencia = new Button();
            Circunferência = new GroupBox();
            labelErro = new Label();
            labelResultadoCircun = new Label();
            label1 = new Label();
            comboBoxOpçoes = new ComboBox();
            Esfera = new GroupBox();
            buttoncalcularEsfera = new Button();
            label2 = new Label();
            labelResultadoEsfera = new Label();
            textBox5 = new TextBox();
            radioButtonCircuferencia = new RadioButton();
            Circunferência.SuspendLayout();
            Esfera.SuspendLayout();
            SuspendLayout();
            // 
            // radioButtonPerimetro
            // 
            radioButtonPerimetro.AutoSize = true;
            radioButtonPerimetro.Location = new Point(177, 92);
            radioButtonPerimetro.Name = "radioButtonPerimetro";
            radioButtonPerimetro.Size = new Size(77, 19);
            radioButtonPerimetro.TabIndex = 0;
            radioButtonPerimetro.TabStop = true;
            radioButtonPerimetro.Text = "Perimetro";
            radioButtonPerimetro.UseVisualStyleBackColor = false;
            radioButtonPerimetro.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // textBoxPerimetro
            // 
            textBoxPerimetro.Location = new Point(40, 88);
            textBoxPerimetro.Name = "textBoxPerimetro";
            textBoxPerimetro.Size = new Size(100, 23);
            textBoxPerimetro.TabIndex = 1;
            // 
            // textBoxRaio
            // 
            textBoxRaio.Location = new Point(40, 127);
            textBoxRaio.Name = "textBoxRaio";
            textBoxRaio.Size = new Size(100, 23);
            textBoxRaio.TabIndex = 2;
            // 
            // textBoxDiametro
            // 
            textBoxDiametro.Location = new Point(40, 168);
            textBoxDiametro.Name = "textBoxDiametro";
            textBoxDiametro.Size = new Size(100, 23);
            textBoxDiametro.TabIndex = 3;
            // 
            // textBoxArea
            // 
            textBoxArea.Location = new Point(40, 207);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.Size = new Size(100, 23);
            textBoxArea.TabIndex = 4;
            // 
            // radioButtonRaio
            // 
            radioButtonRaio.AutoSize = true;
            radioButtonRaio.Location = new Point(177, 131);
            radioButtonRaio.Name = "radioButtonRaio";
            radioButtonRaio.Size = new Size(48, 19);
            radioButtonRaio.TabIndex = 5;
            radioButtonRaio.TabStop = true;
            radioButtonRaio.Text = "Raio";
            radioButtonRaio.UseVisualStyleBackColor = true;
            radioButtonRaio.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButtonDiametro
            // 
            radioButtonDiametro.AutoSize = true;
            radioButtonDiametro.Location = new Point(177, 172);
            radioButtonDiametro.Name = "radioButtonDiametro";
            radioButtonDiametro.Size = new Size(74, 19);
            radioButtonDiametro.TabIndex = 6;
            radioButtonDiametro.TabStop = true;
            radioButtonDiametro.Text = "Diametro";
            radioButtonDiametro.UseVisualStyleBackColor = true;
            radioButtonDiametro.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButtonArea
            // 
            radioButtonArea.AutoSize = true;
            radioButtonArea.Location = new Point(177, 211);
            radioButtonArea.Name = "radioButtonArea";
            radioButtonArea.Size = new Size(49, 19);
            radioButtonArea.TabIndex = 7;
            radioButtonArea.TabStop = true;
            radioButtonArea.Text = "Area";
            radioButtonArea.UseVisualStyleBackColor = true;
            radioButtonArea.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // buttonCalcularCircuferencia
            // 
            buttonCalcularCircuferencia.Location = new Point(52, 255);
            buttonCalcularCircuferencia.Name = "buttonCalcularCircuferencia";
            buttonCalcularCircuferencia.Size = new Size(75, 23);
            buttonCalcularCircuferencia.TabIndex = 8;
            buttonCalcularCircuferencia.Text = "Calcular";
            buttonCalcularCircuferencia.UseVisualStyleBackColor = true;
            buttonCalcularCircuferencia.Click += button1_Click;
            // 
            // Circunferência
            // 
            Circunferência.Controls.Add(labelErro);
            Circunferência.Controls.Add(labelResultadoCircun);
            Circunferência.Controls.Add(label1);
            Circunferência.Controls.Add(buttonCalcularCircuferencia);
            Circunferência.Controls.Add(radioButtonArea);
            Circunferência.Controls.Add(radioButtonDiametro);
            Circunferência.Controls.Add(radioButtonRaio);
            Circunferência.Controls.Add(textBoxArea);
            Circunferência.Controls.Add(textBoxDiametro);
            Circunferência.Controls.Add(textBoxRaio);
            Circunferência.Controls.Add(textBoxPerimetro);
            Circunferência.Controls.Add(radioButtonPerimetro);
            Circunferência.Location = new Point(24, 80);
            Circunferência.Name = "Circunferência";
            Circunferência.Size = new Size(306, 343);
            Circunferência.TabIndex = 9;
            Circunferência.TabStop = false;
            Circunferência.Text = "groupBox1";
            Circunferência.UseCompatibleTextRendering = true;
            Circunferência.Visible = false;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(74, 311);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(38, 15);
            labelErro.TabIndex = 12;
            labelErro.Text = "label3";
            // 
            // labelResultadoCircun
            // 
            labelResultadoCircun.AutoSize = true;
            labelResultadoCircun.Location = new Point(74, 311);
            labelResultadoCircun.Name = "labelResultadoCircun";
            labelResultadoCircun.Size = new Size(38, 15);
            labelResultadoCircun.TabIndex = 12;
            labelResultadoCircun.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 43);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 11;
            label1.Text = "Circunferência";
            // 
            // comboBoxOpçoes
            // 
            comboBoxOpçoes.FormattingEnabled = true;
            comboBoxOpçoes.Location = new Point(30, 29);
            comboBoxOpçoes.Name = "comboBoxOpçoes";
            comboBoxOpçoes.Size = new Size(121, 23);
            comboBoxOpçoes.TabIndex = 10;
            comboBoxOpçoes.SelectedIndexChanged += comboBoxOpçoes_SelectedIndexChanged;
            // 
            // Esfera
            // 
            Esfera.Controls.Add(buttoncalcularEsfera);
            Esfera.Controls.Add(label2);
            Esfera.Controls.Add(labelResultadoEsfera);
            Esfera.Controls.Add(textBox5);
            Esfera.Controls.Add(radioButtonCircuferencia);
            Esfera.Location = new Point(370, 91);
            Esfera.Name = "Esfera";
            Esfera.Size = new Size(254, 188);
            Esfera.TabIndex = 11;
            Esfera.TabStop = false;
            Esfera.Text = "groupBox1";
            Esfera.Visible = false;
            // 
            // buttoncalcularEsfera
            // 
            buttoncalcularEsfera.Location = new Point(79, 103);
            buttoncalcularEsfera.Name = "buttoncalcularEsfera";
            buttoncalcularEsfera.Size = new Size(75, 33);
            buttoncalcularEsfera.TabIndex = 13;
            buttoncalcularEsfera.Text = "Calcular";
            buttoncalcularEsfera.UseVisualStyleBackColor = true;
            buttoncalcularEsfera.Click += buttoncalcularEsfera_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(95, 19);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 14;
            label2.Text = "Esfera";
            // 
            // labelResultadoEsfera
            // 
            labelResultadoEsfera.AutoSize = true;
            labelResultadoEsfera.Location = new Point(95, 157);
            labelResultadoEsfera.Name = "labelResultadoEsfera";
            labelResultadoEsfera.Size = new Size(38, 15);
            labelResultadoEsfera.TabIndex = 13;
            labelResultadoEsfera.Text = "label2";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(19, 65);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(111, 23);
            textBox5.TabIndex = 12;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // radioButtonCircuferencia
            // 
            radioButtonCircuferencia.AutoSize = true;
            radioButtonCircuferencia.Location = new Point(152, 65);
            radioButtonCircuferencia.Name = "radioButtonCircuferencia";
            radioButtonCircuferencia.Size = new Size(65, 19);
            radioButtonCircuferencia.TabIndex = 12;
            radioButtonCircuferencia.TabStop = true;
            radioButtonCircuferencia.Text = "Volume";
            radioButtonCircuferencia.UseVisualStyleBackColor = true;
            radioButtonCircuferencia.CheckedChanged += radioButtonCircuferencia_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Esfera);
            Controls.Add(comboBoxOpçoes);
            Controls.Add(Circunferência);
            Name = "Form1";
            Text = "Form1";
            Circunferência.ResumeLayout(false);
            Circunferência.PerformLayout();
            Esfera.ResumeLayout(false);
            Esfera.PerformLayout();
            ResumeLayout(false);
        }

        private void radioButtonCircuferencia_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttoncalcularEsfera_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void comboBoxOpçoes_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private RadioButton radioButtonPerimetro;
        private TextBox textBoxPerimetro;
        private TextBox textBoxRaio;
        private TextBox textBoxDiametro;
        private TextBox textBoxArea;
        private RadioButton radioButtonRaio;
        private RadioButton radioButtonDiametro;
        private RadioButton radioButtonArea;
        private Button buttonCalcularCircuferencia;
        private GroupBox Circunferência;
        private ComboBox comboBoxOpçoes;
        private Label label1;
        private GroupBox Esfera;
        private RadioButton radioButtonCircuferencia;
        private Label labelResultadoCircun;
        private Label label2;
        private Label labelResultadoEsfera;
        private TextBox textBox5;
        private Button buttoncalcularEsfera;
        private Label labelErro;
    }
}
