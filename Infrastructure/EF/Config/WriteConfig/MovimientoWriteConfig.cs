
using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore;
using SharedKernel.ValueObjects;

namespace Infrastructure.EF.Config.WriteConfig
{
    
    public class MovimientoWriteConfig : IEntityTypeConfiguration<Movimiento>
    {
        public void Configure(EntityTypeBuilder<Movimiento> builder)
        {
           

            builder.ToTable("Movimiento");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("idMovimiento");
            builder.Property(x => x.Fecha).HasColumnName("Fecha");
            builder.Property(x => x.Peso).HasColumnName("Peso");
            builder.Property(x => x.Cantidad).HasColumnName("Cantidad");
            builder.Property(x => x.ValorEconomico).HasColumnName("ValorEconomico");
            builder.Property(x => x.CodTipoMov).HasColumnName("CodTipoMov");
            builder.Property(x => x.IdEmpleado).HasColumnName("IdEmpleado");
            builder.Property(x => x.IdInventario).HasColumnName("IdInventario");

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
        }
    }
}
