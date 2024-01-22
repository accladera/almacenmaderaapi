
using Domain.Model;
using SharedKernel.Core;

namespace Domain.Repositories
{
    public interface IEmpleadoRepository : IRepository<Empleado, Guid>
    {
        Task UpdateAsync(Empleado obj);
        Task RemoveAsync(Empleado obj);
        Task Add(Empleado obj);
    }
}
