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

        private void medicionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlPrincipal.Controls.Clear();
            this.pnlPrincipal.Controls.Add(new ucMedicion());
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlPrincipal.Controls.Clear();
            this.pnlPrincipal.Controls.Add(new ucConsumo());
        }
    }
}
