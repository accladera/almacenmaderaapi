using Infrastructure.EF.ReadModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.EF.Config.ReadConfig
{
   
    public class InventarioReadConfig : IEntityTypeConfiguration<InventarioReadModel>
    {
        public void Configure(EntityTypeBuilder<InventarioReadModel> builder)
        {
            builder.ToTable("Inventario");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("idInventario");

            builder.Property(c => c.ValorEconomico).HasColumnName("ValorEconomico");
            builder.Property(c => c.Cantidad).HasColumnName("cantidad");
            builder.Property(c => c.FechaConteo).HasColumnName("fechaConteo");
            builder.Property(c => c.EsActual).HasColumnName("esActual");

            builder.Property(c => c.IdProducto).HasColumnName("idProducto");
            builder.HasOne(c => c.Producto).WithMany()
               .HasForeignKey(c => c.IdProducto);

            builder.Property(c => c.IdAlmacen).HasColumnName("idAlmacen");
            builder.HasOne(c => c.Almacen).WithMany()
               .HasForeignKey(c => c.IdAlmacen);
        }
    }
}
