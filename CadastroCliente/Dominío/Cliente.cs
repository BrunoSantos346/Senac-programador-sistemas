using CadastroCliente.Banco_de_dados;
using System;
using System.Xml;
using System.Data;



namespace CadastroCliente.Dominío
{
     class Cliente
     {
      

        

        public TipoCliente Tipo { get; set; }
        public int ID { get; set; }
        public string Nome { get; set; }
        public string NomeSocial { get; set; }
        public DateTime DataNascimento { get; set; }
        public EndereçoCliente Endereco { get; set; }
        public Etnia Etnia { get; set; }
        public GeneroCliente GeneroCliente { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public bool Estrageiro { get; set; }











     }







}
