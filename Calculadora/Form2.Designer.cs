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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            label2 = new Label();
            labelCalcularRQ = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // Calcular
            // 
            Calcular.Location = new Point(42, 302);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(129, 39);
            Calcular.TabIndex = 0;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // textBoxAP
            // 
            textBoxAP.Location = new Point(32, 240);
            textBoxAP.Name = "textBoxAP";
            textBoxAP.Size = new Size(183, 23);
            textBoxAP.TabIndex = 1;
            textBoxAP.TextChanged += textBoxAP_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(240, 282);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(89, 377);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(38, 15);
            labelResultado.TabIndex = 3;
            labelResultado.Text = "label1";
            labelResultado.Click += labelResultado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 192);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 4;
            label1.Text = "Calculo da Área";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(420, 240);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(446, 324);
            button1.Name = "button1";
            button1.Size = new Size(129, 28);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(631, 282);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(115, 23);
            comboBox2.TabIndex = 7;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(446, 192);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 8;
            label2.Text = "Calculo Retângulo";
            // 
            // labelCalcularRQ
            // 
            labelCalcularRQ.AutoSize = true;
            labelCalcularRQ.Location = new Point(494, 377);
            labelCalcularRQ.Name = "labelCalcularRQ";
            labelCalcularRQ.Size = new Size(38, 15);
            labelCalcularRQ.TabIndex = 10;
            labelCalcularRQ.Text = "label3";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(420, 282);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 23);
            textBox2.TabIndex = 11;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(labelCalcularRQ);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
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
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private ComboBox comboBox2;
        private Label label2;
        private Label labelCalcularRQ;
        private TextBox textBox2;
    }
}