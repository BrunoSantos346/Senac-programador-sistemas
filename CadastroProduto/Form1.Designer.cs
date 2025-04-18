namespace CadastroProduto
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
            textBoxProduto = new TextBox();
            buttonCadastrar = new Button();
            dataGridViewProduto = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            comboBoxQuantide = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).BeginInit();
            SuspendLayout();
            // 
            // textBoxProduto
            // 
            textBoxProduto.Location = new Point(26, 106);
            textBoxProduto.Name = "textBoxProduto";
            textBoxProduto.Size = new Size(204, 23);
            textBoxProduto.TabIndex = 0;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCadastrar.Location = new Point(80, 199);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(80, 31);
            buttonCadastrar.TabIndex = 1;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // dataGridViewProduto
            // 
            dataGridViewProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduto.Location = new Point(468, 83);
            dataGridViewProduto.Name = "dataGridViewProduto";
            dataGridViewProduto.Size = new Size(289, 329);
            dataGridViewProduto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 80);
            label1.Name = "label1";
            label1.Size = new Size(136, 23);
            label1.TabIndex = 3;
            label1.Text = "Cadastrar Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(579, 37);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 3;
            label2.Text = "Estoque";
            // 
            // button2
            // 
            button2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(356, 381);
            button2.Name = "button2";
            button2.Size = new Size(80, 31);
            button2.TabIndex = 1;
            button2.Text = "Remover ";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBoxQuantide
            // 
            comboBoxQuantide.FormattingEnabled = true;
            comboBoxQuantide.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100" });
            comboBoxQuantide.Location = new Point(289, 106);
            comboBoxQuantide.Name = "comboBoxQuantide";
            comboBoxQuantide.Size = new Size(66, 23);
            comboBoxQuantide.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(260, 106);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 3;
            label3.Text = "Qtd";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(103, 135);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "Preço";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(26, 158);
            maskedTextBox1.Mask = "$: 000,00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(204, 23);
            maskedTextBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maskedTextBox1);
            Controls.Add(comboBoxQuantide);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewProduto);
            Controls.Add(button2);
            Controls.Add(buttonCadastrar);
            Controls.Add(textBoxProduto);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProduto;
        private Button buttonCadastrar;
        private DataGridView dataGridViewProduto;
        private Label label1;
        private Label label2;
        private Button button2;
        private ComboBox comboBoxQuantide;
        private Label label3;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
    }
}
