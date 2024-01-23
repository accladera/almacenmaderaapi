
using Domain.Model;

namespace Domain.Factories.interfaces
{
    public interface IInventarioFactory
    {
        Inventario Create(Guid idProducto, Guid idAlmacen, int valorEconomico, int cantidad, DateTime fechaConteo, bool esActual);

    }
}
