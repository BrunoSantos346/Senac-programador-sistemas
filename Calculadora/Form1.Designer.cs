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
            // labelReseultado
            // 
            labelReseultado.AutoSize = true;
            labelReseultado.Location = new Point(155, 358);
            labelReseultado.Name = "labelReseultado";
            labelReseultado.Size = new Size(38, 15);
            labelReseultado.TabIndex = 9;
            labelReseultado.Text = "label1";
            labelReseultado.Click += labelReseultado_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelReseultado);
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
        private Label labelReseultado;
    }
}
