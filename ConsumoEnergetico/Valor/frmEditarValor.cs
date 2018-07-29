using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsumoEnergetico.Biblioteca;
using LiteDB;

namespace ConsumoEnergetico
{
    public partial class frmEditarValor : Form
    {
        private LiteCollection<Costo> costos;
        private Costo costo;
        private LiteDatabase db;
        private string indicador = String.Empty;

        public frmEditarValor()
        {
            InitializeComponent();
        }

        public frmEditarValor(string indicador, LiteDatabase db, LiteCollection<Costo> costos , Costo costo)
        {
            InitializeComponent();
            this.indicador = indicador;
            this.costos = costos;
            this.costo = costo;
            this.db = db;

            CargarValor();
        }

        private void CargarValor()
        {
            txtDatoMedicion.Text = costo.Valor.ToString();
            dtpFechaMedicion.Value = costo.Fecha;
            lblUnidad.Text = GetUnidadCobro();
        }

        private string GetUnidadCobro()
        {
            return indicador.Equals("electricidad") ? string.Format("$ / {0}H", UtilGui.GetUnidad(indicador)) : string.Format("$ / {0}", UtilGui.GetUnidad(indicador));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDatoMedicion.Text))
            {
                MessageBox.Show("El campo 'Valor' esta vacio Intente de nuevo");
                return;
            }

            costo.Valor = Convert.ToDouble(txtDatoMedicion.Text);
            costo.Fecha = dtpFechaMedicion.Value;
            costos.Update(costo);
            Close();
        }
    }
}
