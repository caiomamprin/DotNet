using Loja.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.SQL.Configuracoes
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)


        {
        //TABELAS
         
            //Informo a Tabela
            builder.ToTable("Enderecos");
        //COLUNAS

            //Coluna ID - Informo a chave primaria
            builder.HasKey(X => X.Id);


            builder.Property(x => x.Logradouro).IsRequired().HasMaxLength(150);

            builder.Property(x => x.Numero).IsRequired().HasMaxLength(10);

            builder.Property(x => x.Complemento).HasMaxLength(30);

            builder.Property(x => x.Bairro).IsRequired().HasMaxLength(50);

            builder.Property(x => x.Cidade).IsRequired().HasMaxLength(50);

            builder.Property(x => x.Estado).IsRequired().HasMaxLength(2);

       




        }
    }
}
