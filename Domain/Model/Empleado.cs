
using Domain.ValueObjects;
using SharedKernel.Core;
using SharedKernel.ValueObjects;

namespace Domain.Model
{
    public class Empleado : AggregateRoot<Guid>
    {
        public Guid Id { get; private set; }
        public Guid IdSucursal { get; private set; }
        public EmailValue Email { get; private set; }
        public UserPasswordValue Password { get; private set; }
        public NombreGeneralValue NombreCompleto { get; private set; }
        public int CodPuesto { get; private set; }

        public Empleado(Guid idSucursal, EmailValue email, string password, string nombreCompleto, int codPuesto)
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
