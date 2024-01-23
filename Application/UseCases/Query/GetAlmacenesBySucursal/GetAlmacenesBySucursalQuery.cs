using Application.Dto;
using MediatR;

namespace Application.UseCases.Query.GetAlmacenesBySucursal
{
    public class GetAlmacenesBySucursalQuery : IRequest<ICollection<AlmacenDto>>
    {
        public Guid IdSucursal { get; set; }

        public GetAlmacenesBySucursalQuery(Guid idSucursal)
        {
            IdSucursal = idSucursal;
        }
    }
}
