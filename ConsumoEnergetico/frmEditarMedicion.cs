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
    public partial class frmEditarMedicion : Form
    {
        private LiteCollection<Medicion> medicionesAgua;
        private Medicion medicion;
        private LiteDatabase db;
        private string indicador = String.Empty;

        public frmEditarMedicion()
        {
            InitializeComponent();
        }

        public frmEditarMedicion(string indicador, LiteDatabase db, LiteCollection<Medicion> medicionesAgua, Medicion medicion)
        {
            InitializeComponent();
            this.indicador = indicador;
            this.medicionesAgua = medicionesAgua;
            this.medicion = medicion;
            this.db = db;

            CargarMedicion();
        }

        private void CargarMedicion()
        {
            txtDetalleMedicion.Text = medicion.Detalle;
            txtDatoMedicion.Text = medicion.Dato.ToString();
            dtpFechaMedicion.Value = medicion.Fecha;

            var strMedidores = UtilGui.GetStrMedidores(indicador);

            var medidores = db.GetCollection<Medidor>(strMedidores);
            cboMedidor.Items.Clear();
            medidores.FindAll().ToList().ForEach(x => cboMedidor.Items.Add(x));
            cboMedidor.DisplayMember = "Codigo";
            //var medidorEdit = medidores.FindOne(x => x.Id == medicion.Medidor.Id);
            //cboMedidor.SelectedValue = db.GetCollection<Medidor>(strMedidores).FindById(medicion.Medidor.Id);
            //cboMedidor.SelectedIndex = cboMedidor.Items.IndexOf(medidores.FindById(medicion.Medidor.Id));
            //MessageBox.Show(medidores.FindById(medicion.Medidor.Id).Codigo.ToString());
            //cboMedidor.SelectedIndex = cboMedidor.Items.IndexOf(medidorEdit);
        }

        //private string GetMedidores(string indicador)
        //{
        //    if (indicador == "agua")
        //        return "medidoresAgua";

        //    if (indicador == "gas")
        //        return "medidoresGas";

        //    if (indicador == "electricidad")
        //        return "medidoresElectricidad";

        //    return String.Empty;
        //}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDatoMedicion.Text) && cboMedidor.SelectedIndex < 0)
            {
                MessageBox.Show("El campo 'Medidior' esta vacio y el campo 'Consumo' esta vacio. Intente de nuevo");
                return;
            }
            else
            {
                if (cboMedidor.SelectedIndex < 0)
                {
                    MessageBox.Show("El campo 'Medidor' es invalido. Intente de nuevo");
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtDatoMedicion.Text))
                    {
                        MessageBox.Show("El campo 'Consumo' esta vacio");
                        return;
                    }
                }
            }

            medicion.Medidor = (Medidor)cboMedidor.SelectedItem;
            medicion.Dato = Convert.ToDouble(txtDatoMedicion.Text);
            medicion.Fecha = dtpFechaMedicion.Value;
            medicion.Detalle = txtDetalleMedicion.Text;
            medicionesAgua.Update(medicion);
            Close();
        }
    }
}
