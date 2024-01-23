

using Domain.Factories.interfaces;
using Domain.Model;

namespace Domain.Factories
{
    public class NotificacionFactory: INotificacionFactory
    {
        public Notificacion Create(Guid IdEmpleado, Guid idInventario, string msg)
        {
            var obj = new Notificacion(IdEmpleado, idInventario, DateTime.Now,msg);
            return obj;
        }
    }
}
