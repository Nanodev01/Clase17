using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemploPolimorfismo
{
    abstract class Animal
    {
        protected string nombre;
        private DateTime fechaNac;
        public Animal(string nom, DateTime nacimiento)
        {
            this.nombre = nom;
            this.fechaNac = nacimiento;
        }
        public abstract string Datos(); 
        public abstract string Grito();
        public string Edad(DateTime hoy)
        {
            TimeSpan edad = hoy.Subtract(fechaNac);
            return ((int)((edad.TotalDays-1)/365.25)).ToString("00");
        }
    }
}
