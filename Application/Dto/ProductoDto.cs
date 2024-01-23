
namespace Application.Dto
{
    public class ProductoDto
    {
        public Guid Id { get;  set; }
        public string Nombre { get;  set; }
        public string Descripcion { get;  set; }
        public int ValorUnitario { get;  set; }
        public int StockMinimo { get;  set; }
        public int Peso { get;  set; }
        public int Altura { get;  set; }
        public int Anchura { get;  set; }

        public int CodEstado { get;  set; }
    }
}
