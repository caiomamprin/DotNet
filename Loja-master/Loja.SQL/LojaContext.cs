using Loja.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Loja.SQL
{
    public class LojaContext : DbContext
    {

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }

        //Construtor 
        public LojaContext(DbContextOptions<LojaContext> opcoes) : base(opcoes)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //Indico que as Chaves primárias serão Identity
            modelBuilder.ForSqlServerUseIdentityColumns();

            //Aplico as Configurações feita nesse assembly(projeto) /Loja.SQL/Configurações
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
