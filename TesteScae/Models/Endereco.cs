using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteScae.Models {
    public class Endereco {

      
        public int Id { get; private set; }
        
        public string Cep { get; set; }
        public string Rua { get; set; }
        
        public string Bairro { get; set; }
        
        public string Cidade { get; set; }
        
        public string Estado { get; set; }

        public List<Cliente> Clientes { get; private set; } = new List<Cliente>();

        /*public Endereco(string rua, string bairro, string cidade, string estado, string cep){
            this.Rua = rua;
            this.Bairro =bairro;
            this.Cidade =cidade;
            this.Estado = estado;
            this.Cep = cep;
        }*/
    }
}