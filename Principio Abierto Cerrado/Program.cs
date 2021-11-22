using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Si piden aplicar un descuento diferente para alimentos y otro para medicamentos
// se debe cambiar la clase "miTienda" y no se cumple el principio.
namespace Principio_Abierto_Cerrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CProducto> misProductos = new List<CProducto>
            {
                new CProducto("Papas", 1, 650),
                new CProducto("Analgesico", 2, 1500),
                new CProducto("Tomate", 1, 450),
                new CProducto("Manzana", 1, 900),
            };

            CTienda miTienda = new CTienda(misProductos);



            miTienda.calcularInventario();
        }
    }
}
