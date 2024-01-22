
using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore;
using SharedKernel.ValueObjects;

namespace Infrastructure.EF.Config.WriteConfig
{
 
    public class InventarioWriteConfig : IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            var guidConverter = new ValueConverter<GuidVerificadoValue, Guid>(
        guidIdValue => guidIdValue.Id,
         guidValue => new GuidVerificadoValue(guidValue)
        );
            builder.ToTable("Inventario");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("idInventario");
            builder.Property(x => x.ValorEcomico).HasColumnName("ValorEcomico");
            builder.Property(x => x.Cantidad).HasColumnName("Cantidad");
            builder.Property(x => x.FechaConteo).HasColumnName("FechaConteo");
            builder.Property(x => x.EsActual).HasColumnName("EsActual");
            builder.Property(x => x.IdAlmacen).HasColumnName("IdAlmacen").HasConversion(guidConverter);
            builder.Property(x => x.IdProducto).HasColumnName("IdProducto").HasConversion(guidConverter);
            //... material, insumos
            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
        }
    }
}
