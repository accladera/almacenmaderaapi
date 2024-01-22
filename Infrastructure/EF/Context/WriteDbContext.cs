using Domain.Model;
using Infrastructure.EF.Config.WriteConfig;
using Microsoft.EntityFrameworkCore;
using SharedKernel.Core;

namespace Infrastructure.EF.Context
{
    internal class WriteDbContext : DbContext
    {
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Sucursal> Sucursales { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Almacen> Almacenes { get; set; }
        public virtual DbSet<Inventario> Inventarios { get; set; }
        public virtual DbSet<Notificacion> Notificaciones { get; set; }
        public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration<Producto>(new ProductoWriteConfig());
            modelBuilder.ApplyConfiguration<Sucursal>(new SucursalWriteConfig());
            modelBuilder.ApplyConfiguration<Empleado>(new EmpleadoWriteConfig());
            modelBuilder.ApplyConfiguration<Almacen>(new AlmacenWriteConfig());
            modelBuilder.ApplyConfiguration<Inventario>(new InventarioWriteConfig());
            modelBuilder.ApplyConfiguration<Notificacion>(new NotificacionWriteConfig());

            modelBuilder.Ignore<DomainEvent>();
        }



    }
}
