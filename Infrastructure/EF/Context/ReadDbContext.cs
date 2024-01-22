
using Infrastructure.EF.Config.ReadConfig;
using Infrastructure.EF.ReadModel;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EF.Context
{
    public class ReadDbContext : DbContext
    {
        public virtual DbSet<ProductoReadModel> Productos { get; set; }
        public virtual DbSet<SucursalReadModel> Sucursales { get; set; }
        public virtual DbSet<EmpleadoReadModel> Empleados { get; set; }
        public virtual DbSet<AlmacenReadModel> Almacenes { get; set; }
        public virtual DbSet<InventarioReadModel> Inventarios { get; set; }
        public virtual DbSet<NotificacionReadModel> Notificaciones { get; set; }
      
        public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration<ProductoReadModel>(new ProductoReadConfig());
            modelBuilder.ApplyConfiguration<SucursalReadModel>(new SucursalReadConfig());
            modelBuilder.ApplyConfiguration<EmpleadoReadModel>(new EmpleadoReadConfig());
            modelBuilder.ApplyConfiguration<AlmacenReadModel>(new AlmacenReadConfig());
            modelBuilder.ApplyConfiguration<InventarioReadModel>(new InventarioReadConfig());
            modelBuilder.ApplyConfiguration<NotificacionReadModel>(new NotificacionReadConfig());
           
         
        }
    }
}
