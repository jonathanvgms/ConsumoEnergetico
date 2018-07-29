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
        private List<string> meses = new List<string> { "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" };

        public ucConsumoMensual()
        {
            InitializeComponent();
        }

        public ucConsumoMensual(LiteDatabase db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void ucConsumoMensual_Load(object sender, EventArgs e)
        {
            chtConsumoAgua.Series.Add("Agua");
            chtConsumoAgua.Series["Agua"].Color = Color.SteelBlue;
            chtConsumoAgua.Series["Agua"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chtConsumoAgua.ChartAreas[0].AxisX.Title = "Meses";
            chtConsumoAgua.ChartAreas[0].AxisY.Title = "M3";

            chtConsumoElectricidad.Series.Add("Electricidad");
            chtConsumoElectricidad.Series["Electricidad"].Color = Color.Red;
            chtConsumoElectricidad.Series["Electricidad"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chtConsumoElectricidad.ChartAreas[0].AxisX.Title = "Meses";
            chtConsumoElectricidad.ChartAreas[0].AxisY.Title = "KW";

            chtConsumoGas.Series.Add("Gas");
            chtConsumoGas.Series["Gas"].Color = Color.DarkGoldenrod;
            chtConsumoGas.Series["Gas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chtConsumoGas.ChartAreas[0].AxisX.Title = "Meses";
            chtConsumoGas.ChartAreas[0].AxisY.Title = "M3";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarConsumo("agua", lblTotalAgua, lblTotalDineroAgua, dtpFechaComienzo.Value, dtpFechaFin.Value);
            ActualizarConsumo("electricidad", lblTotalElectricidad, lblTotalDineroElectricidad, dtpFechaComienzo.Value, dtpFechaFin.Value);
            ActualizarConsumo("gas", lblTotalGas, lblTotalDineroGas, dtpFechaComienzo.Value, dtpFechaFin.Value);
            ActualizarCOnsumoGraficos();
        }

        private void ActualizarCOnsumoGraficos()
        {
            foreach (var series in chtConsumoAgua.Series)
            {
                series.Points.Clear();
            }

            foreach (var series in chtConsumoElectricidad.Series)
            {
                series.Points.Clear();
            }

            foreach (var series in chtConsumoGas.Series)
            {
                series.Points.Clear();
            }

            ActualizarConsumoGrafico("agua");
            ActualizarConsumoGrafico("electricidad");
            ActualizarConsumoGrafico("gas");
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

        private void ActualizarConsumoGrafico(string indicador)
        {
            var mediciones = db.GetCollection<Medicion>(UtilGui.GetStrMediciones(indicador))
                .FindAll().Where(x => x.Fecha >= dtpFechaComienzo.Value && x.Fecha <= dtpFechaFin.Value).OrderBy(x => x.Fecha);
            //double totalMensual = 0;
            
            foreach (var mes in mediciones)
            {
                //totalMensual = mediciones.Where(x => x.Fecha.Month == m).Sum(x => x.Dato);
                switch (indicador)
                {
                    case "agua":
                        chtConsumoAgua.Series[UtilGui.FormatIndicador(indicador)].Points.AddXY(mes.Fecha.ToShortDateString(), mes.Dato);
                        break;
                    case "electricidad":
                        chtConsumoElectricidad.Series[UtilGui.FormatIndicador(indicador)].Points.AddXY(mes.Fecha.ToShortDateString(), mes.Dato);
                        break;
                    case "gas":
                        chtConsumoGas.Series[UtilGui.FormatIndicador(indicador)].Points.AddXY(mes.Fecha.ToShortDateString(), mes.Dato);
                        break;
                }
            }
        }       
    }
}