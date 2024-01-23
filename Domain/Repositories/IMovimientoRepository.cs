
using Domain.Model;
using SharedKernel.Core;

namespace Domain.Repositories
{
    public interface IMovimientoRepository : IRepository<Movimiento, Guid>
    {
        Task UpdateAsync(Movimiento obj);
        Task RemoveAsync(Movimiento obj);
        Task Add(Movimiento obj);
    }
   
}
