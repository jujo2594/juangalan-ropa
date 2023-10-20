using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("DetalleVenta");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.Property(x => x.Cantidad).HasColumnType("int");

            builder.Property(x => x.ValorUnit).HasColumnType("double");

            builder.HasOne(x => x.Ventas).WithMany(x => x.DetalleVentas).HasForeignKey(x => x.IdVentaFk);

            builder.HasOne(x => x.Inventarios).WithMany(x => x.DetalleVentas).HasForeignKey(x => x.IdProductoFk);

            builder.HasOne(x => x.Tallas).WithMany(x => x.DetalleVentas).HasForeignKey(x => x.IdTallaFk);
        }
    }
}