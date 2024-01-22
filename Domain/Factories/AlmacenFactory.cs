
using Domain.Factories.interfaces;
using Domain.Model;

namespace Domain.Factories
{
    public class AlmacenFactory : IAlmacenFactory
    {
        public Almacen Create(Guid idSucursal, string nombreReferencia, int codTipoAlmacen)
        {
            var obj = new Almacen(idSucursal,nombreReferencia,codTipoAlmacen);
            return obj;
        }
    }
}
