

using Domain.Model;
using SharedKernel.Core;

namespace Domain.Repositories
{
    public interface IProductoRepository : IRepository<Producto, Guid>
    {
        Task UpdateAsync(Producto obj);
        Task RemoveAsync(Producto obj);
        Task Add(Producto obj);
    }
}
