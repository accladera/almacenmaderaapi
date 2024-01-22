
using Domain.Model;

namespace Domain.Factories.interfaces
{
    public interface IInventarioFactory
    {
        Inventario Create(Guid idInsumo, Guid idProducto, Guid idMaterial, Guid idAlmacen, int valorEcomico, int cantidad, DateTime fechaConteo, bool esActual);

    }
}
