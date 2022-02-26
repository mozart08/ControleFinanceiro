using ControleFinanceiro.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.DAL.mappings
{
    public class FuncaoMap : IEntityTypeConfiguration<Funcao>
    {
        public void Configure(EntityTypeBuilder<Funcao> builder)
        {
            builder.Property(f => f.Id).ValueGeneratedOnAdd();
            builder.Property(f => f.Descricao).IsRequired().HasMaxLength(50);

            builder.HasData(new Funcao
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Administrador",
                Descricao = "Administrador do Sistema",
                NormalizedName = "ADMINISTRADOR",

            }, new Funcao
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Usuario",
                Descricao = "Usuario do Sistema",
                NormalizedName = "USUARIO",

            }
            );

            builder.ToTable("Funcoes");
        }
    }
}
