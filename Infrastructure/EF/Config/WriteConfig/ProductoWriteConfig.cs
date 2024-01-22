

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain.Model;

namespace Infrastructure.EF.Config.WriteConfig
{
    public class ProductoWriteConfig : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("Producto");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("idProducto");
            builder.Property(x => x.Nombre).HasColumnName("Nombre");
            builder.Property(x => x.Descripcion).HasColumnName("Descripcion");
            builder.Property(x => x.ValorUnitario).HasColumnName("ValorUnitario");
            builder.Property(x => x.StockMinimo).HasColumnName("StockMinimo");
            builder.Property(x => x.Peso).HasColumnName("Peso");
            builder.Property(x => x.Altura).HasColumnName("Altura");
            builder.Property(x => x.Anchura).HasColumnName("Anchura");
            builder.Property(x => x.CodEstado).HasColumnName("CodEstado");

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
        }
    }
}
