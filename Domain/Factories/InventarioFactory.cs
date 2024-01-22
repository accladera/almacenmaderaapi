

using Domain.Factories.interfaces;
using Domain.Model;

namespace Domain.Factories
{
    public class InventarioFactory : IInventarioFactory
    {
        public Inventario Create(Guid idInsumo, Guid idProducto, Guid idMaterial, Guid idAlmacen, int valorEcomico, int cantidad, DateTime fechaConteo, bool esActual)
        {
            var obj = new Inventario(idInsumo,  idProducto,idMaterial,idAlmacen,valorEcomico,cantidad, fechaConteo, esActual);
            return obj;
        }
    }
}
