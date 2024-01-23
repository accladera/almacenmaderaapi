using Application.Dto;
using MediatR;

namespace Application.UseCases.Query.GetProductos
{
    public class GetProductosQuery : IRequest<ICollection<ProductoDto>>
    {

        public GetProductosQuery()
        {
        }
    }
}
