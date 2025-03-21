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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            DataNascimento = new MaskedTextBox();
            TelefoneBox = new MaskedTextBox();
            label3 = new Label();
            textBoxEmail = new TextBox();
            label4 = new Label();
            Genero = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            textBoxNomeSocial = new TextBox();
            Etnia = new ComboBox();
            label7 = new Label();
            radioButtonPF = new RadioButton();
            radioButtonPJ = new RadioButton();
            checkBoxEstrageiro = new CheckBox();
            label8 = new Label();
            label9 = new Label();
            Logradouro = new TextBox();
            Numero = new TextBox();
            Complemento = new TextBox();
            Municipio = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label14 = new Label();
            Bairro = new TextBox();
            EstadoBox = new ComboBox();
            label15 = new Label();
            Cep = new MaskedTextBox();
            label16 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label13 = new Label();
            dataGridView1 = new DataGridView();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(100, 118);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(171, 25);
            textBoxNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Arial Narrow", 11.25F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(143, 94);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 1;
            label1.Text = "Nome Do Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Arial Narrow", 11.25F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(469, 106);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 4;
            label2.Text = "Data de Nascimento";
            // 
            // DataNascimento
            // 
            DataNascimento.Location = new Point(597, 100);
            DataNascimento.Margin = new Padding(3, 4, 3, 4);
            DataNascimento.Mask = "00/00/0000";
            DataNascimento.Name = "DataNascimento";
            DataNascimento.Size = new Size(100, 25);
            DataNascimento.TabIndex = 5;
            DataNascimento.ValidatingType = typeof(DateTime);
            // 
            // TelefoneBox
            // 
            TelefoneBox.Location = new Point(561, 155);
            TelefoneBox.Margin = new Padding(3, 4, 3, 4);
            TelefoneBox.Mask = "(99) 0000-0000";
            TelefoneBox.Name = "TelefoneBox";
            TelefoneBox.Size = new Size(136, 25);
            TelefoneBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Arial Narrow", 11.25F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(480, 160);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 7;
            label3.Text = "Telefone";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(277, 118);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(171, 25);
            textBoxEmail.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Arial Narrow", 11.25F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(342, 94);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // Genero
            // 
            Genero.FormattingEnabled = true;
            Genero.Location = new Point(597, 206);
            Genero.Margin = new Padding(3, 4, 3, 4);
            Genero.Name = "Genero";
            Genero.Size = new Size(100, 28);
            Genero.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.Font = new Font("Arial Narrow", 11.25F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(512, 214);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 11;
            label5.Text = "Genêro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonFace;
            label6.Font = new Font("Arial Narrow", 11.25F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(118, 164);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 12;
            label6.Text = "Nome Social";
            // 
            // textBoxNomeSocial
            // 
            textBoxNomeSocial.Location = new Point(76, 192);
            textBoxNomeSocial.Margin = new Padding(3, 4, 3, 4);
            textBoxNomeSocial.Name = "textBoxNomeSocial";
            textBoxNomeSocial.Size = new Size(171, 25);
            textBoxNomeSocial.TabIndex = 13;
            // 
            // Etnia
            // 
            Etnia.FormattingEnabled = true;
            Etnia.Items.AddRange(new object[] { "Negro(a)", "Branco(a)", "Outros" });
            Etnia.Location = new Point(597, 261);
            Etnia.Margin = new Padding(3, 4, 3, 4);
            Etnia.Name = "Etnia";
            Etnia.Size = new Size(100, 28);
            Etnia.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonFace;
            label7.Font = new Font("Arial Narrow", 11.25F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(526, 269);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 15;
            label7.Text = "Etnia";
            // 
            // radioButtonPF
            // 
            radioButtonPF.AutoSize = true;
            radioButtonPF.BackColor = SystemColors.ButtonFace;
            radioButtonPF.Font = new Font("Arial Narrow", 11.25F);
            radioButtonPF.ForeColor = SystemColors.ActiveCaptionText;
            radioButtonPF.Location = new Point(230, 160);
            radioButtonPF.Margin = new Padding(3, 4, 3, 4);
            radioButtonPF.Name = "radioButtonPF";
            radioButtonPF.Size = new Size(105, 24);
            radioButtonPF.TabIndex = 16;
            radioButtonPF.TabStop = true;
            radioButtonPF.Text = "Pessoa Física";
            radioButtonPF.UseVisualStyleBackColor = false;
            // 
            // radioButtonPJ
            // 
            radioButtonPJ.AutoSize = true;
            radioButtonPJ.BackColor = SystemColors.ButtonFace;
            radioButtonPJ.Font = new Font("Arial Narrow", 11.25F);
            radioButtonPJ.ForeColor = SystemColors.ActiveCaptionText;
            radioButtonPJ.Location = new Point(342, 160);
            radioButtonPJ.Margin = new Padding(3, 4, 3, 4);
            radioButtonPJ.Name = "radioButtonPJ";
            radioButtonPJ.Size = new Size(115, 24);
            radioButtonPJ.TabIndex = 17;
            radioButtonPJ.TabStop = true;
            radioButtonPJ.Text = "Pessoa Jurídica";
            radioButtonPJ.UseVisualStyleBackColor = false;
            // 
            // checkBoxEstrageiro
            // 
            checkBoxEstrageiro.AutoSize = true;
            checkBoxEstrageiro.BackColor = SystemColors.ButtonFace;
            checkBoxEstrageiro.Font = new Font("Arial Narrow", 11.25F);
            checkBoxEstrageiro.ForeColor = SystemColors.ActiveCaptionText;
            checkBoxEstrageiro.Location = new Point(85, 248);
            checkBoxEstrageiro.Margin = new Padding(3, 4, 3, 4);
            checkBoxEstrageiro.Name = "checkBoxEstrageiro";
            checkBoxEstrageiro.Size = new Size(91, 24);
            checkBoxEstrageiro.TabIndex = 18;
            checkBoxEstrageiro.Text = "Estrangeiro";
            checkBoxEstrageiro.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonFace;
            label8.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(312, 32);
            label8.Name = "label8";
            label8.Size = new Size(206, 31);
            label8.TabIndex = 19;
            label8.Text = "Cadastro do Cliente";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonFace;
            label9.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(357, 335);
            label9.Name = "label9";
            label9.Size = new Size(107, 31);
            label9.TabIndex = 20;
            label9.Text = "Endereço";
            // 
            // Logradouro
            // 
            Logradouro.Location = new Point(28, 452);
            Logradouro.Margin = new Padding(3, 4, 3, 4);
            Logradouro.Name = "Logradouro";
            Logradouro.Size = new Size(171, 25);
            Logradouro.TabIndex = 21;
            // 
            // Numero
            // 
            Numero.Location = new Point(212, 452);
            Numero.Margin = new Padding(3, 4, 3, 4);
            Numero.Name = "Numero";
            Numero.Size = new Size(171, 25);
            Numero.TabIndex = 22;
            // 
            // Complemento
            // 
            Complemento.Location = new Point(28, 522);
            Complemento.Margin = new Padding(3, 4, 3, 4);
            Complemento.Name = "Complemento";
            Complemento.Size = new Size(171, 25);
            Complemento.TabIndex = 23;
            // 
            // Municipio
            // 
            Municipio.Location = new Point(212, 522);
            Municipio.Margin = new Padding(3, 4, 3, 4);
            Municipio.Name = "Municipio";
            Municipio.Size = new Size(171, 25);
            Municipio.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonFace;
            label10.Font = new Font("Arial Narrow", 11.25F);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(85, 428);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 25;
            label10.Text = "Logradouro";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ButtonFace;
            label11.Font = new Font("Arial Narrow", 11.25F);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(274, 428);
            label11.Name = "label11";
            label11.Size = new Size(54, 20);
            label11.TabIndex = 26;
            label11.Text = "Numero";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ButtonFace;
            label12.Font = new Font("Arial Narrow", 11.25F);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(76, 498);
            label12.Name = "label12";
            label12.Size = new Size(88, 20);
            label12.TabIndex = 27;
            label12.Text = "Complemento";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ButtonFace;
            label14.Font = new Font("Arial Narrow", 11.25F);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(462, 498);
            label14.Name = "label14";
            label14.Size = new Size(42, 20);
            label14.TabIndex = 29;
            label14.Text = "Bairro";
            // 
            // Bairro
            // 
            Bairro.Location = new Point(404, 522);
            Bairro.Margin = new Padding(3, 4, 3, 4);
            Bairro.Name = "Bairro";
            Bairro.Size = new Size(171, 25);
            Bairro.TabIndex = 30;
            // 
            // EstadoBox
            // 
            EstadoBox.FormattingEnabled = true;
            EstadoBox.Items.AddRange(new object[] { "", "Acre (AC)", "Alagoas (AL)", "Amapá (AP)", "Amazonas (AM)", "Bahia (BA)", "Ceará (CE)", "Distrito Federal (DF)", "Espírito Santo (ES)", "Goiás (GO)", "Maranhão (MA)", "Mato Grosso (MT)", "Mato Grosso do Sul (MS)", "Minas Gerais (MG)", "Pará (PA)", "Paraíba (PB)", "Paraná (PR)", "Pernambuco (PE)", "Piauí (PI)", "Rio de Janeiro (RJ)", "Rio Grande do Norte (RN)", "Rio Grande do Sul (RS)", "Rondônia (RO)", "Roraima (RR)", "Santa Catarina (SC)", "São Paulo (SP)", "Sergipe (SE)", "Tocantins (TO)" });
            EstadoBox.Location = new Point(404, 449);
            EstadoBox.Margin = new Padding(3, 4, 3, 4);
            EstadoBox.Name = "EstadoBox";
            EstadoBox.Size = new Size(100, 28);
            EstadoBox.TabIndex = 31;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.ButtonFace;
            label15.Font = new Font("Arial Narrow", 11.25F);
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(431, 425);
            label15.Name = "label15";
            label15.Size = new Size(47, 20);
            label15.TabIndex = 32;
            label15.Text = "Estado";
            // 
            // Cep
            // 
            Cep.Location = new Point(526, 452);
            Cep.Margin = new Padding(3, 4, 3, 4);
            Cep.Mask = "000-0000";
            Cep.Name = "Cep";
            Cep.Size = new Size(100, 25);
            Cep.TabIndex = 33;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = SystemColors.ButtonFace;
            label16.Font = new Font("Arial Narrow", 11.25F);
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(561, 428);
            label16.Name = "label16";
            label16.Size = new Size(34, 20);
            label16.TabIndex = 34;
            label16.Text = "CEP";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Button_Add_01_25115;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(607, 522);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(106, 49);
            button1.TabIndex = 35;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.Cross;
            pictureBox1.ErrorImage = Properties.Resources.User_80_icon_icons_com_57249__1_;
            pictureBox1.Image = Properties.Resources.User_80_icon_icons_com_57249__1_;
            pictureBox1.Location = new Point(25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(264, 498);
            label13.Name = "label13";
            label13.Size = new Size(64, 20);
            label13.TabIndex = 37;
            label13.Text = "Município";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.MenuBar;
            dataGridView1.Location = new Point(12, 600);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(492, 170);
            dataGridView1.TabIndex = 38;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(625, 575);
            label17.Name = "label17";
            label17.Size = new Size(63, 20);
            label17.TabIndex = 39;
            label17.Text = "Cadastrar";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = Properties.Resources.Capturar1;
            ClientSize = new Size(734, 811);
            Controls.Add(label17);
            Controls.Add(dataGridView1);
            Controls.Add(label13);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label16);
            Controls.Add(Cep);
            Controls.Add(label15);
            Controls.Add(EstadoBox);
            Controls.Add(Bairro);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(Municipio);
            Controls.Add(Complemento);
            Controls.Add(Numero);
            Controls.Add(Logradouro);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(checkBoxEstrageiro);
            Controls.Add(radioButtonPJ);
            Controls.Add(radioButtonPF);
            Controls.Add(label7);
            Controls.Add(Etnia);
            Controls.Add(textBoxNomeSocial);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Genero);
            Controls.Add(label4);
            Controls.Add(textBoxEmail);
            Controls.Add(label3);
            Controls.Add(TelefoneBox);
            Controls.Add(DataNascimento);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNome);
            Font = new Font("Arial Narrow", 11.25F);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Clientes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNome;
        private Label label1;
        private Label label2;
        private MaskedTextBox DataNascimento;
        private MaskedTextBox TelefoneBox;
        private Label label3;
        private TextBox textBoxEmail;
        private Label label4;
        private ComboBox Genero;
        private Label label5;
        private Label label6;
        private TextBox textBoxNomeSocial;
        private ComboBox Etnia;
        private Label label7;
        private RadioButton radioButtonPF;
        private RadioButton radioButtonPJ;
        private CheckBox checkBoxEstrageiro;
        private Label label8;
        private Label label9;
        private TextBox Logradouro;
        private TextBox Numero;
        private TextBox Complemento;
        private TextBox Municipio;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label14;
        private TextBox Bairro;
        private ComboBox EstadoBox;
        private Label label15;
        private MaskedTextBox Cep;
        private Label label16;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label13;
        private DataGridView dataGridView1;
        private Label label17;
    }
}
