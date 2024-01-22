using Domain.Model;
using Domain.Repositories;
using Infrastructure.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EF.Repository
{
    internal class AlmacenRepository : IAlmacenRepository
    {
        private readonly WriteDbContext _context;

        public AlmacenRepository(WriteDbContext context)
        {
            _context = context;
        }
        public Task Add(Almacen obj)
        {
            _context.AddAsync(obj);
            return Task.CompletedTask;
        }

        public async Task CreateAsync(Almacen obj)
        {
            await _context.AddAsync(obj);
        }

        public async Task<Almacen?> FindByIdAsync(Guid id)
        {
            return await _context.Almacenes.FirstOrDefaultAsync(x => x.Id == id);
        }


        public Task RemoveAsync(Almacen obj)
        {
            _context.Almacenes.Remove(obj);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Almacen Almacen)
        {
            _context.Almacenes.Update(Almacen);
            return Task.CompletedTask;
        }
    }
}
