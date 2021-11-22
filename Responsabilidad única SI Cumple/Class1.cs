using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsabilidad_única_SI_Cumple
{ 
    internal class CEmpleado
    {
        private String nombre;
        private String cargo;
        private int edad;
        private double sueldo;
        // En esta clase se crea con metodos que tienen responsabilidades solo de los empleados
        public string Nombre { get => nombre; set => nombre = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        public CEmpleado(string pNombre,string pCargo,int pEdad,double pSueldo )
        {
            nombre = pNombre;
            cargo = pCargo;
            edad = pEdad;
            sueldo = pSueldo;   
            
        }
        public override string ToString()
        {
            return String.Format("{0},{1},{2},{3}",nombre,cargo,edad,sueldo);

        }
        //Ahora se crean lo metodos que correspondan a responsabilidades de un empleado
        //Para cumplir con el principio de reponsabilidad se crea una nueva clase que se encargue de los descuendo de salud y pensión
        public double valorSueldoDia()
        {
            return sueldo / 30;

        }
            


    }   
}
