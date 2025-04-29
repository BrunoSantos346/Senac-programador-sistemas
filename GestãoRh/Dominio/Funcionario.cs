using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoRh.Dominio
{
    internal class Funcionario
    {
        public int ID {  get; set; }
        public string Nome { get; set; }
        public DateTime Data_Admissao { get; set; }
        public decimal Salario { get; set; }
        public string Observacao { get; set; }
    }
}
