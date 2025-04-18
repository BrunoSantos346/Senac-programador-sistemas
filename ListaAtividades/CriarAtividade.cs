﻿using ListaAtividades.Dominío;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaAtividades
{
    public partial class CriarAtividade : Form
    {
        public CriarAtividade()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CriarAtividade_Load(object sender, EventArgs e)
        {
            labelErro.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atividade atividade = new Atividade()
            {
                Titulo = textBoxTitulo.Text,
            };
            if(!atividade.Criar())
            {
                labelErro.Text = "Não foi Possivel criar atividade.";
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        
    }
}
