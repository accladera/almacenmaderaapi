using Domain.Model;

namespace Domain.Factories.interfaces
{
    public interface IMovimientoFactory
    {
        Movimiento Create(Guid idEmpleado, Guid idInventario, int codTipoMov, int valorEconomicoTotal, int cantidadTotal, int pesoTotal);
    }
}
