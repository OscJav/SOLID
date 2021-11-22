using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsabilidad_única_SI_Cumple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CEmpleado empleado = new CEmpleado("Juan", "Analista", 38, 2000000);
            Console.WriteLine(empleado);
            Console.WriteLine(CseguridadSocial.pagoSalud(empleado));
            CseguridadSocial.PagarSalud(empleado);
        }
    }
}
