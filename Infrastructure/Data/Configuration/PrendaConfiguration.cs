using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class PrendaConfiguration : IEntityTypeConfiguration<Prenda>
    {
        public void Configure(EntityTypeBuilder<Prenda> builder)
        {
            builder.ToTable("Prenda");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.Property(x=>x.IdPrenda).IsRequired().HasMaxLength(50); 
            builder.HasIndex(x=>x.IdPrenda).IsUnique();

            builder.Property(x => x.Nombre)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(x => x.ValorUnitCop).HasColumnType("double");

            builder.Property(x => x.ValorUnitUsd).HasColumnType("double");

            builder.HasOne(x => x.Estados).WithMany(x => x.Prendas).HasForeignKey(x => x.IdEstadoFk);

            builder.HasOne(x => x.TipoProtecciones).WithMany(x => x.Prendas).HasForeignKey(x => x.IdTipoProteccionFk);

            builder.HasOne(x => x.Generos).WithMany(x => x.Prendas).HasForeignKey(x => x.IdGeneroFk);

        }
    }
}