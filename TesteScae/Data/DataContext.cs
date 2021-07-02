using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using TesteScae.Models;

namespace TesteScae.Data {
    public class DataContext:DbContext {
        public DataContext([NotNullAttribute] DbContextOptions<DataContext> options) : base(options) {
        }

       

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) {

           
               
            
        }

    }
}
