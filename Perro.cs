using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clase17
{
    class Perro : Animal
    {
        string ruido = "Guau ";
        public Perro(string nombre, DateTime fecha, string ruido)
            : base(nombre, fecha)
        {
            this.ruido += ruido;
        }

        public override string Datos()
        {
            return "Perro: " + base.nombre + " Grito: " + Grito();
        }
        public override string Grito()
        {
            return ruido;
        }
    }
}
