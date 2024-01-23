

using Domain.Factories.interfaces;
using Domain.Model;

namespace Domain.Factories
{
    public class InventarioFactory : IInventarioFactory
    {
        public Inventario Create( Guid idProducto,Guid idAlmacen, int valorEconomico, int cantidad, DateTime fechaConteo, bool esActual)
        {
            var obj = new Inventario(idProducto,idAlmacen,valorEconomico,cantidad, fechaConteo, esActual);
            return obj;
        }
    }
}
