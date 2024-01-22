
using Domain.Model;
using Domain.Repositories;
using Infrastructure.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EF.Repository
{
    internal class SucursalRepository : ISucursalRepository
    {
        private readonly WriteDbContext _context;

        public SucursalRepository(WriteDbContext context)
        {
            _context = context;
        }
        public Task Add(Sucursal obj)
        {
            _context.AddAsync(obj);
            return Task.CompletedTask;
        }

        public async Task CreateAsync(Sucursal obj)
        {
            await _context.AddAsync(obj);
        }

        public async Task<Sucursal?> FindByIdAsync(Guid id)
        {
            return await _context.Sucursales.FirstOrDefaultAsync(x => x.Id == id);
        }


        public Task RemoveAsync(Sucursal obj)
        {
            _context.Sucursales.Remove(obj);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Sucursal Sucursal)
        {
            _context.Sucursales.Update(Sucursal);
            return Task.CompletedTask;
        }
    }
}
