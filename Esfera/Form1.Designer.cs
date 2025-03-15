namespace Esfera
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
            textBoxCalculo = new TextBox();
            button1 = new Button();
            Perimetro = new RadioButton();
            Area = new RadioButton();
            Volume = new RadioButton();
            Erro = new Label();
            Resultado = new Label();
            Diametro = new RadioButton();
            SuspendLayout();
            // 
            // textBoxCalculo
            // 
            textBoxCalculo.Location = new Point(84, 190);
            textBoxCalculo.Name = "textBoxCalculo";
            textBoxCalculo.Size = new Size(156, 23);
            textBoxCalculo.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(113, 236);
            button1.Name = "button1";
            button1.Size = new Size(100, 42);
            button1.TabIndex = 1;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Perimetro
            // 
            Perimetro.AutoSize = true;
            Perimetro.Location = new Point(273, 153);
            Perimetro.Name = "Perimetro";
            Perimetro.Size = new Size(77, 19);
            Perimetro.TabIndex = 2;
            Perimetro.TabStop = true;
            Perimetro.Text = "Perimetro";
            Perimetro.UseVisualStyleBackColor = true;
            Perimetro.CheckedChanged += Perimetro_CheckedChanged;
            // 
            // Area
            // 
            Area.AutoSize = true;
            Area.Location = new Point(273, 190);
            Area.Name = "Area";
            Area.Size = new Size(49, 19);
            Area.TabIndex = 3;
            Area.TabStop = true;
            Area.Text = "Area";
            Area.UseVisualStyleBackColor = true;
            Area.CheckedChanged += Area_CheckedChanged;
            // 
            // Volume
            // 
            Volume.AutoSize = true;
            Volume.Location = new Point(273, 226);
            Volume.Name = "Volume";
            Volume.Size = new Size(65, 19);
            Volume.TabIndex = 5;
            Volume.TabStop = true;
            Volume.Text = "Volume";
            Volume.UseVisualStyleBackColor = true;
            Volume.CheckedChanged += Volume_CheckedChanged;
            // 
            // Erro
            // 
            Erro.AutoSize = true;
            Erro.Location = new Point(113, 369);
            Erro.Name = "Erro";
            Erro.Size = new Size(38, 15);
            Erro.TabIndex = 6;
            Erro.Text = "label1";
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Location = new Point(113, 369);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(38, 15);
            Resultado.TabIndex = 7;
            Resultado.Text = "label1";
            // 
            // Diametro
            // 
            Diametro.AutoSize = true;
            Diametro.Location = new Point(273, 259);
            Diametro.Name = "Diametro";
            Diametro.Size = new Size(74, 19);
            Diametro.TabIndex = 8;
            Diametro.TabStop = true;
            Diametro.Text = "Diametro";
            Diametro.UseVisualStyleBackColor = true;
            Diametro.CheckedChanged += Diametro_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Diametro);
            Controls.Add(Resultado);
            Controls.Add(Erro);
            Controls.Add(Volume);
            Controls.Add(Area);
            Controls.Add(Perimetro);
            Controls.Add(button1);
            Controls.Add(textBoxCalculo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCalculo;
        private Button button1;
        private RadioButton Perimetro;
        private RadioButton Area;
        private RadioButton Volume;
        private Label Erro;
        private Label Resultado;
        private RadioButton Diametro;
    }
}
