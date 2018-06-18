using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoEnergetico
{
    public partial class frnInicial : Form
    {
        public frnInicial()
        {
            InitializeComponent();
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlPrincipal.Controls.Clear();
            this.pnlPrincipal.Controls.Add(new ucConsumo());
        }

        private void aguaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlPrincipal.Controls.Clear();
            this.pnlPrincipal.Controls.Add(new ucMedicionAgua());
        }

        private void electricidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlPrincipal.Controls.Clear();
            this.pnlPrincipal.Controls.Add(new ucMedicionElectricidad());
        }

        private void gasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlPrincipal.Controls.Clear();
            this.pnlPrincipal.Controls.Add(new ucMedicionGas());
        }
    }
}
