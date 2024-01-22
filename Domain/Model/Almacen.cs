

using Domain.ValueObjects;
using SharedKernel.Core;
using SharedKernel.ValueObjects;

namespace Domain.Model
{
    public class Almacen : AggregateRoot<Guid>
    {


        public Guid Id { get; private set; }
        public Guid IdSucursal { get; private set; }
        public NombreGeneralValue NombreReferencia { get; private set; }
        public int CodTipoAlmacen { get; private set; }

        public Almacen(Guid idSucursal, string nombreReferencia,  int codTipoAlmacen)
        {

            IdSucursal = idSucursal;
            NombreReferencia = nombreReferencia;
            CodTipoAlmacen = codTipoAlmacen;
            Id = Guid.NewGuid();
        }
    }
}
