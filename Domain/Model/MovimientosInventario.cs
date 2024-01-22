

using Domain.ValueObjects;
using SharedKernel.Core;

namespace Domain.Model
{
    public class MovimientosInventario : AggregateRoot<Guid>
    {
        public Guid Id { get; private set; }
        public Guid IdEmpleado { get; private set; }
        public Guid IdStock { get; private set; }
        public DateTime Fecha { get; private set; }
        public int CodTipoMov { get; private set; } //ingresa/salida
        public MontoValue ValorEconomico { get; private set; }
        public MontoValue Cantidad { get; private set; }
        public MontoValue Peso { get; private set; }

        public MovimientosInventario(Guid idEmpleadoAutor, Guid idStock, DateTime fecha, int codTipoMov, int valorEconomico, int cantidad, int peso)
        {
            IdEmpleado = idEmpleadoAutor;
            IdStock = idStock;
            Fecha = fecha;
            CodTipoMov = codTipoMov;
            ValorEconomico = valorEconomico;
            Cantidad = cantidad;
            Peso = peso;
            Id= Guid
                .NewGuid();
        }
    }
}
