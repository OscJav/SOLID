using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Para este ejercicio se crea la clase NOTICIERO  y luego se cre la clase Radio como hija __Oscar Malaver
// Para luego sustituir a la clase NOTICIERO con la clase Radio y demostrar que se cumple el principio se sustitución de Liskov
namespace Principio_Sustitución_de_Liskov
{
    internal class Radio : Noticiero
    {
        public Radio(String pMensaje) : base(pMensaje)
        {

        }
        public new void Muestra()
        {
            Console.WriteLine("Desde el radio: {0}", mensaje);
        }
    }
}