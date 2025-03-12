namespace Calculadora
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Calcular = new Button();
            textBoxAP = new TextBox();
            comboBox1 = new ComboBox();
            labelResultado = new Label();
            SuspendLayout();
            // 
            // Calcular
            // 
            Calcular.Location = new Point(108, 311);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(129, 39);
            Calcular.TabIndex = 0;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // textBoxAP
            // 
            textBoxAP.Location = new Point(81, 249);
            textBoxAP.Name = "textBoxAP";
            textBoxAP.Size = new Size(183, 23);
            textBoxAP.TabIndex = 1;
            textBoxAP.TextChanged += textBoxAP_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(350, 269);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(133, 391);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(38, 15);
            labelResultado.TabIndex = 3;
            labelResultado.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResultado);
            Controls.Add(comboBox1);
            Controls.Add(textBoxAP);
            Controls.Add(Calcular);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Calcular;
        private TextBox textBoxAP;
        private ComboBox comboBox1;
        private Label labelResultado;
    }
}