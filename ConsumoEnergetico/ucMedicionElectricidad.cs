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
    public partial class ucMedicionElectricidad : UserControl
    {
        public ucMedicionElectricidad()
        {
            InitializeComponent();
        }

        private void btnNuevoMedidor_Click(object sender, EventArgs e)
        {
            frmMedidor medidorElectricidad = new frmMedidor();
            medidorElectricidad.ShowDialog(this);
        }
    }
}
