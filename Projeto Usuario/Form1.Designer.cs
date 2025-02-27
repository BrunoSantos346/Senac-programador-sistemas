namespace Projeto_Usuario
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
            textBoxEmail = new TextBox();
            textBoxSenha = new TextBox();
            textBoxCPF = new TextBox();
            Cadastro = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxName = new TextBox();
            label4 = new Label();
            Resultado = new Button();
            labelSenha = new Label();
            labelEmail = new Label();
            labelNome = new Label();
            labelCPF = new Label();
            labeResuktado = new Label();
            SuspendLayout();
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(229, 135);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(282, 23);
            textBoxEmail.TabIndex = 0;
            textBoxEmail.TextChanged += textBox1_TextChanged;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(229, 188);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(282, 23);
            textBoxSenha.TabIndex = 1;
            textBoxSenha.TextChanged += textBox2_TextChanged;
            // 
            // textBoxCPF
            // 
            textBoxCPF.Location = new Point(229, 241);
            textBoxCPF.Name = "textBoxCPF";
            textBoxCPF.Size = new Size(282, 23);
            textBoxCPF.TabIndex = 2;
            // 
            // Cadastro
            // 
            Cadastro.AutoSize = true;
            Cadastro.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cadastro.Location = new Point(323, 30);
            Cadastro.Name = "Cadastro";
            Cadastro.Size = new Size(102, 31);
            Cadastro.TabIndex = 3;
            Cadastro.Text = "Cadastro";
            Cadastro.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 143);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 4;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 196);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Senha";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 249);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 6;
            label3.Text = "CPF";
            label3.Click += label3_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(229, 90);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(282, 23);
            textBoxName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(159, 98);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 8;
            label4.Text = "Nome";
            // 
            // Resultado
            // 
            Resultado.BackColor = SystemColors.ButtonHighlight;
            Resultado.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Resultado.Location = new Point(295, 287);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(141, 35);
            Resultado.TabIndex = 9;
            Resultado.Text = "Criar Conta";
            Resultado.UseVisualStyleBackColor = false;
            Resultado.Click += Resultado_Click;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(544, 196);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(38, 15);
            labelSenha.TabIndex = 10;
            labelSenha.Text = "label5";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(544, 143);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(38, 15);
            labelEmail.TabIndex = 11;
            labelEmail.Text = "label5";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(544, 98);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(38, 15);
            labelNome.TabIndex = 12;
            labelNome.Text = "label5";
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Location = new Point(544, 249);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(38, 15);
            labelCPF.TabIndex = 13;
            labelCPF.Text = "label5";
            // 
            // labeResuktado
            // 
            labeResuktado.AutoSize = true;
            labeResuktado.Location = new Point(295, 372);
            labeResuktado.Name = "labeResuktado";
            labeResuktado.Size = new Size(38, 15);
            labeResuktado.TabIndex = 14;
            labeResuktado.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(labeResuktado);
            Controls.Add(labelCPF);
            Controls.Add(labelNome);
            Controls.Add(labelEmail);
            Controls.Add(labelSenha);
            Controls.Add(Resultado);
            Controls.Add(label4);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Cadastro);
            Controls.Add(textBoxCPF);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxEmail);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEmail;
        private TextBox textBoxSenha;
        private TextBox textBoxCPF;
        private Label Cadastro;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxName;
        private Label label4;
        private Button Resultado;
        private Label labelSenha;
        private Label labelEmail;
        private Label labelNome;
        private Label labelCPF;
        private Label labeResuktado;
    }
}
