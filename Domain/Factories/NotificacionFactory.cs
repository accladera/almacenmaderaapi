

using Domain.Factories.interfaces;
using Domain.Model;

namespace Domain.Factories
{
    public class NotificacionFactory: INotificacionFactory
    {
        public Notificacion Create(Guid idDestinatario, Guid idStock, string msg)
        {
            var obj = new Notificacion(idDestinatario,idStock,DateTime.Now,msg);
            return obj;
        }
    }
}
