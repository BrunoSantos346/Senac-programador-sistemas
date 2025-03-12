namespace Calculadora
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
            textBoxV1 = new TextBox();
            textBoxV2 = new TextBox();
            buttonCalcular = new Button();
            buttonForm2 = new Button();
            comboBox1 = new ComboBox();
            labelReseultado = new Label();
            SuspendLayout();
            // 
            // textBoxV1
            // 
            textBoxV1.Location = new Point(101, 184);
            textBoxV1.Name = "textBoxV1";
            textBoxV1.Size = new Size(185, 23);
            textBoxV1.TabIndex = 0;
            textBoxV1.TextChanged += textBoxV1_TextChanged;
            // 
            // textBoxV2
            // 
            textBoxV2.Location = new Point(101, 237);
            textBoxV2.Name = "textBoxV2";
            textBoxV2.Size = new Size(185, 23);
            textBoxV2.TabIndex = 1;
            textBoxV2.TextChanged += textBox2_TextChanged;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(155, 288);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 2;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // buttonForm2
            // 
            buttonForm2.Location = new Point(582, 313);
            buttonForm2.Name = "buttonForm2";
            buttonForm2.Size = new Size(142, 46);
            buttonForm2.TabIndex = 10;
            buttonForm2.Text = "Form2";
            buttonForm2.UseVisualStyleBackColor = true;
            buttonForm2.Click += buttonForm2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(615, 184);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelReseultado
            // 
            labelReseultado.AutoSize = true;
            labelReseultado.Location = new Point(155, 344);
            labelReseultado.Name = "labelReseultado";
            labelReseultado.Size = new Size(38, 15);
            labelReseultado.TabIndex = 12;
            labelReseultado.Text = "label1";
            labelReseultado.Click += labelReseultado_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelReseultado);
            Controls.Add(comboBox1);
            Controls.Add(buttonForm2);
            Controls.Add(buttonCalcular);
            Controls.Add(textBoxV2);
            Controls.Add(textBoxV1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxV1;
        private TextBox textBoxV2;
        private Button buttonCalcular;
        private Button buttonForm2;
        private ComboBox comboBox1;
        private Label labelReseultado;
    }
}
