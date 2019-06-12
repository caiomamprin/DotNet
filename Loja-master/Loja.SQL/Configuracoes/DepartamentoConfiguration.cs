using Loja.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.SQL.Configuracoes
{
    public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
         //TABELA
            //informo o nome da tabela no BD
            builder.ToTable("Departamentos");

         //COLUNAS
            
            //informo qual sera o ID (por padrão ele ja usa o Id como chave primária
            builder.HasKey(x => x.Id);

            //Falo qual será o nome do departamento (IS Requerid é o Not Null) (HasMaxLength é o tamanho do varchar)
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(50);

        }
    }
}
