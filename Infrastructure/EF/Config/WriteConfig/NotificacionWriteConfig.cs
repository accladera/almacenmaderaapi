using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SharedKernel.ValueObjects;


namespace Infrastructure.EF.Config.WriteConfig
{

    public class NotificacionWriteConfig : IEntityTypeConfiguration<Notificacion>
    {
        public void Configure(EntityTypeBuilder<Notificacion> builder)
        {
            
            builder.ToTable("Notificacion");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("idNotificacion");
            builder.Property(x => x.Fecha).HasColumnName("Fecha");
            builder.Property(x => x.Mensaje).HasColumnName("Mensaje");
            builder.Property(x => x.IdEmpleado).HasColumnName("IdEmpleado");
            builder.Property(x => x.IdInventario).HasColumnName("IdInventario");

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
        }
    }
}
