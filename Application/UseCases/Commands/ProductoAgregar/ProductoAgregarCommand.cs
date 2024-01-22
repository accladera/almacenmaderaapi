

using MediatR;

namespace Application.UseCases.Commands.ProductoAgregar
{
    public class ProductoAgregarCommand : IRequest<Guid>
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int ValorUnitario { get; set; }
        public int StockMinimo { get; set; }
        public int Peso { get; set; }
        public int Altura { get; set; }
        public int Anchura { get; set; }
        public int CodEstadoInicial { get; set; }

        public ProductoAgregarCommand(string nombre, string descripcion, int valorUnitario, 
            int stockMinimo, int peso, int altura, int anchura, int codEstadoInicial)
        {
            Nombre= nombre;
            Descripcion= descripcion;
            ValorUnitario= valorUnitario;
            StockMinimo= stockMinimo;
            Peso = peso;
            Altura= altura;
            Anchura= anchura;
            CodEstadoInicial = codEstadoInicial;
                
        }
    }
}
