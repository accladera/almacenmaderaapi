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

            builder.Property(c => c.Id).HasColumnName("idAlmacen");

            builder.Property(c => c.NombreReferencia).HasColumnName("nombreReferencia");
            builder.Property(c => c.CodTipoAlmacen).HasColumnName("codTipoAlmacen");
            builder.Property(c => c.IdSucursal).HasColumnName("IdSucursal");
            builder.HasOne(c => c.Sucursal).WithMany()
               .HasForeignKey(c => c.IdSucursal);
        }
    }
}
