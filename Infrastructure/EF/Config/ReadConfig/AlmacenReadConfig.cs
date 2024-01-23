using Infrastructure.EF.ReadModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.EF.Config.ReadConfig
{
   

    public class AlmacenReadConfig : IEntityTypeConfiguration<AlmacenReadModel>
    {
        public void Configure(EntityTypeBuilder<AlmacenReadModel> builder)
        {
            builder.ToTable("Almacen");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("IdAlmacen");

            builder.Property(c => c.NombreReferencia).HasColumnName("NombreReferencia");
            builder.Property(c => c.CodTipoAlmacen).HasColumnName("CodTipoAlmacen");
            builder.Property(c => c.IdSucursal).HasColumnName("IdSucursal");
            builder.HasOne(c => c.Sucursal).WithMany()
               .HasForeignKey(c => c.IdSucursal);
        }
    }
}
