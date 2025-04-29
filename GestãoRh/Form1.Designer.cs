namespace GestãoRh
{
    partial class AtualizaçãoDesligamento
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtualizaçãoDesligamento));
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            imageList1 = new ImageList(components);
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            button2 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(348, 330);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(192, 25);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 28);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 53);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 5;
            label3.Text = "Data de Admissão";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBox1.Location = new Point(36, 71);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "add-post.png");
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(397, 321);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(265, 117);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 303);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 9;
            label4.Text = "Obeservação";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(611, 70);
            button1.Name = "button1";
            button1.Size = new Size(66, 25);
            button1.TabIndex = 10;
            button1.Text = "Desligar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(192, 72);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 23);
            textBox3.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(611, 28);
            button2.Name = "button2";
            button2.Size = new Size(66, 23);
            button2.TabIndex = 10;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(146, 80);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "Salario";
            // 
            // AtualizaçãoDesligamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(701, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "AtualizaçãoDesligamento";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox maskedTextBox1;
        private RichTextBox richTextBox1;
        private Label label4;
        private ImageList imageList1;
        private Button button1;
        private TextBox textBox3;
        private Button button2;
        private Label label5;
    }
}
