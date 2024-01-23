
using SharedKernel.Core;
using SharedKernel.ValueObjects;

namespace Domain.Model
{
    public class Sucursal : AggregateRoot<Guid>
    {
        public Guid Id { get; private set; }
        public string NombreReferencia { get; private set; }
        public string Direccion { get; private set; }
        public bool EsPrincipal { get; private set; }
        public int CodTipoSucursal { get; private set; }

        public Sucursal(string nombreReferencia, string direccion, bool esPrincipal, int codTipoSucursal)
        {
            NombreReferencia = nombreReferencia;
            Direccion = direccion;
            EsPrincipal = esPrincipal;
            CodTipoSucursal = codTipoSucursal;
            Id = Guid.NewGuid();

        }
    }
}
