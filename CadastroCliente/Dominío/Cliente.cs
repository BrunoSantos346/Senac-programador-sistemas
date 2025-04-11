using System;
using System.Xml;

namespace CadastroCliente
{
     class Cliente
     {
        private string email;
        private MaskedTextBox telefone;

        public Cliente()
        {
        }

        public Cliente(int id, string nome, string email, MaskedTextBox telefone)
        {
            ID = id;
            Nome = nome;
            this.email = email;
            this.telefone = telefone;
        }

        public TipoCliente Tipo { get; set; }
        public int ID { get; set; }
        public string Nome  { get; set; }
        public DateTime DataNascimento { get; set; }
        public EndereçoCliente Endereco { get; set; }
        public Etnia Etnia { get; set; }
        public GeneroCliente GeneroCliente { get; set; }
        public string Email {  get; set; }
        public string Telefone { get; set; }
        
        public bool Estrageiro { get; set; }

        
        

        
           
        
            
            
        

     }
    
    
       

    


}
