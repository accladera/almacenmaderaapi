using Domain.Factories.interfaces;
using Domain.Repositories;
using MediatR;
using SharedKernel.Core;

namespace Application.UseCases.Commands.MovimientoAgregar
{
    public class MovimientoAgregarHandler : IRequestHandler<MovimientoAgregarCommand, Guid>
    {
        private readonly IMovimientoRepository _MovimientoRepository;
        private readonly IMovimientoFactory _MovimientoFactory;
        private readonly IUnitOfWork _unitOfWork;


        public MovimientoAgregarHandler(IMovimientoRepository MovimientoRepository, IMovimientoFactory MovimientoFactory, IUnitOfWork unitOfWork)
        {
            _MovimientoRepository = MovimientoRepository;
            _MovimientoFactory = MovimientoFactory;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(MovimientoAgregarCommand request, CancellationToken cancellationToken)
        {
            var Movimiento = _MovimientoFactory.Create(request.IdEmpleado, request.IdInventario, request.CodTipoMov, request.ValorEconomico, request.Cantidad, request.Peso);
            await _MovimientoRepository.CreateAsync(Movimiento);
            await _unitOfWork.Commit();
            return Movimiento.Id;
        }
    }
}
