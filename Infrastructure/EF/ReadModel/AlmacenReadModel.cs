

using System.ComponentModel.DataAnnotations;

namespace Infrastructure.EF.ReadModel
{

    public class AlmacenReadModel

    {
        [Key]
        public Guid Id { get; set; }
        public string NombreReferencia { get; set; }
        public int CodTipoAlmacen { get; set; }
        public Guid IdSucursal { get; set; }
        public SucursalReadModel Sucursal { get; set; }
    }
}
