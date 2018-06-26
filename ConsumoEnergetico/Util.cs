using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoEnergetico
{
    public class Util
    {
        string cadena;

        public Util(string unaCadena)
        {
            cadena = unaCadena;
        }

        public static bool cadenaVacia(string unString)
        {
            return string.IsNullOrEmpty(unString);
        }
    }
}
