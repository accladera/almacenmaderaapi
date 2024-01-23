
using Domain.Factories.interfaces;
using Domain.Model;

namespace Domain.Factories
{
    public class MovimientoFactory : IMovimientoFactory
    {
        public Movimiento Create(Guid idEmpleado, Guid idInventario, int codTipoMov, int valorEconomicoTotal, int cantidadTotal, int pesoTotal)
        {
           var obj = new Movimiento(idEmpleado, idInventario, DateTime.Now, codTipoMov, valorEconomicoTotal, cantidadTotal, pesoTotal);
            return obj;
        }
    }
}
