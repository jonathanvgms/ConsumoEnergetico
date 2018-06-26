using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;
using ConsumoEnergetico.Biblioteca;

namespace ConsumoEnergetico
{
    public partial class frmMedidor : Form
    {
        private string indicador;
        private LiteDatabase db;

        public frmMedidor(LiteDatabase db, string indicador)
        {
            InitializeComponent();
            this.indicador = indicador;
            this.db = db;
        }

        private void btnGuardarMedidor_Click(object sender, EventArgs e)
        {
            if(Util.cadenaVacia(txtCodigo.Text))
            {
                MessageBox.Show("El código es invalido. Ingrese uno nuevo.");
                return;
            }

            var medidoresAgua = db.GetCollection<Medidor>(UtilGui.GetStrMedidores(indicador));
            medidoresAgua.Insert(new Medidor
            {
                Codigo = txtCodigo.Text,
                Descripcion = txtDescripcion.Text
            });
            Close();
        }
    }
}
