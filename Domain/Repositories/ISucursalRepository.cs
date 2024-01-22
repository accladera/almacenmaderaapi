

using Domain.Model;
using SharedKernel.Core;

namespace Domain.Repositories
{
    public interface ISucursalRepository : IRepository<Sucursal, Guid>
    {
        Task UpdateAsync(Sucursal obj);
        Task RemoveAsync(Sucursal obj);
        Task Add(Sucursal obj);
    }
  
}
