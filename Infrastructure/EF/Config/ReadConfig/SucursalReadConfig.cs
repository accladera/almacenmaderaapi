
using Infrastructure.EF.ReadModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EF.Config.ReadConfig
{
    public class SucursalReadConfig : IEntityTypeConfiguration<SucursalReadModel>
    {
        public void Configure(EntityTypeBuilder<SucursalReadModel> builder)
        {
            builder.ToTable("Sucursal");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("idSucursal");

            builder.Property(c => c.NombreReferencia).HasColumnName("nombreReferencia");
            builder.Property(c => c.Direccion).HasColumnName("direccion");
            builder.Property(c => c.EsPrincipal).HasColumnName("esPrincipal");
            builder.Property(c => c.CodTipoSucursal).HasColumnName("codTipoSucursal");

        }
    }
}
