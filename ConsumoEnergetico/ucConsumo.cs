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

namespace ConsumoEnergetico
{
    public partial class ucConsumo : UserControl
    {
        private LiteDatabase db;
        private DataTable consumo;
        private List<string> meses = new List<string> { "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" };

        public ucConsumo()
        {
            InitializeComponent();
        }

        public ucConsumo(LiteDatabase db)
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
            chtConsumo.Series.Add("agua");
            chtConsumo.Series["agua"].Color = Color.SteelBlue;
            chtConsumo.Series["agua"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chtConsumo.Series.Add("electricidad");
            chtConsumo.Series["electricidad"].Color = Color.Red;
            chtConsumo.Series["electricidad"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chtConsumo.Series.Add("gas");
            chtConsumo.Series["gas"].Color = Color.DarkGoldenrod;
            chtConsumo.Series["gas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            ActualizarTabla();
        }

        private void ActualizarConsumoIndicador(string indicador)
        {
            var anio = Convert.ToInt32(lstAnios.SelectedItem);
            var mediciones = db.GetCollection<Medicion>(UtilGui.GetStrMediciones(indicador));

            DataRow consumoEje = consumo.NewRow();
            consumoEje["Indicador"] = indicador;
            
            double totalMensual = 0;
            int m = 1;
            foreach (string mes in meses)
            {
                totalMensual = mediciones.FindAll().Where(x => x.Fecha.Month == m && x.Fecha.Year == anio).Sum(x => x.Dato);
                if (totalMensual != 0)
                    consumoEje[mes] = totalMensual;
                else
                    consumoEje[mes] = 0;
                chtConsumo.Series[indicador].Points.AddXY(mes, consumoEje[mes]);
                m++;
            }

            consumoEje["Total"] = mediciones.FindAll().Where(x => x.Fecha.Year == anio).Sum(x => x.Dato);
            consumoEje["Unidad"] = UtilGui.GetUnidad(indicador);

            consumo.Rows.Add(consumoEje);
        }

        private void ActualizarTabla()
        {
            consumo.Clear();

            foreach (var series in chtConsumo.Series)
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
        }

        private void ActualizarTotalesIndicadores()
        {
            var anio = Convert.ToInt32(lstAnios.SelectedItem);
            lblTotalAgua.Text = db.GetCollection<Medicion>(UtilGui.GetStrMediciones("agua")).FindAll().Where(x => x.Fecha.Year == anio).Sum(x => x.Dato).ToString();
            lblTotalElectricidad.Text = db.GetCollection<Medicion>(UtilGui.GetStrMediciones("electricidad")).FindAll().Where(x => x.Fecha.Year == anio).Sum(x => x.Dato).ToString();
            lblTotalGas.Text = db.GetCollection<Medicion>(UtilGui.GetStrMediciones("gas")).FindAll().Where(x => x.Fecha.Year == anio).Sum(x => x.Dato).ToString();
        }
    }
}
