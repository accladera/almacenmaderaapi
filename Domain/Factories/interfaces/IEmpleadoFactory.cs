using Domain.Model;
using Domain.ValueObjects;

namespace Domain.Factories.interfaces
{
    public interface IEmpleadoFactory
    {
        Empleado Create(Guid idSucursal, string email, string password, string nombreCompleto, int codPuesto);

    }
}
