
using Domain.Model;
using Domain.Repositories;
using Infrastructure.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EF.Repository
{
    internal class InventarioRepository : IInventarioRepository
    {
        private readonly WriteDbContext _context;

        public InventarioRepository(WriteDbContext context)
        {
            _context = context;
        }
        public Task Add(Inventario obj)
        {
            _context.AddAsync(obj);
            return Task.CompletedTask;
        }

        public async Task CreateAsync(Inventario obj)
        {
            await _context.AddAsync(obj);
        }

        public async Task<Inventario?> FindByIdAsync(Guid id)
        {
            return await _context.Inventarios.FirstOrDefaultAsync(x => x.Id == id);
        }


        public Task RemoveAsync(Inventario obj)
        {
            _context.Inventarios.Remove(obj);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Inventario Inventario)
        {
            _context.Inventarios.Update(Inventario);
            return Task.CompletedTask;
        }
    }
}
