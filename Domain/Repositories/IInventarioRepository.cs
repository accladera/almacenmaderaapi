

using Domain.Model;
using SharedKernel.Core;

namespace Domain.Repositories
{
    public interface IInventarioRepository : IRepository<Inventario, Guid>
    {
        Task UpdateAsync(Inventario obj);
        Task RemoveAsync(Inventario obj);
        Task Add(Inventario obj);
    }
  
}
