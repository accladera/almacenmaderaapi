

using System.ComponentModel.DataAnnotations;

namespace Infrastructure.EF.ReadModel
{
   
    public class MovimientoReadModel
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime Fecha { get; set; }
        public int CodTipoMov { get; set; }
        public int ValorEconomico { get; set; }
        public int Cantidad { get; set; }
        public int Peso { get; set; }
        public Guid IdEmpleado { get; set; }
        public EmpleadoReadModel Empleado { get; set; }
        public Guid IdInventario { get; set; }
        public InventarioReadModel Inventario { get; set; }


    }
}
