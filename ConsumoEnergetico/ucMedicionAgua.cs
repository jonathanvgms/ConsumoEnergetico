using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoEnergetico
{
    public partial class ucMedicionAgua : UserControl
    {
        public ucMedicionAgua()
        {
            InitializeComponent();
        }

        private void btnNuevoMedidor_Click(object sender, EventArgs e)
        {
            frmMedidor medidorAgua = new frmMedidor();
            medidorAgua.ShowDialog(this);
        }
    }
}
