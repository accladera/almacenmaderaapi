

using Domain.Factories.interfaces;
using Domain.Model;

namespace Domain.Factories
{
    public class ProductoFactory : IProductoFactory
    {
        public Producto Create(string nombre, string descripcion, int valorUnitario, int stockMinimo, int peso, int altura, int anchura, int codEstadoInicial)
        {
            var obj = new Producto(nombre, descripcion, valorUnitario, stockMinimo, peso, altura, anchura,codEstadoInicial);
            return obj;
        }
    }
}
