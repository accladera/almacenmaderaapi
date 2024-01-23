using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.EF.Migrations
{
    public partial class Inicial_Structure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    idProducto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valorUnitario = table.Column<int>(type: "int", nullable: false),
                    stockMinimo = table.Column<int>(type: "int", nullable: false),
                    peso = table.Column<int>(type: "int", nullable: false),
                    altura = table.Column<int>(type: "int", nullable: false),
                    anchura = table.Column<int>(type: "int", nullable: false),
                    codEstado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.idProducto);
                });

            migrationBuilder.CreateTable(
                name: "Sucursal",
                columns: table => new
                {
                    idSucursal = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombreReferencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    esPrincipal = table.Column<bool>(type: "bit", nullable: false),
                    codTipoSucursal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursal", x => x.idSucursal);
                });

            migrationBuilder.CreateTable(
                name: "Almacen",
                columns: table => new
                {
                    idAlmacen = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombreReferencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codTipoAlmacen = table.Column<int>(type: "int", nullable: false),
                    IdSucursal = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Almacen", x => x.idAlmacen);
                    table.ForeignKey(
                        name: "FK_Almacen_Sucursal_IdSucursal",
                        column: x => x.IdSucursal,
                        principalTable: "Sucursal",
                        principalColumn: "idSucursal",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    idEmpleado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codPuesto = table.Column<int>(type: "int", nullable: false),
                    IdSucursal = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.idEmpleado);
                    table.ForeignKey(
                        name: "FK_Empleado_Sucursal_IdSucursal",
                        column: x => x.IdSucursal,
                        principalTable: "Sucursal",
                        principalColumn: "idSucursal",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventario",
                columns: table => new
                {
                    idInventario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ValorEconomico = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    fechaConteo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    esActual = table.Column<bool>(type: "bit", nullable: false),
                    idProducto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idAlmacen = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventario", x => x.idInventario);
                    table.ForeignKey(
                        name: "FK_Inventario_Almacen_idAlmacen",
                        column: x => x.idAlmacen,
                        principalTable: "Almacen",
                        principalColumn: "idAlmacen",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventario_Producto_idProducto",
                        column: x => x.idProducto,
                        principalTable: "Producto",
                        principalColumn: "idProducto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movimiento",
                columns: table => new
                {
                    idMovimiento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodTipoMov = table.Column<int>(type: "int", nullable: false),
                    ValorEconomico = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    IdEmpleado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idInventario = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimiento", x => x.idMovimiento);
                    table.ForeignKey(
                        name: "FK_Movimiento_Empleado_IdEmpleado",
                        column: x => x.IdEmpleado,
                        principalTable: "Empleado",
                        principalColumn: "idEmpleado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movimiento_Inventario_idInventario",
                        column: x => x.idInventario,
                        principalTable: "Inventario",
                        principalColumn: "idInventario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notificacion",
                columns: table => new
                {
                    idNotificacion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    mensaje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdEmpleado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdInventario = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificacion", x => x.idNotificacion);
                    table.ForeignKey(
                        name: "FK_Notificacion_Empleado_IdEmpleado",
                        column: x => x.IdEmpleado,
                        principalTable: "Empleado",
                        principalColumn: "idEmpleado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notificacion_Inventario_IdInventario",
                        column: x => x.IdInventario,
                        principalTable: "Inventario",
                        principalColumn: "idInventario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Almacen_IdSucursal",
                table: "Almacen",
                column: "IdSucursal");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_IdSucursal",
                table: "Empleado",
                column: "IdSucursal");

            migrationBuilder.CreateIndex(
                name: "IX_Inventario_idAlmacen",
                table: "Inventario",
                column: "idAlmacen");

            migrationBuilder.CreateIndex(
                name: "IX_Inventario_idProducto",
                table: "Inventario",
                column: "idProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Movimiento_IdEmpleado",
                table: "Movimiento",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Movimiento_idInventario",
                table: "Movimiento",
                column: "idInventario");

            migrationBuilder.CreateIndex(
                name: "IX_Notificacion_IdEmpleado",
                table: "Notificacion",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Notificacion_IdInventario",
                table: "Notificacion",
                column: "IdInventario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movimiento");

            migrationBuilder.DropTable(
                name: "Notificacion");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Inventario");

            migrationBuilder.DropTable(
                name: "Almacen");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Sucursal");
        }
    }
}
