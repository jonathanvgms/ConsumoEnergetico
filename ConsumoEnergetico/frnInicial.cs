using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsumoEnergetico.Biblioteca;
using LiteDB;

namespace ConsumoEnergetico
{
    public partial class frnInicial : Form
    {
        private LiteDatabase db;
        private int anchoBarraTitulo = 0;
        private int altoBarraTitulo = 20;
        private string pathDatabase = String.Empty;

        public frnInicial()
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(pathDatabase))
            {
                db = new LiteDatabase(@"mediciones.db");
            }
            picPortada.Location = new Point(ClientSize.Width / 2 - picPortada.Size.Width / 2 - anchoBarraTitulo, ClientSize.Height / 2 - picPortada.Size.Height / 2 - altoBarraTitulo);
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            ucConsumo consumo = new ucConsumo();
            pnlPrincipal.Controls.Add(consumo);
            consumo.Location = new Point(ClientSize.Width / 2 - consumo.Size.Width / 2 - anchoBarraTitulo, ClientSize.Height / 2 - consumo.Size.Height / 2 - altoBarraTitulo);
        }

        private void aguaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            ucMedicion ucAgua = new ucMedicion("agua", db);
            pnlPrincipal.Controls.Add(ucAgua);
            ucAgua.Location = new Point(ClientSize.Width / 2 - ucAgua.Size.Width / 2 - anchoBarraTitulo, ClientSize.Height / 2 - ucAgua.Size.Height / 2 - altoBarraTitulo);

        }

        private void electricidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            ucMedicion ucElectricidad = new ucMedicion("electricidad", db);
            pnlPrincipal.Controls.Add(ucElectricidad);
            ucElectricidad.Location = new Point(ClientSize.Width / 2 - ucElectricidad.Size.Width / 2 - anchoBarraTitulo, ClientSize.Height / 2 - ucElectricidad.Size.Height / 2 - altoBarraTitulo);
        }

        private void gasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            ucMedicion ucGas = new ucMedicion("gas", db);
            pnlPrincipal.Controls.Add(ucGas);
            ucGas.Location = new Point(ClientSize.Width / 2 - ucGas.Size.Width / 2 - anchoBarraTitulo, ClientSize.Height / 2 - ucGas.Size.Height / 2 - altoBarraTitulo);
        }

        private void mensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlPrincipal.Controls.Clear();
            ucConsumoMensual ucconsumoMensual = new ucConsumoMensual();
            pnlPrincipal.Controls.Add(ucconsumoMensual);
            ucconsumoMensual.Location = new Point(ClientSize.Width / 2 - ucconsumoMensual.Size.Width / 2 - anchoBarraTitulo, ClientSize.Height / 2 - ucconsumoMensual.Size.Height / 2 - altoBarraTitulo);
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe frmAcerca = new frmAcercaDe();
            frmAcerca.ShowDialog(this);
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlPrincipal.Controls.Clear();
            this.pnlPrincipal.Controls.Add(new ucManual());
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory(); //"c:\\";
            openFileDialog1.Filter = "Archivo db (*.db)|*.db|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathDatabase = openFileDialog1.FileName;
                db = new LiteDatabase(pathDatabase);
                try
                {
                    db.GetCollection<Medicion>("medicionesAgua");
                }
                catch
                {
                    MessageBox.Show("El backup no fue cargado correctamente. Verifique el achivo.");
                    return;
                }
                MessageBox.Show("El backup fue cargado correctamente.");
                pnlPrincipal.Controls.Clear();
            }            
        }
    }
}
