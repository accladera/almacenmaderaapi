
using Application.Dto;
using Application.UseCases.Query.GetProductos;
using Infrastructure.EF.Context;
using Infrastructure.EF.ReadModel;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EF.UseCases
{
    public class GetProductosHandler : IRequestHandler<GetProductosQuery, ICollection<ProductoDto>>
    {
        private readonly DbSet<ProductoReadModel> _productoDbSet;

        public GetProductosHandler(ReadDbContext context)
        {
            _productoDbSet = context.Productos;
        }

        public async Task<ICollection<ProductoDto>> Handle(GetProductosQuery request, CancellationToken cancellationToken)
        {

            var list = await _productoDbSet
                .AsNoTracking()
                .ToListAsync(cancellationToken);


            var resultado = new List<ProductoDto>();
            foreach (var item in list)
            {
                var productoDto = new ProductoDto()
                {
                    Id = item.Id,
                    Nombre = item.Nombre,
                    Descripcion= item.Descripcion,
                    ValorUnitario= item.ValorUnitario,
                    StockMinimo= item.StockMinimo,
                    Peso= item.Peso,
                    Altura= item.Altura,
                    Anchura= item.Anchura,
                    CodEstado= item.CodEstado,

                };
                resultado.Add(productoDto);
            }

            return resultado;
        }
    }
}
