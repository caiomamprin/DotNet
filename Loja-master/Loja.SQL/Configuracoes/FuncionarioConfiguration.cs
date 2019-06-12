using Loja.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.SQL.Configuracoes
{
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Funcionario> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).IsRequired().HasMaxLength(100);

            builder.Property(x => x.CPF).IsRequired().HasMaxLength(11);

            builder.Property(x => x.RG).IsRequired().HasMaxLength(15);

            builder.Property(x => x.Telefone).IsRequired().HasMaxLength(15);

            //CHAVE ESTRANGEIRA - Endereco com Funcionario

            builder
                .HasOne(x => x.Endereco) //pertence apenas um endereço
                .WithOne(y => y.Funcionario) //pertence apenas um funcionario 1 x 1
                .HasForeignKey<Endereco>(x => x.FuncionarioId); //nome da Chave Estrangeira


            //CHAVE ESTRANGEIRA - Departamento com funcionario

            builder
                .HasOne(x => x.Departamento) // 1 funcionario tem apenas 1 departamento
                .WithMany(y => y.Funcionarios) // departamento tem n funcionarios 1 - N
                //COMO JA ESTOU EM FUNCIONARIO, e a DepartamentoId já esta em funcionário, não preciso referenciar a Entidade igual fiz em cima ( <Endereço> )
                .HasForeignKey(x => x.DepartamentoId);

        }
    }
}
