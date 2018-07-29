using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;
using ConsumoEnergetico.Biblioteca;

namespace ConsumoEnergetico.Consumo
{
    public partial class ucConsumoMensual : UserControl
    {
        private LiteDatabase db;

        public ucConsumoMensual()
        {
            InitializeComponent();
        }

        public ucConsumoMensual(LiteDatabase db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarConsumo("agua", lblTotalAgua, lblTotalDineroAgua, dtpFechaComienzo.Value, dtpFechaFin.Value);
            ActualizarConsumo("electricidad", lblTotalElectricidad, lblTotalDineroElectricidad, dtpFechaComienzo.Value, dtpFechaFin.Value);
            ActualizarConsumo("gas", lblTotalGas, lblTotalDineroGas, dtpFechaComienzo.Value, dtpFechaFin.Value);
        }

        private void ActualizarConsumo(string indicador, Label lblTotal, Label lblTotalDinero, DateTime fechaComienzo, DateTime fechaFin)
        {
            var costos = db.GetCollection<Costo>(UtilGui.GetStrCostos(indicador)).FindAll();

            var mediciones = db.GetCollection<Medicion>(UtilGui.GetStrMediciones(indicador))
                .Find(x => x.Fecha >= fechaComienzo && x.Fecha <= fechaFin);

            double totalConsumo = mediciones.Sum(x => x.Dato);

            //muestra la suma total de las mediciones segun el indicador
            lblTotal.Text = totalConsumo.ToString();
            lblTotalDinero.Text = "0";

            var costoPrevio = costos.Where(x => x.Fecha < fechaComienzo).OrderBy(x => x.Fecha).LastOrDefault();
            if (costoPrevio == null) return;
            var costosAsociados = costos.Where(x => x.Fecha >= fechaComienzo && x.Fecha < fechaFin).OrderBy(x => x.Fecha);
            if (costosAsociados == null) return;
            double totalMedicionParcial, totalCosto = 0; // costoPrevio.Valor * totalMedicionParcial;

            foreach (var c in costosAsociados)
            {
                totalMedicionParcial = mediciones.Where(x => x.Fecha >= costoPrevio.Fecha && x.Fecha < c.Fecha).Sum(x => x.Dato);
                totalCosto += costoPrevio.Valor * totalMedicionParcial;
                costoPrevio = c;                
            }

            totalMedicionParcial = mediciones.Where(x => x.Fecha >= costoPrevio.Fecha && x.Fecha < fechaFin).Sum(x => x.Dato);
            totalCosto += costoPrevio.Valor * totalMedicionParcial;

            lblTotalDinero.Text = totalCosto.ToString();
        }
    }
}
