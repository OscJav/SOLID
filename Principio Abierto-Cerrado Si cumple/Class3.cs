using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_Abierto_Cerrado_Si_cumple
{
    abstract class CBaseInventario
    {
        protected CProducto producto;

        public CProducto Producto { get => producto; set => producto = value; }

        public CBaseInventario(CProducto pProducto)
        {
            producto = pProducto;
        }

        public override string ToString()
        {
            return producto.ToString();
        }
        public abstract double CalcularProducto();

    }
}
 