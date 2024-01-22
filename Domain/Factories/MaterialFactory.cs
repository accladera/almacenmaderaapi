

using Domain.Factories.interfaces;
using Domain.Model;

namespace Domain.Factories
{
    public class MaterialFactory: IMaterialFactory
    {
        public Material Create(string nombre, string descripcion, int valorUnitario, int stockMinimo, int peso, int altura, int anchura)
        {
            var obj = new Material(nombre, descripcion, valorUnitario, stockMinimo, peso, altura, anchura);
            return obj;
        }
    }
}
