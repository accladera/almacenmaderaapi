using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.EF.ReadModel;

namespace Infrastructure.EF.Config.ReadConfig
{
    public class ProductoReadConfig : IEntityTypeConfiguration<ProductoReadModel>
    {
        public void Configure(EntityTypeBuilder<ProductoReadModel> builder)
        {
            builder.ToTable("Producto");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("idProducto");

            builder.Property(c => c.Nombre).HasColumnName("nombre");
            builder.Property(c => c.Descripcion).HasColumnName("descripcion");
            builder.Property(c => c.ValorUnitario).HasColumnName("valorUnitario");
            builder.Property(c => c.StockMinimo).HasColumnName("stockMinimo");
            builder.Property(c => c.Peso).HasColumnName("peso");
            builder.Property(c => c.Altura).HasColumnName("altura");
            builder.Property(c => c.Anchura).HasColumnName("anchura");
            builder.Property(c => c.CodEstado).HasColumnName("codEstado");

        }
    }
}
