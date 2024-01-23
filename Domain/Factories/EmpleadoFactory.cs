
using Domain.Factories.interfaces;
using Domain.Model;
using Domain.ValueObjects;

namespace Domain.Factories
{
    public class EmpleadoFactory : IEmpleadoFactory
    {
        public Empleado Create(Guid idSucursal, string email, string password, string nombreCompleto, int codPuesto)
        {
            var obj = new Empleado(idSucursal, email, password, nombreCompleto, codPuesto);
            return obj;
        }
    }
}
