using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_Abierto_Cerrado_Si_cumple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CBaseInventario> productos = new List<CBaseInventario>
            {
                new CinventarioAlimento(new CProducto("Papas", 1, 650)),
                new  CInventarioMedicamento(new CProducto("Analgesico", 2, 1500)),
                new CinventarioAlimento(new CProducto("Tomate", 1, 450)),
                new CinventarioAlimento(new CProducto("Manzana", 1, 900)),
            };

            CTienda miTienda = new CTienda(productos);



            miTienda.calcularInventario();
        }
    }
}
