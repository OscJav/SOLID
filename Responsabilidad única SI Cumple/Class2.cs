using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Para cumplir con el principio de responsabilidad unica se crea una clase que se encarde de seguridad social de los empleados
namespace Responsabilidad_única_SI_Cumple
{
    internal class CseguridadSocial
    {
        public static double pagoSalud(CEmpleado pempleado)
        {
            return pempleado.Sueldo * 0.85;
        }
        public static void PagarSalud( CEmpleado pEmpleado)
        {
            double salud = pagoSalud(pEmpleado);
            Console.WriteLine("Se paga {0} en salud de {1}", salud, pEmpleado.Nombre);
        }
    }

   
}
