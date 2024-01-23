

using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore;
using SharedKernel.ValueObjects;

namespace Infrastructure.EF.Config.WriteConfig
{
    public class AlmacenWriteConfig : IEntityTypeConfiguration<Almacen>
    {
        public void Configure(EntityTypeBuilder<Almacen> builder)
        {
         
            builder.ToTable("Almacen");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("idAlmacen");
            builder.Property(x => x.NombreReferencia).HasColumnName("NombreReferencia");
            builder.Property(x => x.CodTipoAlmacen).HasColumnName("CodTipoAlmacen");
            builder.Property(x => x.IdSucursal).HasColumnName("IdSucursal");

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
        }
    }
}
