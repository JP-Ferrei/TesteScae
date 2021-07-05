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


        protected override void OnModelCreating(ModelBuilder builder) {

            base.OnModelCreating(builder);

            builder.Entity<Endereco>().ToTable("Enderecos");
            builder.Entity<Endereco>().HasKey(e => e.Id);
            builder.Entity<Endereco>().Property(e => e.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Endereco>().Property(e => e.Cep).IsRequired();
            builder.Entity<Endereco>().Property(e => e.Bairro).IsRequired();
            builder.Entity<Endereco>().Property(e => e.Cidade).IsRequired();
            builder.Entity<Endereco>().Property(e => e.Estado).IsRequired();
            builder.Entity<Endereco>().Property(e => e.Rua).IsRequired();


            builder.Entity<Cliente>().ToTable("Clientes");
            builder.Entity<Cliente>().HasKey(c => c.Id);
            builder.Entity<Cliente>().Property(c => c.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Cliente>().Property(c => c.Nome).IsRequired().HasMaxLength(60);
            builder.Entity<Cliente>().Property(c => c.Cpf).IsRequired().HasMaxLength(14);
            builder.Entity<Cliente>().Property(c => c.DataNascimento).IsRequired().HasMaxLength(15);
            builder.Entity<Cliente>().Property(c => c.Celular).IsRequired().HasMaxLength(15);

        }

    }
}
