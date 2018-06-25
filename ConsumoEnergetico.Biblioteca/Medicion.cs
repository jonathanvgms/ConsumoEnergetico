using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoEnergetico.Biblioteca
{
    public class Medicion
    {
        public int Id { get; set; }

        public Medidor Medidor { get; set; }

        public double Dato { get; set; }
        
        public DateTime Fecha { get; set; }

        public string Detalle { get; set; }

        public Medicion()
        {
            Id = 0;
            Dato = 0;
            Detalle = String.Empty;
        }
    }
}
