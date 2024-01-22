

using SharedKernel.Core;
using SharedKernel.ValueObjects;

namespace Domain.Model
{
    public class Notificacion : AggregateRoot<Guid>
    {
        public Guid Id { get; private set; }
        public Guid IdEmpleado { get; private set; }
        public Guid IdInventario { get; private set; }
        public DateTime Fecha { get; private set; }
        public NombreGeneralValue Mensaje { get; private set; }

        public Notificacion(Guid idEmpleadoDestinatario, Guid idStock, DateTime fecha, string mensaje)
        {
            IdEmpleado = idEmpleadoDestinatario;
            IdInventario = idStock;
            Fecha = fecha;
            Mensaje = mensaje;
            Id = Guid.NewGuid();

        }
    }
}
