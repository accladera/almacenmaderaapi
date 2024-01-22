

using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EF.Config.WriteConfig
{
    

    public class SucursalWriteConfig : IEntityTypeConfiguration<Sucursal>
    {
        public void Configure(EntityTypeBuilder<Sucursal> builder)
        {
            builder.ToTable("Sucursal");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("idSucursal");
            builder.Property(x => x.NombreReferencia).HasColumnName("NombreReferencia");
            builder.Property(x => x.Direccion).HasColumnName("Direccion");
            builder.Property(x => x.EsPrincipal).HasColumnName("EsPrincipal");
            builder.Property(x => x.CodTipoSucursal).HasColumnName("CodTipoSucursal");

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
        }
    }
}
