

using Application.Dto;
using Application.UseCases.Query.GetAlmacenes;
using Infrastructure.EF.Context;
using Infrastructure.EF.ReadModel;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EF.UseCases
{
    
    public class GetAlmacenesHandler : IRequestHandler<GetAlmacenesQuery, ICollection<AlmacenDto>>
    {
        private readonly DbSet<AlmacenReadModel> _almacenDbSet;

        public GetAlmacenesHandler(ReadDbContext context)
        {
            _almacenDbSet = context.Almacenes;
        }

        public async Task<ICollection<AlmacenDto>> Handle(GetAlmacenesQuery request, CancellationToken cancellationToken)
        {

            var list = await _almacenDbSet
                .AsNoTracking()
                .ToListAsync(cancellationToken);


            var resultado = new List<AlmacenDto>();
            foreach (var item in list)
            {
                var almacenDto = new AlmacenDto()
                {
                    Id = item.Id,
                    Nombre = item.NombreReferencia,
                   

                };
                resultado.Add(almacenDto);
            }

            return resultado;
        }
    }
}
