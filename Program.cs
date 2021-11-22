using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Para este ejercicio se crea la clase NOTICIERO  y luego se cre la clase Radio como hija 
// Para luego sustituir a la clase NOTICIERO con la clase Radio y demostrar que se cumple el principio se sustitución de Liskov

namespace Principio_Sustitución_de_Liskov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Noticiero miNoticiero = new Noticiero("Hola a todos");
            miNoticiero.Muestra();

            Radio miRadio = new Radio("Como estan?");
            miRadio.Muestra();

            Console.WriteLine("----");
            //En este caso se cumple el principio ya que sustituye correctamente la clase padre con la clase hija__Oscar Malaver
            Noticiero sustitucion = new Radio("Estamos probando");
            sustitucion.Muestra();
        }
    }
}
