
using System.ComponentModel.DataAnnotations;


namespace Infrastructure.EF.ReadModel
{

    public class ProductoReadModel

    {
        [Key]
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int ValorUnitario { get; private set; }
        public int StockMinimo { get; private set; }
        public int Peso { get; private set; }
        public int Altura { get; private set; }
        public int Anchura { get; private set; }
        public int CodEstado { get; private set; }










    }
}
