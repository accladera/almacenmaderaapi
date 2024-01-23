﻿// <auto-generated />
using System;
using Infrastructure.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.EF.Migrations
{
    [DbContext(typeof(ReadDbContext))]
    [Migration("20240123000959_Inicial_Structure")]
    partial class Inicial_Structure
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Infrastructure.EF.ReadModel.AlmacenReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idAlmacen");

                    b.Property<int>("CodTipoAlmacen")
                        .HasColumnType("int")
                        .HasColumnName("codTipoAlmacen");

                    b.Property<Guid>("IdSucursal")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdSucursal");

                    b.Property<string>("NombreReferencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nombreReferencia");

                    b.HasKey("Id");

                    b.HasIndex("IdSucursal");

                    b.ToTable("Almacen", (string)null);
                });

            modelBuilder.Entity("Infrastructure.EF.ReadModel.EmpleadoReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idEmpleado");

                    b.Property<int>("CodPuesto")
                        .HasColumnType("int")
                        .HasColumnName("codPuesto");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<Guid>("IdSucursal")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdSucursal");

                    b.Property<string>("NombreCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nombreCompleto");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.HasIndex("IdSucursal");

                    b.ToTable("Empleado", (string)null);
                });

            modelBuilder.Entity("Infrastructure.EF.ReadModel.InventarioReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idInventario");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("cantidad");

                    b.Property<bool>("EsActual")
                        .HasColumnType("bit")
                        .HasColumnName("esActual");

                    b.Property<DateTime>("FechaConteo")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaConteo");

                    b.Property<Guid>("IdAlmacen")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idAlmacen");

                    b.Property<Guid>("IdProducto")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idProducto");

                    b.Property<int>("ValorEconomico")
                        .HasColumnType("int")
                        .HasColumnName("ValorEconomico");

                    b.HasKey("Id");

                    b.HasIndex("IdAlmacen");

                    b.HasIndex("IdProducto");

                    b.ToTable("Inventario", (string)null);
                });

            modelBuilder.Entity("Infrastructure.EF.ReadModel.MovimientoReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idMovimiento");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("Cantidad");

                    b.Property<int>("CodTipoMov")
                        .HasColumnType("int")
                        .HasColumnName("CodTipoMov");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2")
                        .HasColumnName("Fecha");

                    b.Property<Guid>("IdEmpleado")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdEmpleado");

                    b.Property<Guid>("IdInventario")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idInventario");

                    b.Property<int>("Peso")
                        .HasColumnType("int")
                        .HasColumnName("Peso");

                    b.Property<int>("ValorEconomico")
                        .HasColumnType("int")
                        .HasColumnName("ValorEconomico");

                    b.HasKey("Id");

                    b.HasIndex("IdEmpleado");

                    b.HasIndex("IdInventario");

                    b.ToTable("Movimiento", (string)null);
                });

            modelBuilder.Entity("Infrastructure.EF.ReadModel.NotificacionReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idNotificacion");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha");

                    b.Property<Guid>("IdEmpleadoDestinatario")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdEmpleado");

                    b.Property<Guid>("IdInventario")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdInventario");

                    b.Property<string>("Mensaje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("mensaje");

                    b.HasKey("Id");

                    b.HasIndex("IdEmpleadoDestinatario");

                    b.HasIndex("IdInventario");

                    b.ToTable("Notificacion", (string)null);
                });

            modelBuilder.Entity("Infrastructure.EF.ReadModel.ProductoReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idProducto");

                    b.Property<int>("Altura")
                        .HasColumnType("int")
                        .HasColumnName("altura");

                    b.Property<int>("Anchura")
                        .HasColumnType("int")
                        .HasColumnName("anchura");

                    b.Property<int>("CodEstado")
                        .HasColumnType("int")
                        .HasColumnName("codEstado");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("descripcion");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nombre");

                    b.Property<int>("Peso")
                        .HasColumnType("int")
                        .HasColumnName("peso");

                    b.Property<int>("StockMinimo")
                        .HasColumnType("int")
                        .HasColumnName("stockMinimo");

                    b.Property<int>("ValorUnitario")
                        .HasColumnType("int")
                        .HasColumnName("valorUnitario");

                    b.HasKey("Id");

                    b.ToTable("Producto", (string)null);
                });

            modelBuilder.Entity("Infrastructure.EF.ReadModel.SucursalReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("idSucursal");

                    b.Property<int>("CodTipoSucursal")
                        .HasColumnType("int")
                        .HasColumnName("codTipoSucursal");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("direccion");

                    b.Property<bool>("EsPrincipal")
                        .HasColumnType("bit")
                        .HasColumnName("esPrincipal");

                    b.Property<string>("NombreReferencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nombreReferencia");

                    b.HasKey("Id");

                    b.ToTable("Sucursal", (string)null);
                });

            modelBuilder.Entity("Infrastructure.EF.ReadModel.AlmacenReadModel", b =>
                {
                    b.HasOne("Infrastructure.EF.ReadModel.SucursalReadModel", "Sucursal")
                        .WithMany()
                        .HasForeignKey("IdSucursal")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sucursal");
                });

            modelBuilder.Entity("Infrastructure.EF.ReadModel.EmpleadoReadModel", b =>
                {
                    b.HasOne("Infrastructure.EF.ReadModel.SucursalReadModel", "Sucursal")
                        .WithMany()
                        .HasForeignKey("IdSucursal")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sucursal");
                });

            modelBuilder.Entity("Infrastructure.EF.ReadModel.InventarioReadModel", b =>
                {
                    b.HasOne("Infrastructure.EF.ReadModel.AlmacenReadModel", "Almacen")
                        .WithMany()
                        .HasForeignKey("IdAlmacen")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.EF.ReadModel.ProductoReadModel", "Producto")
                        .WithMany()
                        .HasForeignKey("IdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Almacen");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Infrastructure.EF.ReadModel.MovimientoReadModel", b =>
                {
                    b.HasOne("Infrastructure.EF.ReadModel.EmpleadoReadModel", "Empleado")
                        .WithMany()
                        .HasForeignKey("IdEmpleado")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Infrastructure.EF.ReadModel.InventarioReadModel", "Inventario")
                        .WithMany()
                        .HasForeignKey("IdInventario")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Empleado");

                    b.Navigation("Inventario");
                });

            modelBuilder.Entity("Infrastructure.EF.ReadModel.NotificacionReadModel", b =>
                {
                    b.HasOne("Infrastructure.EF.ReadModel.EmpleadoReadModel", "Empleado")
                        .WithMany()
                        .HasForeignKey("IdEmpleadoDestinatario")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Infrastructure.EF.ReadModel.InventarioReadModel", "Inventario")
                        .WithMany()
                        .HasForeignKey("IdInventario")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Empleado");

                    b.Navigation("Inventario");
                });
#pragma warning restore 612, 618
        }
    }
}