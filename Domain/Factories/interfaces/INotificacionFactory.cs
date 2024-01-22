using Domain.Model;

namespace Domain.Factories.interfaces
{

    public interface INotificacionFactory
    {
        Notificacion Create(Guid idDestinatario, Guid idStock, string msg);
    }
}
