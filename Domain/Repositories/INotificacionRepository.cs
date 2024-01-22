

using Domain.Model;
using SharedKernel.Core;

namespace Domain.Repositories
{
    public interface INotificacionRepository : IRepository<Notificacion, Guid>
    {
        Task UpdateAsync(Notificacion obj);
        Task RemoveAsync(Notificacion obj);
        Task Add(Notificacion obj);
    }
}
