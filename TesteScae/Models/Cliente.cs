using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteScae.Models {
    public class Cliente {


        [Key]
        public int Id { get; private set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Cpf { get; set; }

        [ForeignKey("EnderecoId")]
        public int EnderecoId { get; private set; }

               

        public Cliente(int id, string nome, string cpf) {
            Id = id;
            Nome = nome;
            Cpf = cpf;
           
        }
    }
}
