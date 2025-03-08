namespace Usuario
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
            textBoxCriarSenha = new TextBox();
            textBoxCadastro = new TextBox();
            labelCadastro = new Label();
            labelUsuario = new Label();
            labelUser = new Label();
            labelSen = new Label();
            buttonUser = new Button();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(95, 212);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(347, 23);
            textBoxUsuario.TabIndex = 0;
            textBoxUsuario.TextChanged += textBoxUsuario_TextChanged;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(95, 261);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(347, 23);
            textBoxSenha.TabIndex = 1;
            // 
            // textBoxCriarSenha
            // 
            textBoxCriarSenha.Location = new Point(681, 261);
            textBoxCriarSenha.Name = "textBoxCriarSenha";
            textBoxCriarSenha.Size = new Size(306, 23);
            textBoxCriarSenha.TabIndex = 2;
            // 
            // textBoxCadastro
            // 
            textBoxCadastro.Location = new Point(681, 212);
            textBoxCadastro.Name = "textBoxCadastro";
            textBoxCadastro.Size = new Size(306, 23);
            textBoxCadastro.TabIndex = 3;
            // 
            // labelCadastro
            // 
            labelCadastro.AutoSize = true;
            labelCadastro.Location = new Point(789, 339);
            labelCadastro.Name = "labelCadastro";
            labelCadastro.Size = new Size(38, 15);
            labelCadastro.TabIndex = 4;
            labelCadastro.Text = "label1";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(198, 358);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(38, 15);
            labelUsuario.TabIndex = 5;
            labelUsuario.Text = "label1";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(462, 220);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(38, 15);
            labelUser.TabIndex = 6;
            labelUser.Text = "label1";
            // 
            // labelSen
            // 
            labelSen.AutoSize = true;
            labelSen.Location = new Point(462, 269);
            labelSen.Name = "labelSen";
            labelSen.Size = new Size(38, 15);
            labelSen.TabIndex = 7;
            labelSen.Text = "label1";
            labelSen.Click += label1_Click;
            // 
            // buttonUser
            // 
            buttonUser.Location = new Point(221, 311);
            buttonUser.Name = "buttonUser";
            buttonUser.Size = new Size(109, 23);
            buttonUser.TabIndex = 8;
            buttonUser.Text = "button1";
            buttonUser.UseVisualStyleBackColor = true;
            buttonUser.Click += buttonUser_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1498, 450);
            Controls.Add(buttonUser);
            Controls.Add(labelSen);
            Controls.Add(labelUser);
            Controls.Add(labelUsuario);
            Controls.Add(labelCadastro);
            Controls.Add(textBoxCadastro);
            Controls.Add(textBoxCriarSenha);
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
        private TextBox textBoxCriarSenha;
        private TextBox textBoxCadastro;
        private Label labelCadastro;
        private Label labelUsuario;
        private Label labelUser;
        private Label labelSen;
        private Button buttonUser;
    }
}
