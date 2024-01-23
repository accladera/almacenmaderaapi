
using Domain.ValueObjects;
using SharedKernel.Core;
using SharedKernel.ValueObjects;

namespace Domain.Model
{
    //stockPorAlmacen
    public class Inventario : AggregateRoot<Guid>
    {


        public Guid Id { get; private set; }
        public Guid IdProducto { get; private set; }
        public Guid IdAlmacen { get; private set; }
        public int ValorEconomico { get; private set; }
        public int Cantidad { get; private set; }
        public DateTime FechaConteo { get; private set; }
        public bool EsActual { get; private set; }

        public Inventario(Guid idProducto,  Guid idAlmacen, int valorEconomico, int cantidad, DateTime fechaConteo, bool esActual)
        {
            IdProducto = idProducto;
            IdAlmacen = idAlmacen;
            ValorEconomico = valorEconomico;
            Cantidad = cantidad;
            FechaConteo = fechaConteo;
            EsActual = esActual;
            Id = Guid.NewGuid();

        }
    }
}
