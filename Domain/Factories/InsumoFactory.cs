
using Domain.Factories.interfaces;
using Domain.Model;

namespace Domain.Factories
{
    public class InsumoFactory : IInsumoFactory
    {
        public Insumo Create(string nombre, string descripcion, int valorUnitario, int stockMinimo, int peso, int altura, int anchura)
        {
            var obj = new Insumo(nombre, descripcion,valorUnitario,stockMinimo,peso,altura,anchura);
            return obj;
        }
    }
}
