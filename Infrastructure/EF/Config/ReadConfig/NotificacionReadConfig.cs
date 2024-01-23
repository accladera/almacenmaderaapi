

using Infrastructure.EF.ReadModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EF.Config.ReadConfig
{
  
    public class NotificacionReadConfig : IEntityTypeConfiguration<NotificacionReadModel>
    {
        public void Configure(EntityTypeBuilder<NotificacionReadModel> builder)
        {
            builder.ToTable("Notificacion");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("idNotificacion");

            builder.Property(c => c.Fecha).HasColumnName("fecha");
            builder.Property(c => c.Mensaje).HasColumnName("mensaje");

            builder.Property(c => c.IdInventario).HasColumnName("IdInventario");
            builder.HasOne(c => c.Inventario).WithMany()
               .HasForeignKey(c => c.IdInventario)
               .OnDelete(DeleteBehavior.Restrict);

            builder.Property(c => c.IdEmpleadoDestinatario).HasColumnName("IdEmpleado");
            builder.HasOne(c => c.Empleado).WithMany()
               .HasForeignKey(c => c.IdEmpleadoDestinatario)
               .OnDelete(DeleteBehavior.Restrict);

        }
    }

}
