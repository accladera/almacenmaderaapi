
using Domain.Model;
using SharedKernel.Core;

namespace Domain.Repositories
{
    public interface IMovimientoRepository : IRepository<MovimientosInventario, Guid>
    {
        Task UpdateAsync(MovimientosInventario obj);
        Task RemoveAsync(MovimientosInventario obj);
        Task Add(MovimientosInventario obj);
    }
   
}
