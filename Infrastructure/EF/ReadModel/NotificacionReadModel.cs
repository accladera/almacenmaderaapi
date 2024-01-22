using System.ComponentModel.DataAnnotations;

namespace Infrastructure.EF.ReadModel
{
 
    public class NotificacionReadModel
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Mensaje { get; set; }
        public Guid IdEmpleadoDestinatario { get; set; }
        public EmpleadoReadModel Empleado { get; set; }
        public Guid IdInventario { get; set; }
        public InventarioReadModel Inventario { get; set; }
    }
}
