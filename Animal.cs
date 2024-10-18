using System;
using System.Collections;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clase17
{
    abstract class Animal : IComparable<Animal>, IGuardable
    {

        protected string nombre;
        private DateTime fechaNac;

        static int orden;
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
            return ((int)((edad.TotalDays - 1) / 365.25)).ToString("00");
        }

        public static void TipoOrden(int a)
        { 
            orden = a;
        }
        public int CompareTo(Animal otro)
        {
                       
            if (otro == null)
            {
                return 0;
            }
            else
            {
                switch (orden)
                {
                    case 1:
                        return this.nombre.CompareTo(otro.nombre);
                    default:
                        return this.fechaNac.CompareTo(otro.fechaNac);
                }                
            }

        }

        public string LineaCSV()
        {
            string txt = nombre + "edad : " + fechaNac.ToString();
            if (this is Gato)
            {
                return "Gato" + txt;
            }
            else
            {
                return "Perro -" + txt;
            }

            
        }
    }
}
