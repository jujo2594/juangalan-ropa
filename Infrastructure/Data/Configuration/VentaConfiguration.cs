using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class VentaConfiguration : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.ToTable("Venta");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.Property(x => x.Fecha).HasColumnType("date");

            builder.HasOne(x => x.Empleados).WithMany(x => x.Ventas)
            .HasForeignKey(x => x.IdEmpleadoFk);

            builder.HasOne(x => x.Clientes).WithMany(x => x.Ventas).HasForeignKey(x => x.IdClienteFk);

            builder.HasOne(x => x.FormaPagos).WithMany(x => x.Ventas).HasForeignKey(x => x.IdFormaPagoFk);
        }
    }
}