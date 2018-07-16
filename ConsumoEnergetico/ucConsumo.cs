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
    public partial class ucConsumo : UserControl
    {
        public ucConsumo()
        {
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
        }
    }
}
