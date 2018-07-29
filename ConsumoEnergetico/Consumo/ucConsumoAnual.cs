using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsumoEnergetico.Biblioteca;
using LiteDB;

namespace ConsumoEnergetico.Consumo
{
    public partial class ucConsumoAnual : UserControl
    {
        private LiteDatabase db;
        private DataTable consumo;
        private List<string> meses = new List<string> { "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" };

        public ucConsumoAnual()
        {
            InitializeComponent();
        }

        public ucConsumoAnual(LiteDatabase db)
        {
            this.db = db;
            InitializeComponent();
            InicializarDataTable();
            CargarAnios();
        }

        private void CargarAnios()
        {
            var anios = new List<int>();
            var mediciones = db.GetCollection<Medicion>(UtilGui.GetStrMediciones("agua"));
            anios = mediciones.FindAll().Select(x => x.Fecha.Year).Distinct().ToList();
            mediciones = db.GetCollection<Medicion>(UtilGui.GetStrMediciones("electricidad"));
            mediciones.FindAll().Select(x => x.Fecha.Year).Distinct().ToList().ForEach(x => anios.Add(x));
            mediciones = db.GetCollection<Medicion>(UtilGui.GetStrMediciones("gas"));
            mediciones.FindAll().Select(x => x.Fecha.Year).Distinct().ToList().ForEach(x => anios.Add(x));
            anios.Distinct().OrderBy(x => x).ToList().ForEach(x => lstAnios.Items.Add(x));
        }

        private void InicializarDataTable()
        {
            consumo = new DataTable();
            consumo.Columns.Add("Indicador", typeof(string));
            consumo.Columns.Add("Ene", typeof(double));
            consumo.Columns.Add("Feb", typeof(double));
            consumo.Columns.Add("Mar", typeof(double));
            consumo.Columns.Add("Abr", typeof(double));
            consumo.Columns.Add("May", typeof(double));
            consumo.Columns.Add("Jun", typeof(double));
            consumo.Columns.Add("Jul", typeof(double));
            consumo.Columns.Add("Ago", typeof(double));
            consumo.Columns.Add("Sep", typeof(double));
            consumo.Columns.Add("Oct", typeof(double));
            consumo.Columns.Add("Nov", typeof(double));
            consumo.Columns.Add("Dic", typeof(double));
            consumo.Columns.Add("Total", typeof(double));
            consumo.Columns.Add("Unidad", typeof(string));
        }

        private void ucConsumo_Load(object sender, EventArgs e)
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

            ActualizarTabla();
        }

        private void ActualizarConsumoIndicador(string indicador)
        {
            var anio = Convert.ToInt32(lstAnios.SelectedItem);
            var mediciones = db.GetCollection<Medicion>(UtilGui.GetStrMediciones(indicador));

            DataRow consumoEje = consumo.NewRow();
            consumoEje["Indicador"] = UtilGui.FormatIndicador(indicador);
            
            double totalMensual = 0;
            int m = 1;
            foreach (string mes in meses)
            {
                totalMensual = mediciones.FindAll().Where(x => x.Fecha.Month == m && x.Fecha.Year == anio).Sum(x => x.Dato);
                if (totalMensual != 0)
                    consumoEje[mes] = totalMensual;
                else
                    consumoEje[mes] = 0;
                switch (indicador)
                {
                    case "agua": chtConsumoAgua.Series[UtilGui.FormatIndicador(indicador)].Points.AddXY(mes, consumoEje[mes]);
                        break;
                    case "electricidad": chtConsumoElectricidad.Series[UtilGui.FormatIndicador(indicador)].Points.AddXY(mes, consumoEje[mes]);
                        break;
                    case "gas": chtConsumoGas.Series[UtilGui.FormatIndicador(indicador)].Points.AddXY(mes, consumoEje[mes]);
                        break;
                }
               
                m++;
            }

            consumoEje["Total"] = mediciones.FindAll().Where(x => x.Fecha.Year == anio).Sum(x => x.Dato);
            consumoEje["Unidad"] = UtilGui.GetUnidad(indicador);

            consumo.Rows.Add(consumoEje);
        }

        private void ActualizarTabla()
        {
            consumo.Clear();

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

            ActualizarConsumoIndicador("agua");
            ActualizarConsumoIndicador("electricidad");
            ActualizarConsumoIndicador("gas");
            
            dgvHistorialAnual.DataSource = consumo;
            
            dgvHistorialAnual.Refresh();
            for (int i = 1; i <= 12; i++)
            {
                dgvHistorialAnual.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            }
            dgvHistorialAnual.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHistorialAnual.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }

        private void SeleccionarAnio_IndexChanged(object sender, EventArgs e)
        {
            ActualizarTabla();
            ActualizarTotalesIndicadores();
            ActualizarTotalesDineroConsumo();
        }

        private void ActualizarTotalesDineroConsumo()
        {
            string fechaIncio = "1/1/" + lstAnios.SelectedItem.ToString();
            string fechaFin = "31/12/" + lstAnios.SelectedItem.ToString();
            ActualizarTotalDineroConsumo("agua", lblTotalDineroAgua, Convert.ToDateTime(fechaIncio), Convert.ToDateTime(fechaFin));
            ActualizarTotalDineroConsumo("electricidad", lblTotalDineroElectricidad, Convert.ToDateTime(fechaIncio), Convert.ToDateTime(fechaFin));
            ActualizarTotalDineroConsumo("gas", lblTotalDineroGas, Convert.ToDateTime(fechaIncio), Convert.ToDateTime(fechaFin));
        }

        private void ActualizarTotalesIndicadores()
        {
            var anio = Convert.ToInt32(lstAnios.SelectedItem);
            lblTotalAgua.Text = db.GetCollection<Medicion>(UtilGui.GetStrMediciones("agua")).FindAll().Where(x => x.Fecha.Year == anio).Sum(x => x.Dato).ToString();
            lblTotalElectricidad.Text = db.GetCollection<Medicion>(UtilGui.GetStrMediciones("electricidad")).FindAll().Where(x => x.Fecha.Year == anio).Sum(x => x.Dato).ToString();
            lblTotalGas.Text = db.GetCollection<Medicion>(UtilGui.GetStrMediciones("gas")).FindAll().Where(x => x.Fecha.Year == anio).Sum(x => x.Dato).ToString();
        }

        private void ActualizarTotalDineroConsumo(string indicador, Label lblTotalDinero, DateTime fechaComienzo, DateTime fechaFin)
        {
            var costos = db.GetCollection<Costo>(UtilGui.GetStrCostos(indicador)).FindAll();

            var mediciones = db.GetCollection<Medicion>(UtilGui.GetStrMediciones(indicador))
                .Find(x => x.Fecha >= fechaComienzo && x.Fecha <= fechaFin);

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
