
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.EF.ReadModel
{
    public class SucursalReadModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Direccion { get; set; }
        public string NombreReferencia { get; set; }
        public bool EsPrincipal { get; private set; }
        public int CodTipoSucursal { get; private set; }
    }
}
