using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Factories.interfaces
{
    public interface IMovimientoInventarioFactory
    {
        MovimientosInventario Create(Guid idEmpleado, Guid idStock, int codTipoMov, int valorEconomicoTotal, int cantidadTotal, int pesoTotal);
    }
}
