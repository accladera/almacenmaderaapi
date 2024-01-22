

using Domain.Model;
using Domain.Repositories;
using Infrastructure.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EF.Repository
{
    internal class ProductoRepository : IProductoRepository
    {
        private readonly WriteDbContext _context;

        public ProductoRepository(WriteDbContext context)
        {
            _context = context;
        }
        public Task Add(Producto obj)
        {
            _context.AddAsync(obj);
            return Task.CompletedTask;
        }

        public async Task CreateAsync(Producto obj)
        {
            await _context.AddAsync(obj);
        }

        public async Task<Producto?> FindByIdAsync(Guid id)
        {
            return await _context.Productos.FirstOrDefaultAsync(x => x.Id == id);
        }


        public Task RemoveAsync(Producto obj)
        {
            _context.Productos.Remove(obj);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Producto Producto)
        {
            _context.Productos.Update(Producto);
            return Task.CompletedTask;
        }
    }
}
