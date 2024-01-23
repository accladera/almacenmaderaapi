

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
        public string Mensaje { get; private set; }

        public Notificacion(Guid IdEmpleado, Guid idInventario, DateTime fecha, string mensaje)
        {
            IdEmpleado = IdEmpleado;
            IdInventario = idInventario;
            Fecha = fecha;
            Mensaje = mensaje;
            Id = Guid.NewGuid();

        }
    }
}
