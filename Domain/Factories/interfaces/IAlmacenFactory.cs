using Domain.Model;

namespace Domain.Factories.interfaces
{
    public interface IAlmacenFactory
    {
        Almacen Create(Guid idSucursal, string nombreReferencia, int codTipoAlmacen);
    }
}
