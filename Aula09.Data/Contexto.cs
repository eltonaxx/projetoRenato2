using Aula09.Dados.Configuracoes;
using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Dados
{
    public class Contexto : DbContext {

        //1. CLASSES - ENTIDADES - TABELAS
        //1. INICIO
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Comercio> Comercio { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        //1. FIM

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("server=201.62.57.93;database=dbEcommerce;user id=visualstudio;password=visualstudio;");
            optionsBuilder.UseSqlServer("server=201.62.57.93;database=dbLAB2_2020;user id=visualstudio;password=visualstudio;");
        }
     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //2. DEFINIÇÃO DAS CONFIGURAÇÕES DAS CLASSES
            //2. INICIO
            modelBuilder.ApplyConfiguration(new ClienteConfiguracao());
            modelBuilder.ApplyConfiguration(new ComercioConfiguracao());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguracao());
            //2. FIM
        }

    }
}
