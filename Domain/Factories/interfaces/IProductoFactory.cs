using Domain.Model;

namespace Domain.Factories.interfaces
{
    public interface IProductoFactory
    {
        Producto Create(string nombre, string descripcion, int valorUnitario, int stockMinimo, int peso, int altura, int anchura, int codEstadoInicial);

    }
}
