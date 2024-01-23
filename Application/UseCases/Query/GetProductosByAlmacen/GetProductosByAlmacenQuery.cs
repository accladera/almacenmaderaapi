using Application.Dto;
using MediatR;

namespace Application.UseCases.Query.GetProductosByAlmacen
{
    public class GetProductosByAlmacenQuery : IRequest<ICollection<ProductoDto>>
    {
        public Guid IdAlmacen { get; set; }

        public GetProductosByAlmacenQuery(Guid idAlmacen)
        {
            IdAlmacen = idAlmacen;
        }
    }
}
