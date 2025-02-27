namespace login
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            textboxEmail = new TextBox();
            textBoxSenha = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            labelResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textboxEmail
            // 
            textboxEmail.Location = new Point(203, 200);
            textboxEmail.Name = "textboxEmail";
            textboxEmail.Size = new Size(326, 23);
            textboxEmail.TabIndex = 0;
            textboxEmail.TextChanged += textBox1_TextChanged;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(203, 229);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(326, 23);
            textBoxSenha.TabIndex = 1;
            textBoxSenha.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(299, 305);
            button1.Name = "button1";
            button1.Size = new Size(131, 23);
            button1.TabIndex = 2;
            button1.Text = "ENTRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 200);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 237);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(299, 166);
            label3.Name = "label3";
            label3.Size = new Size(82, 31);
            label3.TabIndex = 5;
            label3.Text = "LOGIN";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-4, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(702, 417);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(299, 267);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(38, 15);
            labelResultado.TabIndex = 9;
            labelResultado.Text = "label5";
            labelResultado.Click += labelResultado_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(696, 415);
            Controls.Add(labelResultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxSenha);
            Controls.Add(textboxEmail);
            Controls.Add(pictureBox2);
            ForeColor = SystemColors.WindowText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormLogin";
            Text = "Login :)";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textboxEmail;
        private TextBox textBoxSenha;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private Label labelResultado;
    }
}
