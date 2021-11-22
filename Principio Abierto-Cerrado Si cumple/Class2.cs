using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_Abierto_Cerrado_Si_cumple
{
    internal class CTienda
    {
        private List<CBaseInventario> productos;

        public CTienda(List<CBaseInventario> pProductos)
        {
            productos = pProductos;
        }
        public void calcularInventario()
        {
            double total = 0;

            foreach (var producto in productos)
            {
                producto.CalcularProducto();
                Console.WriteLine(producto);
                total += producto.Producto.Precio;


                Console.WriteLine("El total en inventario de {0}", total);
            }

        }

    }
}
 

