using Domain.Model;

namespace Domain.Factories.interfaces
{
    public interface IMaterialFactory
    {
        Material Create(string nombre, string descripcion, int valorUnitario, int stockMinimo, int peso, int altura, int anchura);

    }
}
