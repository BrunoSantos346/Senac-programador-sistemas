namespace CadastroCliente
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
            textBoxNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            DataNascimento = new MaskedTextBox();
            Telefone = new MaskedTextBox();
            label3 = new Label();
            textBoxEmail = new TextBox();
            label4 = new Label();
            Genero = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            textBoxNomeSocial = new TextBox();
            Etnia = new ComboBox();
            label7 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            checkBox1 = new CheckBox();
            label8 = new Label();
            label9 = new Label();
            Logradouro = new TextBox();
            Numero = new TextBox();
            Complemento = new TextBox();
            Municipio = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            Bairro = new TextBox();
            Estado = new ComboBox();
            label15 = new Label();
            Cep = new MaskedTextBox();
            label16 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(59, 76);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(171, 23);
            textBoxNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(13, 79);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(285, 79);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 4;
            label2.Text = "Data de Nascimento";
            // 
            // DataNascimento
            // 
            DataNascimento.Location = new Point(405, 76);
            DataNascimento.Mask = "00/00/0000";
            DataNascimento.Name = "DataNascimento";
            DataNascimento.Size = new Size(100, 23);
            DataNascimento.TabIndex = 5;
            DataNascimento.ValidatingType = typeof(DateTime);
            // 
            // Telefone
            // 
            Telefone.Location = new Point(369, 124);
            Telefone.Mask = "(999) 000-0000";
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(136, 23);
            Telefone.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.InfoText;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(312, 127);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 7;
            label3.Text = "Telefone";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(59, 127);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(171, 23);
            textBoxEmail.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 135);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // Genero
            // 
            Genero.FormattingEnabled = true;
            Genero.Location = new Point(369, 170);
            Genero.Name = "Genero";
            Genero.Size = new Size(100, 23);
            Genero.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(318, 178);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 11;
            label5.Text = "Genêro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(1, 186);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 12;
            label6.Text = "Nome S.";
            // 
            // textBoxNomeSocial
            // 
            textBoxNomeSocial.Location = new Point(59, 178);
            textBoxNomeSocial.Name = "textBoxNomeSocial";
            textBoxNomeSocial.Size = new Size(171, 23);
            textBoxNomeSocial.TabIndex = 13;
            // 
            // Etnia
            // 
            Etnia.FormattingEnabled = true;
            Etnia.Location = new Point(369, 220);
            Etnia.Name = "Etnia";
            Etnia.Size = new Size(100, 23);
            Etnia.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(330, 228);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 15;
            label7.Text = "Etnia";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = SystemColors.ActiveCaptionText;
            radioButton1.ForeColor = SystemColors.ButtonHighlight;
            radioButton1.Location = new Point(13, 271);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(93, 19);
            radioButton1.TabIndex = 16;
            radioButton1.TabStop = true;
            radioButton1.Text = "Pessoa Física";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = SystemColors.ActiveCaptionText;
            radioButton2.ForeColor = SystemColors.ButtonHighlight;
            radioButton2.Location = new Point(136, 271);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(104, 19);
            radioButton2.TabIndex = 17;
            radioButton2.TabStop = true;
            radioButton2.Text = "Pessoa Jurídica";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.ActiveCaptionText;
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(23, 237);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(85, 19);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Estrangeiro";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlText;
            label8.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(201, 22);
            label8.Name = "label8";
            label8.Size = new Size(110, 23);
            label8.TabIndex = 19;
            label8.Text = "Dados Sociais";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ControlText;
            label9.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(215, 320);
            label9.Name = "label9";
            label9.Size = new Size(78, 23);
            label9.TabIndex = 20;
            label9.Text = "Endereço";
            // 
            // Logradouro
            // 
            Logradouro.Location = new Point(76, 408);
            Logradouro.Name = "Logradouro";
            Logradouro.Size = new Size(171, 23);
            Logradouro.TabIndex = 21;
            // 
            // Numero
            // 
            Numero.Location = new Point(76, 452);
            Numero.Name = "Numero";
            Numero.Size = new Size(171, 23);
            Numero.TabIndex = 22;
            // 
            // Complemento
            // 
            Complemento.Location = new Point(76, 490);
            Complemento.Name = "Complemento";
            Complemento.Size = new Size(171, 23);
            Complemento.TabIndex = 23;
            // 
            // Municipio
            // 
            Municipio.Location = new Point(76, 530);
            Municipio.Name = "Municipio";
            Municipio.Size = new Size(171, 23);
            Municipio.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ActiveCaptionText;
            label10.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(1, 411);
            label10.Name = "label10";
            label10.Size = new Size(63, 16);
            label10.TabIndex = 25;
            label10.Text = "Logradouro";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ActiveCaptionText;
            label11.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(1, 459);
            label11.Name = "label11";
            label11.Size = new Size(45, 16);
            label11.TabIndex = 26;
            label11.Text = "Numero";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ActiveCaptionText;
            label12.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(1, 497);
            label12.Name = "label12";
            label12.Size = new Size(71, 16);
            label12.TabIndex = 27;
            label12.Text = "Complemento";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ActiveCaptionText;
            label13.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(1, 537);
            label13.Name = "label13";
            label13.Size = new Size(51, 16);
            label13.TabIndex = 28;
            label13.Text = "Município";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ActiveCaptionText;
            label14.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(1, 576);
            label14.Name = "label14";
            label14.Size = new Size(36, 16);
            label14.TabIndex = 29;
            label14.Text = "Bairro";
            // 
            // Bairro
            // 
            Bairro.Location = new Point(76, 569);
            Bairro.Name = "Bairro";
            Bairro.Size = new Size(171, 23);
            Bairro.TabIndex = 30;
            // 
            // Estado
            // 
            Estado.FormattingEnabled = true;
            Estado.Location = new Point(357, 408);
            Estado.Name = "Estado";
            Estado.Size = new Size(100, 23);
            Estado.TabIndex = 31;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.ActiveCaptionText;
            label15.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ButtonHighlight;
            label15.Location = new Point(312, 410);
            label15.Name = "label15";
            label15.Size = new Size(39, 16);
            label15.TabIndex = 32;
            label15.Text = "Estado";
            // 
            // Cep
            // 
            Cep.Location = new Point(357, 452);
            Cep.Mask = "000-0000";
            Cep.Name = "Cep";
            Cep.Size = new Size(100, 23);
            Cep.TabIndex = 33;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = SystemColors.ActiveCaptionText;
            label16.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ButtonHighlight;
            label16.Location = new Point(322, 459);
            label16.Name = "label16";
            label16.Size = new Size(29, 16);
            label16.TabIndex = 34;
            label16.Text = "CEP";
            // 
            // button1
            // 
            button1.Location = new Point(348, 537);
            button1.Name = "button1";
            button1.Size = new Size(96, 37);
            button1.TabIndex = 35;
            button1.Text = "Casdastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(513, 679);
            Controls.Add(button1);
            Controls.Add(label16);
            Controls.Add(Cep);
            Controls.Add(label15);
            Controls.Add(Estado);
            Controls.Add(Bairro);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(Municipio);
            Controls.Add(Complemento);
            Controls.Add(Numero);
            Controls.Add(Logradouro);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(checkBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label7);
            Controls.Add(Etnia);
            Controls.Add(textBoxNomeSocial);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Genero);
            Controls.Add(label4);
            Controls.Add(textBoxEmail);
            Controls.Add(label3);
            Controls.Add(Telefone);
            Controls.Add(DataNascimento);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNome);
            Name = "Form1";
            Text = "Cadastro Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNome;
        private Label label1;
        private Label label2;
        private MaskedTextBox DataNascimento;
        private MaskedTextBox Telefone;
        private Label label3;
        private TextBox textBoxEmail;
        private Label label4;
        private ComboBox Genero;
        private Label label5;
        private Label label6;
        private TextBox textBoxNomeSocial;
        private ComboBox Etnia;
        private Label label7;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private CheckBox checkBox1;
        private Label label8;
        private Label label9;
        private TextBox Logradouro;
        private TextBox Numero;
        private TextBox Complemento;
        private TextBox Municipio;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox Bairro;
        private ComboBox Estado;
        private Label label15;
        private MaskedTextBox Cep;
        private Label label16;
        private Button button1;
    }
}
