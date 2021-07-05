using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteScae.Models {
    public class Cliente {


        public int Id { get; private set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }
        public string Celular { get; set; }
        public string DataNascimento { get; set; }

        public string EnderecoCep { get; set; }

       




        /*public Cliente(int id, string nome, string cpf, string enderecoCep) {
            Id = id; 
            Nome = nome;
            Cpf = cpf;
            this.EnderecoCep = enderecoCep;
           
        }*/
    }
}
