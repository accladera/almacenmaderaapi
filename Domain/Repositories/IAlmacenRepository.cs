

using Domain.Model;
using SharedKernel.Core;

namespace Domain.Repositories
{
    public interface IAlmacenRepository : IRepository<Almacen, Guid>
    {
        Task UpdateAsync(Almacen obj);
        Task RemoveAsync(Almacen obj);
        Task Add(Almacen obj);
    }
    
}
