﻿ using Application;
using Domain.Repositories;
using Infrastructure.EF;
using Infrastructure.EF.Context;
using Infrastructure.EF.Repository;

using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SharedKernel.Core;
using System.Reflection;

namespace Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
          IConfiguration configuration)
        {
            services.AddApplication();
            services.AddMediatR(Assembly.GetExecutingAssembly());

            var connectionString =
                configuration.GetConnectionString("DbConnectionString");

            services.AddDbContext<ReadDbContext>(context =>
                  context.UseSqlServer(connectionString));
            services.AddDbContext<WriteDbContext>(context =>
               context.UseSqlServer(connectionString));


            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProductoRepository, ProductoRepository>();
            services.AddScoped<IInventarioRepository, InventarioRepository>();
            services.AddScoped<IMovimientoRepository, MovimientoRepository>();
            services.AddScoped<INotificacionRepository, NotificacionRepository>();
            services.AddScoped<IAlmacenRepository, AlmacenRepository>();
            services.AddScoped<ISucursalRepository, SucursalRepository>();
            services.AddScoped<IEmpleadoRepository, EmpleadoRepository>();


            return services;

        }
    }
}
