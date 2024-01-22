using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.EF.ReadModel
{
    public class EmpleadoReadModel
    {
        [Key]
        public Guid Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int CodPuesto { get; set; }
        public Guid IdSucursal { get; set; }
        public SucursalReadModel Sucursal { get; set; }


    }
}
