using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase17
{
    class Auto: IGuardable
    {
        string marca;
        int modelo;
        public Auto(string m, int año)
        {
            marca = m;
            modelo = año;

        }

        public string LineaCSV()
        {
            return "Auto: " + marca + modelo.ToString();
        }


    }
}
