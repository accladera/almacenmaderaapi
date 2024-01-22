using Domain.ValueObjects;
using SharedKernel.Core;
using SharedKernel.ValueObjects;

namespace Domain.Model
{

    public class Material : AggregateRoot<Guid>
    {
        public Guid Id { get; private set; }
        public NombreGeneralValue Nombre { get; private set; }
        public string Descripcion { get; private set; }
        public MontoValue ValorUnitario { get; private set; }
        public MontoValue StockMinimo { get; private set; }
        public MontoValue Peso { get; private set; }
        public MontoValue Altura { get; private set; }
        public MontoValue Anchura { get; private set; }


        public Material(string nombre, string descripcion, int valorUnitario, int stockMinimo,
            int peso, int altura, int anchura)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            ValorUnitario = valorUnitario;
            StockMinimo = stockMinimo;
            Peso = peso;
            Altura = altura;
            Anchura = anchura;
            Id = Guid.NewGuid();

        }
        protected Material()
        {
        }

       
        public void ActualizarValorUnitario(int valorUnitario)
        {
            ValorUnitario = valorUnitario;
        }


        public void ActualizarCantidadMinima(int cantidad)
        {
            StockMinimo = cantidad;
        }









    }
}
