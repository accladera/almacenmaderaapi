using Application.Dto;
using Application.UseCases.Query.GetAlmacenesBySucursal;
using Application.UseCases.Query.GetProductosByAlmacen;
using Infrastructure.EF.Context;
using Infrastructure.EF.ReadModel;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.EF.UseCases
{
    public class GetAlmacenesBySucursalHandler : IRequestHandler<GetAlmacenesBySucursalQuery, ICollection<AlmacenDto>>
    {
        private readonly DbSet<AlmacenReadModel> _almacenDbSet;

        public GetAlmacenesBySucursalHandler(ReadDbContext context)
        {
            _almacenDbSet = context.Almacenes;
        }

        public async Task<ICollection<AlmacenDto>> Handle(GetAlmacenesBySucursalQuery request, CancellationToken cancellationToken)
        {

            var almacens = await _almacenDbSet
                .AsNoTracking()
                .ToListAsync(cancellationToken);


            var resultado = new List<AlmacenDto>();
            foreach (var item in almacens)
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
