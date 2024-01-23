
using Domain.Model;
using Domain.Repositories;
using Infrastructure.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EF.Repository
{
    
    internal class MovimientoRepository :IMovimientoRepository
    {
        private readonly WriteDbContext _context;

        public MovimientoRepository(WriteDbContext context)
        {
            _context = context;
        }
        public Task Add(Movimiento obj)
        {
            _context.AddAsync(obj);
            return Task.CompletedTask;
        }

        public async Task CreateAsync(Movimiento obj)
        {
            await _context.AddAsync(obj);
        }

        public async Task<Movimiento?> FindByIdAsync(Guid id)
        {
            return await _context.Movimientos.FirstOrDefaultAsync(x => x.Id == id);
        }


        public Task RemoveAsync(Movimiento obj)
        {
            _context.Movimientos.Remove(obj);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Movimiento Movimiento)
        {
            _context.Movimientos.Update(Movimiento);
            return Task.CompletedTask;
        }
    }

}
