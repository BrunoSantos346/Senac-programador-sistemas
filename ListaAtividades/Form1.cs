using ListaAtividades.Dominío;

namespace ListaAtividades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Atividade AtividadeEmAndamento;

        private void Form1_Load(object sender, EventArgs e)
        {
            Atividade atividade = new Atividade();
            AtividadeEmAndamento = atividade.BuscarAtividadeEmAndamento();
            TxTAtividadeemAndamento.Text = $"{AtividadeEmAndamento.Id} - {AtividadeEmAndamento.Titulo}";

            labelErro.Text = string.Empty;

            if (AtividadeEmAndamento.Id > 0)
            {
                TxTAtividadeemAndamento.Text = $"{AtividadeEmAndamento.Id} - {AtividadeEmAndamento.Titulo}";
            }


            var atividadesPendentes = atividade.listaratividadesPendentes();
            dataGridViewAtividades.DataSource = atividadesPendentes;

            CarregarAtividadeEmAndamento();
            CarregarListaAtividades();
           


        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            if (AtividadeEmAndamento == null)
            {
                labelErro.Text = "Não há nenhuma Atividade em Andamento!";
                return;

            }

            if (!AtividadeEmAndamento.atualizarSituacao())
            {
                labelErro.Text = "Não foi Possivel Finalizar atividade";
                return;
            }
            labelErro.Text = string.Empty;
            CarregarAtividadeEmAndamento();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)

        {
            if (dataGridViewAtividades.SelectedRows.Count <= 0)
            {
                labelErro.Text = "Selecione Uma Atividade";
                return;
            }
            var linhaSelecionada = dataGridViewAtividades.SelectedRows[0];
            Atividade atividade = new Atividade()
            {
                Id = (int)linhaSelecionada.Cells[0].Value,
                Titulo = (string)linhaSelecionada.Cells[1].Value,
                situacao = (Situacao)linhaSelecionada.Cells[2].Value,
            };
            if(!atividade.atualizarSituacao())
            {
                labelErro.Text = "Não foi possivel atualizar a atividade";
                return;
            }
            labelErro.Text = string.Empty;
            CarregarAtividadeEmAndamento();
            CarregarListaAtividades();

        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            var resultado = new CriarAtividade().ShowDialog();

            if(resultado != DialogResult.OK)
            {
                labelErro.Text = "A criação da atividade não foi concluída";
                return;
            }

            CarregarListaAtividades();
            labelErro.Text = "Atividade Criada com Sucesso";
            
        }
        private void CarregarListaAtividades()
        {
            Atividade atividade = new();
            var atividadependete = atividade.listaratividadesPendentes();
            dataGridViewAtividades.DataSource = atividadependete;

        }

        private void CarregarAtividadeEmAndamento()
        {
            Atividade atividade = new();
            var atividadeEmAndamento = atividade.BuscarAtividadeEmAndamento();

            if(atividadeEmAndamento.Id > 0)
            {
                TxTAtividadeemAndamento.Text = $"{atividadeEmAndamento.Id} - {atividadeEmAndamento.Titulo}";
            }
        }
    }
}
