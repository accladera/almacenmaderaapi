
using Domain.Factories;
using Domain.Factories.interfaces;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(
            this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddScoped<IAlmacenFactory, AlmacenFactory>();
            services.AddScoped<IEmpleadoFactory, EmpleadoFactory>();
            services.AddScoped<IInsumoFactory, InsumoFactory>();
            services.AddScoped<IInventarioFactory, InventarioFactory>();
            services.AddScoped<IMaterialFactory, MaterialFactory>();
            services.AddScoped<IMovimientoFactory, MovimientoFactory>();
            services.AddScoped<INotificacionFactory, NotificacionFactory>();
            services.AddScoped<IProductoFactory, ProductoFactory>();
            services.AddScoped<ISucursalFactory, SucursalFactory>();
            return services;

        }
    }
}
