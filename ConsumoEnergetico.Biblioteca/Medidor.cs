using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsumoEnergetico.Biblioteca
{
    public class Medidor
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public Medidor()
        {
            Id = 0;
            Codigo = String.Empty;
            Descripcion = String.Empty;
        }
    }
}
