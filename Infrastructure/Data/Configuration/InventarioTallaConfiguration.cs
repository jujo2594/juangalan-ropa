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
    public class InventarioTallaConfiguration : IEntityTypeConfiguration<InventarioTalla>
    {
        public void Configure(EntityTypeBuilder<InventarioTalla> builder)
        {
            builder.ToTable("InventarioTalla");

            builder.HasKey(x => new { x.IdInventarioFk, x.IdTallaFk });

            builder.HasOne(x => x.Inventarios).WithMany(x => x.InventarioTallas).HasForeignKey(x => x.IdInventarioFk);

            builder.HasOne(x => x.Tallas).WithMany(x => x.InventarioTallas).HasForeignKey(x => x.IdTallaFk);
        }
    }
}
