

using Domain.Factories.interfaces;
using Domain.Model;

namespace Domain.Factories
{
    public class SucursalFactory : ISucursalFactory
    {
        public Sucursal Create(string nombreReferencia, string direccion, bool esPrincipal, int codTipoSucursal)
        {
            var obj = new Sucursal(nombreReferencia,  direccion,  esPrincipal,  codTipoSucursal);
            return obj;
        }
    }
}
