
using Domain.Factories.interfaces;
using Domain.Model;

namespace Domain.Factories
{
    public class MovimientoInventarioFactory : IMovimientoInventarioFactory
    {
        public MovimientosInventario Create(Guid idEmpleado, Guid idStock, int codTipoMov, int valorEconomicoTotal, int cantidadTotal, int pesoTotal)
        {
           var obj = new MovimientosInventario(idEmpleado, idStock, DateTime.Now, codTipoMov, valorEconomicoTotal, cantidadTotal, pesoTotal);
            return obj;
        }
    }
}
