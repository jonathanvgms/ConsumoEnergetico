using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoEnergetico.Biblioteca
{
    public class Costo
    {
        public int Id { get; set; }

        public double Valor { get; set; }

        public DateTime Fecha { get; set; }

        public Costo()
        {
            Id = 0;
            Valor = 0;
        }
    }
}
