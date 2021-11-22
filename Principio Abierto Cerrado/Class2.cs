using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_Abierto_Cerrado
{
    // En esta clase se recibe una lista de productos los recorre e imprime las cantidades y el precio
    // Pero si por ejemplo se aplica un descuento en los precios se tiene que cambiar la clase y no se cumpliria el principio
    // Abierto-Cerrado
    internal class CTienda
    {
        private List<CProducto> productos;

        public CTienda(List<CProducto> pProductos)
        {
            productos = pProductos;
        }
        public void calcularInventario()
        {
            double total = 0;

            foreach (CProducto producto in productos)
            {
                Console.WriteLine(producto);
                total += producto.Precio;


             Console.WriteLine("El total en inventario de {0}", total);
            }
            
        }

    }
}
 