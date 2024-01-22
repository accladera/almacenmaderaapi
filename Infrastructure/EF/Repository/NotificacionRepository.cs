
using Domain.Model;
using Domain.Repositories;
using Infrastructure.EF.Context;

namespace Infrastructure.EF.Repository
{
    
    internal class NotificacionRepository : INotificacionRepository
    {
        private readonly WriteDbContext _context;

        public NotificacionRepository(WriteDbContext context)
        {
            _context = context;
        }
        public Task Add(Notificacion obj)
        {
            _context.AddAsync(obj);
            return Task.CompletedTask;
        }

        public async Task CreateAsync(Notificacion obj)
        {
            await _context.AddAsync(obj);
        }

        public async Task<Notificacion?> FindByIdAsync(Guid id)
        {
            return await _context.Notificaciones.FirstOrDefaultAsync(x => x.Id == id);
        }


        public Task RemoveAsync(Notificacion obj)
        {
            _context.Notificaciones.Remove(obj);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Notificacion Notificacion)
        {
            _context.Notificaciones.Update(Notificacion);
            return Task.CompletedTask;
        }
    }
}
