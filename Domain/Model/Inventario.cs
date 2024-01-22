
using Domain.ValueObjects;
using SharedKernel.Core;
using SharedKernel.ValueObjects;

namespace Domain.Model
{
    //stockPorAlmacen
    public class Inventario : AggregateRoot<Guid>
    {


        public Guid Id { get; private set; }
        public Guid IdInsumo { get; private set; }
        public Guid IdProducto { get; private set; }
        public Guid IdMaterial { get; private set; }
        public Guid IdAlmacen { get; private set; }
        public MontoValue ValorEcomico { get; private set; }
        public MontoValue Cantidad { get; private set; }
        public DateTime FechaConteo { get; private set; }
        public bool EsActual { get; private set; }

        public Inventario(Guid idInsumo, Guid idProducto, Guid idMaterial, Guid idAlmacen, int valorEcomico, int cantidad, DateTime fechaConteo, bool esActual)
        {
            IdInsumo = idInsumo;
            IdProducto = idProducto;
            IdMaterial = idMaterial;
            IdAlmacen = idAlmacen;
            ValorEcomico = valorEcomico;
            Cantidad = cantidad;
            FechaConteo = fechaConteo;
            EsActual = esActual;
            Id = Guid.NewGuid();

        }
    }
}
