
using Domain.Model;
using SharedKernel.Core;

namespace Domain.Repositories
{
    public interface IInsumoRepository : IRepository<Insumo, Guid>
    {
        Task UpdateAsync(Insumo obj);
        Task RemoveAsync(Insumo obj);
        Task Add(Insumo obj);
    }
}
