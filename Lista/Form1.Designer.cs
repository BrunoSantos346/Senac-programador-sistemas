namespace Lista
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
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            button = new Button();
            labelUsuario = new Label();
            labelSenha = new Label();
            labelResultado = new Label();
            textBoxEmail = new TextBox();
            textBoxCriarSenha = new TextBox();
            labelEmail = new Label();
            labeCriarsenha = new Label();
            labelResultadocadastro = new Label();
            button1 = new Button();
            labelEmailC = new Label();
            labelSenhaC = new Label();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(58, 193);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(309, 23);
            textBoxUsuario.TabIndex = 0;
            textBoxUsuario.TextChanged += textBox1_TextChanged;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(58, 242);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(309, 23);
            textBoxSenha.TabIndex = 1;
            textBoxSenha.TextChanged += textBox2_TextChanged;
            // 
            // button
            // 
            button.Location = new Point(107, 308);
            button.Name = "button";
            button.Size = new Size(192, 32);
            button.TabIndex = 2;
            button.Text = "Login";
            button.UseVisualStyleBackColor = true;
            button.Click += button1_Click;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.Location = new Point(422, 196);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(43, 20);
            labelUsuario.TabIndex = 3;
            labelUsuario.Text = "label1";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSenha.Location = new Point(422, 249);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(35, 16);
            labelSenha.TabIndex = 4;
            labelSenha.Text = "label1";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(144, 377);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(38, 15);
            labelResultado.TabIndex = 6;
            labelResultado.Text = "label1";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(771, 197);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(383, 23);
            textBoxEmail.TabIndex = 7;
            textBox1_TextChanged(this, new EventArgs());

            // 
            // textBoxCriarSenha
            // 
            textBoxCriarSenha.Location = new Point(771, 263);
            textBoxCriarSenha.Name = "textBoxCriarSenha";
            textBoxCriarSenha.Size = new Size(383, 23);
            textBoxCriarSenha.TabIndex = 8;
            textBoxCriarSenha.TextChanged += textBox2_TextChanged_1;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(702, 208);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 9;
            labelEmail.Text = "Email";
            // 
            // labeCriarsenha
            // 
            labeCriarsenha.AutoSize = true;
            labeCriarsenha.Location = new Point(683, 271);
            labeCriarsenha.Name = "labeCriarsenha";
            labeCriarsenha.Size = new Size(67, 15);
            labeCriarsenha.TabIndex = 10;
            labeCriarsenha.Text = "Criar Senha";
            labeCriarsenha.Click += label2_Click;
            // 
            // labelResultadocadastro
            // 
            labelResultadocadastro.AutoSize = true;
            labelResultadocadastro.Location = new Point(849, 363);
            labelResultadocadastro.Name = "labelResultadocadastro";
            labelResultadocadastro.Size = new Size(38, 15);
            labelResultadocadastro.TabIndex = 11;
            labelResultadocadastro.Text = "label1";
            labelResultadocadastro.Click += labelResultadocadastro_Click;
            // 
            // button1
            // 
            button1.Location = new Point(880, 317);
            button1.Name = "button1";
            button1.Size = new Size(167, 32);
            button1.TabIndex = 12;
            button1.Text = "Criar Conta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // labelEmailC
            // 
            labelEmailC.AutoSize = true;
            labelEmailC.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmailC.Location = new Point(1160, 204);
            labelEmailC.Name = "labelEmailC";
            labelEmailC.Size = new Size(35, 16);
            labelEmailC.TabIndex = 13;
            labelEmailC.Text = "label1";
            // 
            // labelSenhaC
            // 
            labelSenhaC.AutoSize = true;
            labelSenhaC.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSenhaC.Location = new Point(1160, 271);
            labelSenhaC.Name = "labelSenhaC";
            labelSenhaC.Size = new Size(35, 16);
            labelSenhaC.TabIndex = 14;
            labelSenhaC.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1434, 450);
            Controls.Add(labelSenhaC);
            Controls.Add(labelEmailC);
            Controls.Add(button1);
            Controls.Add(labelResultadocadastro);
            Controls.Add(labeCriarsenha);
            Controls.Add(labelEmail);
            Controls.Add(textBoxCriarSenha);
            Controls.Add(textBoxEmail);
            Controls.Add(labelResultado);
            Controls.Add(labelSenha);
            Controls.Add(labelUsuario);
            Controls.Add(button);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Button button;
        private Label labelUsuario;
        private Label labelSenha;
        private Label labelResultado;
        private TextBox textBoxEmail;
        private TextBox textBoxCriarSenha;
        private Label labelEmail;
        private Label labeCriarsenha;
        private Label labelResultadocadastro;
        private Button button1;
        private Label labelEmailC;
        private Label labelSenhaC;
    }
}
