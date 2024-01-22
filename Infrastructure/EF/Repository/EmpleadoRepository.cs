

using Domain.Model;
using Domain.Repositories;
using Infrastructure.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EF.Repository
{
    internal class EmpleadoRepository : IEmpleadoRepository
    {
        private readonly WriteDbContext _context;

        public EmpleadoRepository(WriteDbContext context)
        {
            _context = context;
        }
        public Task Add(Empleado obj)
        {
            _context.AddAsync(obj);
            return Task.CompletedTask;
        }

        public async Task CreateAsync(Empleado obj)
        {
            await _context.AddAsync(obj);
        }

        public async Task<Empleado?> FindByIdAsync(Guid id)
        {
            return await _context.Empleados.FirstOrDefaultAsync(x => x.Id == id);
        }


        public Task RemoveAsync(Empleado obj)
        {
            _context.Empleados.Remove(obj);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Empleado Empleado)
        {
            _context.Empleados.Update(Empleado);
            return Task.CompletedTask;
        }
    }
}
