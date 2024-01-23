
using Application.Dto;
using Application.UseCases.Query.GetProductosByAlmacen;
using Infrastructure.EF.Context;
using Infrastructure.EF.ReadModel;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EF.UseCases
{
    public class GetProductosByAlmacenHandler : IRequestHandler<GetProductosByAlmacenQuery, ICollection<ProductoDto>>
    {
        private readonly DbSet<InventarioReadModel> _inventarioDbSet;

        public GetProductosByAlmacenHandler(ReadDbContext context)
        {
            _inventarioDbSet = context.Inventarios;
        }

        public async Task<ICollection<ProductoDto>> Handle(GetProductosByAlmacenQuery request, CancellationToken cancellationToken)
        {

            var inventarios = await _inventarioDbSet
                .AsNoTracking()
                .Include(x => x.Almacen)
                .Where(x => x.IdAlmacen == request.IdAlmacen)
                .Include(x => x.Producto)
                .ToListAsync(cancellationToken);


            var resultado = new List<ProductoDto>();
            foreach (var item in inventarios)
            {
                var productoDto = new ProductoDto()
                {
                    Id = item.IdProducto,
                    Nombre = item.Producto.Nombre,
                    Descripcion= item.Producto.Descripcion,
                    ValorUnitario= item.Producto.ValorUnitario,
                    StockMinimo= item.Producto.StockMinimo,
                    Peso= item.Producto.Peso,
                    Altura= item.Producto.Altura,
                    Anchura= item.Producto.Anchura,
                    CodEstado= item.Producto.CodEstado,

                };
                resultado.Add(productoDto);
            }

            return resultado;
        }
    }
}
