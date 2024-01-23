

using Application.Dto;
using MediatR;

namespace Application.UseCases.Query.GetAlmacenes
{
    public class GetAlmacenesQuery : IRequest<ICollection<AlmacenDto>>
    {
        public GetAlmacenesQuery()
        {
        }
    }
}
