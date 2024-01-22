using Domain.Model;

namespace Domain.Factories.interfaces
{
    public interface IInsumoFactory
    {
        Insumo Create(string nombre, string descripcion, int valorUnitario, int stockMinimo, int peso, int altura, int anchura);

    }
}
