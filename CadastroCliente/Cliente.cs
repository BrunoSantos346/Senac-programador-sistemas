using System;
using System.Xml;

namespace CadastroCliente
{
     class Cliente
     {
        public TipoCliente Tipo { get; set; }
        public int ID { get; set; }
        public string Nome  { get; set; }
        public string DataNascimento { get; set; }
        public EndereçoCliente Endereco { get; set; }
        public Etnia Etnia { get; set; }
        public GeneroCliente GeneroCliente { get; set; }
        
        public bool Estrageiro { get; set; }

        
        public bool ValidarNome()
        {
            return !string.IsNullOrEmpty (Nome);
        }
        public int ObterID()
        {
            return ID++;
        }

        
           
        
            
            
        

     }
    
    
       

    


}
