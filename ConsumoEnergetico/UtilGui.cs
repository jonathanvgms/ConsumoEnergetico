using ConsumoEnergetico.Biblioteca;
using LiteDB;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ConsumoEnergetico
{
    public class UtilGui
    {
        public static void ActualizarMedidores(string strIndicador, LiteDatabase db, ComboBox cboMedidor)
        {
            var medidores = db.GetCollection<Medidor>(GetStrMedidores(strIndicador));
            cboMedidor.Items.Clear();
            medidores.FindAll().ToList().ForEach(x => cboMedidor.Items.Add(x));
            cboMedidor.DisplayMember = "Codigo";
        }

        public static string GetStrMedidores(string indicador)
        {
            if (indicador == "agua")
                return "medidoresAgua";

            if (indicador == "gas")
                return "medidoresGas";

            if (indicador == "electricidad")
                return "medidoresElectricidad";

            return String.Empty;
        }

        public static string GetStrMediciones(string indicador)
        {
            if (indicador == "agua")
                return "medicionesAgua";

            if (indicador == "gas")
                return "medicionesGas";

            if (indicador == "electricidad")
                return "medicionesElectricidad";

            return String.Empty;
        }

        public static string GetStrCostos(string indicador)
        {
            if (indicador == "agua")
                return "costosAgua";

            if (indicador == "gas")
                return "costosGas";

            if (indicador == "electricidad")
                return "costosElectricidad";

            return String.Empty;
        }

        public static string GetUnidad(string indicador)
        {
            if (indicador == "agua")
                return "M3";

            if (indicador == "gas")
                return "M3";

            if (indicador == "electricidad")
                return "KW";

            return String.Empty;
        }
    }
}
