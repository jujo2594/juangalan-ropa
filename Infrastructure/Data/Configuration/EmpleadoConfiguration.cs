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
    public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("Empleado");

            builder.Property(x=>x.IdEmp).IsRequired().HasMaxLength(50);
            builder.HasIndex(x=>x.IdEmp).IsUnique();

            builder.Property(x => x.Nombre)
            .IsRequired()
            .HasMaxLength(100);

            builder.HasOne(x => x.Cargos).WithMany(x => x.Empleados).HasForeignKey(x => x.IdCargoFk);

            builder.Property(x => x.FechaIngreso).HasColumnType("date");

            builder.HasOne(x => x.Municipios).WithMany(x => x.Empleados).HasForeignKey(x => x.IdMunicipioFK);
        }
    }
}