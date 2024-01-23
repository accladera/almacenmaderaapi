using MediatR;

namespace Application.UseCases.Commands.MovimientoAgregar
{
    public class MovimientoAgregarCommand : IRequest<Guid>
    {
        public Guid IdEmpleado { get; private set; }
        public Guid IdInventario { get; private set; }
        public DateTime Fecha { get; private set; }
        public int CodTipoMov { get; private set; } //ingresa/salida
        public int ValorEconomico { get; private set; }
        public int Cantidad { get; private set; }
        public int Peso { get; private set; }

        public MovimientoAgregarCommand(Guid idEmpleado, Guid idInventario, DateTime fecha, int codTipoMov, int valorEconomico, int cantidad, int peso)
        {
            IdEmpleado = idEmpleado;
            IdInventario = idInventario;
            Fecha = fecha;
            CodTipoMov = codTipoMov;
            ValorEconomico = valorEconomico;
            Cantidad = cantidad;
            Peso = peso;
        }
    }
}
