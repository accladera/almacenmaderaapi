
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.EF.ReadModel
{
   
    public class InventarioReadModel
    {
        [Key]
        public Guid Id { get; set; }
     
        public int ValorEconomico { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaConteo { get; set; }
        public bool EsActual { get; set; }
        public Guid IdProducto { get; set; }
        public ProductoReadModel Producto { get; set; }   
        public Guid IdAlmacen { get; set; }
        public AlmacenReadModel Almacen { get; set; }


    }
}
