using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SharedKernel.ValueObjects;

namespace Infrastructure.EF.Config.WriteConfig
{

    public class EmpleadoWriteConfig : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
         
            builder.ToTable("Empleado");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("idEmpleado");
            builder.Property(x => x.NombreCompleto).HasColumnName("NombreCompleto");
            builder.Property(x => x.Email).HasColumnName("Email");
            builder.Property(x => x.Password).HasColumnName("Password");
            builder.Property(x => x.CodPuesto).HasColumnName("CodPuesto");
            builder.Property(x => x.IdSucursal).HasColumnName("IdSucursal");

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
        }
    }
}
