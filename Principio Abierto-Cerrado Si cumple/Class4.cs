using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_Abierto_Cerrado_Si_cumple
{
    internal class CinventarioAlimento : CBaseInventario
    {
        public CinventarioAlimento(CProducto pProducto) : base (pProducto)
        {

        }
        public override double CalcularProducto()
        {
            producto.Precio *= 1.2;
            return producto.Precio;
        }
    }
}
