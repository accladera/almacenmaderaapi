

using MediatR;

namespace Application.UseCases.Commands.AlmacenAgregaProducto
{
    // se almacena un producto dentro de un almacen, significa que se crea un nuevo inventario para un producto
    public class AlmacenAgregarProductoCommand : IRequest<Guid>
    {
        public Guid IdProducto { get;  set; }
        public Guid IdAlmacen { get;  set; }

        public AlmacenAgregarProductoCommand(Guid idProducto, Guid idAlmacen)
        {
            IdProducto = idProducto;
            IdAlmacen = idAlmacen;
        }
    }
}
