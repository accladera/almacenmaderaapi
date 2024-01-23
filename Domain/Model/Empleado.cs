
using Domain.ValueObjects;
using SharedKernel.Core;
using SharedKernel.ValueObjects;

namespace Domain.Model
{
    public class Empleado : AggregateRoot<Guid>
    {
        public Guid Id { get; private set; }
        public Guid IdSucursal { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string NombreCompleto { get; private set; }
        public int CodPuesto { get; private set; }

        public Empleado(Guid idSucursal, string email, string password, string nombreCompleto, int codPuesto)
        {
            IdSucursal = idSucursal;
            Email = email;
            Password = password;
            NombreCompleto = nombreCompleto;
            CodPuesto = codPuesto;
            Id = Guid.NewGuid();
         }
    }
}
