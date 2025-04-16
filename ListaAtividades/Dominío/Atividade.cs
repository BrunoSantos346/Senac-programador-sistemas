using ListaAtividades.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividades.Dominío
{
    internal class Atividade
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Situacao situacao { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private readonly AtividadeRepositorio repositorio = new();
        public bool Criar()
        {
            ValidarTitulo();
            if (!ValidarTitulo())
            {
                return false;
            }
            

            repositorio.Criar(Titulo);

           
            return true;
        }
        public bool atualizarSituacao()
        {
            if(!ValidarId())
            {
                return false;
            }
            if (!ValidarSitucao())
            {
                return false;
            }

            Atividade AtividaEmAndamento = BuscarAtividadeEmAndamento();
            Situacao NovaSituacao = BuscarProximaSituação();


            return true;
        }
        public List<Atividade> listaratividadesPendentes()   
        {
            return repositorio.ListarAtividadesPendentes();
        }
        private bool ValidarTitulo()
        {
            return string.IsNullOrWhiteSpace(Titulo);
        }
        private bool ValidarId()
        {
            return Id > 0;
        }
        private bool ValidarSitucao()
        {
            return situacao != Situacao.Concluido;
        }
        public Atividade BuscarAtividadeEmAndamento()
        {
            return repositorio.BuscarAtividadeEmAndamento();
        } 
        public Situacao BuscarProximaSituação()
        {
            if(situacao == Situacao.Pendente)
            {
                return Situacao.Concluido;
            }
          return Situacao.Concluido;
        }
            
    }
}
 