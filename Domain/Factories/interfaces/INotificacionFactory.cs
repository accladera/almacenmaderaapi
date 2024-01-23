using Domain.Model;

namespace Domain.Factories.interfaces
{

    public interface INotificacionFactory
    {
        Notificacion Create(Guid IdEmpleado, Guid idInventario, string msg);
    }
}
