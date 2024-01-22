using Domain.Model;


namespace Domain.Factories.interfaces
{
    public interface ISucursalFactory
    {
        Sucursal Create(string nombreReferencia, string direccion, bool esPrincipal, int codTipoSucursal);
    }

}
