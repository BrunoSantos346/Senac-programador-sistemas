namespace ListaAtividades
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
            AtividadeemAndamento = new TextBox();
            buttonFinalizar = new Button();
            dataGridViewAtividades = new DataGridView();
            buttonAtualizar = new Button();
            buttonCriar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtividades).BeginInit();
            SuspendLayout();
            // 
            // AtividadeemAndamento
            // 
            AtividadeemAndamento.BackColor = SystemColors.ButtonHighlight;
            AtividadeemAndamento.Location = new Point(12, 30);
            AtividadeemAndamento.Name = "AtividadeemAndamento";
            AtividadeemAndamento.ReadOnly = true;
            AtividadeemAndamento.Size = new Size(527, 23);
            AtividadeemAndamento.TabIndex = 0;
            
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.BackColor = SystemColors.ButtonHighlight;
            buttonFinalizar.Cursor = Cursors.Cross;
            buttonFinalizar.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonFinalizar.Location = new Point(580, 30);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(86, 23);
            buttonFinalizar.TabIndex = 1;
            buttonFinalizar.Text = "Finalizar";
            buttonFinalizar.UseVisualStyleBackColor = false;
            // 
            // dataGridViewAtividades
            // 
            dataGridViewAtividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAtividades.Location = new Point(12, 95);
            dataGridViewAtividades.Name = "dataGridViewAtividades";
            dataGridViewAtividades.Size = new Size(418, 328);
            dataGridViewAtividades.TabIndex = 2;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.BackColor = SystemColors.ButtonHighlight;
            buttonAtualizar.Cursor = Cursors.Cross;
            buttonAtualizar.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAtualizar.Location = new Point(453, 112);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(97, 33);
            buttonAtualizar.TabIndex = 1;
            buttonAtualizar.Text = "Atualizar";
            buttonAtualizar.UseVisualStyleBackColor = false;
            // 
            // buttonCriar
            // 
            buttonCriar.BackColor = SystemColors.ButtonHighlight;
            buttonCriar.Cursor = Cursors.Cross;
            buttonCriar.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCriar.Location = new Point(453, 393);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(97, 30);
            buttonCriar.TabIndex = 1;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewAtividades);
            Controls.Add(buttonCriar);
            Controls.Add(buttonAtualizar);
            Controls.Add(buttonFinalizar);
            Controls.Add(AtividadeemAndamento);
            Name = "Form1";
            Text = "Lista de Atividades";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AtividadeemAndamento;
        private Button buttonFinalizar;
        private DataGridView dataGridViewAtividades;
        private Button buttonAtualizar;
        private Button buttonCriar;
    }
}
