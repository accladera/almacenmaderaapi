using Infrastructure.EF.ReadModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.EF.Config.ReadConfig
{

    public class EmpleadoReadConfig : IEntityTypeConfiguration<EmpleadoReadModel>
    {
        public void Configure(EntityTypeBuilder<EmpleadoReadModel> builder)
        {
            builder.ToTable("Empleado");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("idEmpleado");

            builder.Property(c => c.NombreCompleto).HasColumnName("nombreCompleto");
            builder.Property(c => c.Email).HasColumnName("email");
            builder.Property(c => c.Password).HasColumnName("password");
            builder.Property(c => c.CodPuesto).HasColumnName("codPuesto");
            builder.Property(c => c.IdSucursal).HasColumnName("IdSucursal");
            builder.HasOne(c => c.Sucursal).WithMany()
               .HasForeignKey(c => c.IdSucursal);
        }
    }
}
