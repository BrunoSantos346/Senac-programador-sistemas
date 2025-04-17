namespace ListaAtividades
{
    partial class CriarAtividade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxTitulo = new TextBox();
            button1 = new Button();
            button2 = new Button();
            labelErro = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 201);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 0;
            label1.Text = "Titulo da Tarefa";
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(205, 239);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(211, 23);
            textBoxTitulo.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(248, 268);
            button1.Name = "button1";
            button1.Size = new Size(123, 34);
            button1.TabIndex = 2;
            button1.Text = "Criar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(272, 308);
            button2.Name = "button2";
            button2.Size = new Size(79, 36);
            button2.TabIndex = 2;
            button2.Text = "Descartar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErro.Location = new Point(12, 407);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(50, 16);
            labelErro.TabIndex = 0;
            labelErro.Text = "labelErro";
            // 
            // CriarAtividade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxTitulo);
            Controls.Add(labelErro);
            Controls.Add(label1);
            Name = "CriarAtividade";
            Text = "CriarAtividade";
            Load += CriarAtividade_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxTitulo;
        private Button button1;
        private Button button2;
        private Label labelErro;
    }
}