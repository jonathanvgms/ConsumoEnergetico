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

        public ucConsumo()
        {
            InitializeComponent();
        }

        public ucConsumo(LiteDatabase db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void ucConsumo_Load(object sender, EventArgs e)
        {
            dgvHistorialAnual.Rows.Add(2);
            for (int i = 1; i <= 12; i++)
            {
                dgvHistorialAnual.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            }
            dgvHistorialAnual.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHistorialAnual.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            ActualizarGrafico();
        }

        private void ActualizarGrafico()
        {
            var medicionesAgua = db.GetCollection<Medicion>(UtilGui.GetStrMediciones("agua"));

            
            chtAgua.Series["Agua"].Points.AddXY("Ene", 100);
            chtAgua.Series["Agua"].Points.AddXY("Feb", 200);
            chtAgua.Series["Agua"].Points.AddXY("Mar", 300);
            chtAgua.Series["Agua"].Points.AddXY("Abr", 400);
            chtAgua.Series["Agua"].Points.AddXY("May", 200);
            chtAgua.Series["Agua"].Points.AddXY("Jun", 300);
            chtAgua.Series["Agua"].Points.AddXY("Jul", 100);
            chtAgua.Series["Agua"].Points.AddXY("Ago", 100);
            chtAgua.Series["Agua"].Points.AddXY("Sep", 200);
            chtAgua.Series["Agua"].Points.AddXY("Oct", 300);
            chtAgua.Series["Agua"].Points.AddXY("Nov", 400);
            chtAgua.Series["Agua"].Points.AddXY("Dic", 600);
        }
    }
}
