using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class InsumoProveedorConfiguration : IEntityTypeConfiguration<InsumoProveedor>
    {
        public void Configure(EntityTypeBuilder<InsumoProveedor> builder)
        {
            builder.ToTable("InsumoProveedor");

            builder.HasKey(x => new { x.IdInsumoFk, x.IdProveedorFk });

            builder.HasOne(x => x.Insumos).WithMany(x => x.InsumoProveedores).HasForeignKey(x => x.IdInsumoFk);

            builder.HasOne(x => x.Proveedores).WithMany(x => x.InsumoProveedores).HasForeignKey(x => x.IdProveedorFk);
        }
    }
}