﻿using CadastroProduto.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProduto.Dominío
{
    internal class Produto
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public decimal preco { get; set; }
        public DateTime dataPedido { get; set; }

       
    }
    
}
