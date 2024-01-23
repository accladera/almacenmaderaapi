using Domain.Factories.interfaces;
using Domain.Repositories;
using MediatR;
using SharedKernel.Core;

namespace Application.UseCases.Commands.ProductoAgregar
{
    public class ProductoAgregarHandler : IRequestHandler<ProductoAgregarCommand, Guid>
    {
        private readonly IProductoRepository _ProductoRepository;
        private readonly IProductoFactory _ProductoFactory;
        private readonly IUnitOfWork _unitOfWork;


        public ProductoAgregarHandler(IProductoRepository ProductoRepository, IProductoFactory ProductoFactory, IUnitOfWork unitOfWork)
        {
            _ProductoRepository = ProductoRepository;
            _ProductoFactory = ProductoFactory;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(ProductoAgregarCommand request, CancellationToken cancellationToken)
        {
            var Producto = _ProductoFactory.Create(request.Nombre, request.Descripcion, request.ValorUnitario, request.StockMinimo, request.Peso, request.Altura, request.Anchura, request.CodEstadoInicial);
            await _ProductoRepository.CreateAsync(Producto);
            await _unitOfWork.Commit();
            return Producto.Id;
        }
    }
}
