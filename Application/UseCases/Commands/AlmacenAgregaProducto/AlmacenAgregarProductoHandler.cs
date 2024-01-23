

using Domain.Factories.interfaces;
using Domain.Repositories;
using MediatR;
using SharedKernel.Core;

namespace Application.UseCases.Commands.AlmacenAgregaProducto
{
    public class AlmacenAgregarProductoHandler : IRequestHandler<AlmacenAgregarProductoCommand, Guid>
    {
        private readonly IInventarioRepository _InventarioRepository;
        private readonly IInventarioFactory _InventarioFactory;
        private readonly IUnitOfWork _unitOfWork;


        public AlmacenAgregarProductoHandler(IInventarioRepository InventarioRepository, IInventarioFactory InventarioFactory, IUnitOfWork unitOfWork)
        {
            _InventarioRepository = InventarioRepository;
            _InventarioFactory = InventarioFactory;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(AlmacenAgregarProductoCommand request, CancellationToken cancellationToken)
        {
            var Inventario = _InventarioFactory.Create(request.IdAlmacen, request.IdProducto,0,0,DateTime.Now,true);
            await _InventarioRepository.CreateAsync(Inventario);
            await _unitOfWork.Commit();
            return Inventario.Id;
        }
    }
}
