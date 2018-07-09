using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;
using ConsumoEnergetico.Biblioteca;

namespace ConsumoEnergetico
{
    public partial class ucMedicion : UserControl
    {
        private LiteDatabase db;
        private string indicador = String.Empty;

        public ucMedicion(string indicador, LiteDatabase db)
        {
            InitializeComponent();
            this.db = db;
            this.indicador = indicador;
            UtilGui.ActualizarMedidores(indicador, db, this.cboMedidor);
            this.lblUnidad.Text = UtilGui.GetUnidad(indicador);
            ActualizarHistorialMediciones();
        }

        private void btnNuevoMedidor_Click(object sender, EventArgs e)
        {
            frmMedidor medidorAgua = new frmMedidor(db, indicador);
            medidorAgua.ShowDialog(this);
            UtilGui.ActualizarMedidores(indicador, db, this.cboMedidor);
        }

        private void ActualizarDescripcionMedidor(object sender, EventArgs e)
        {
            lblDescripcionMedidor.Text =  cboMedidor.SelectedItem != null ? ((Medidor)cboMedidor.SelectedItem).Descripcion : String.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var mediciones = db.GetCollection<Medicion>(UtilGui.GetStrMediciones(indicador));

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

            mediciones.Insert(new Medicion
            {
                Medidor = (Medidor)cboMedidor.SelectedItem,
                Dato = Convert.ToDouble(txtDatoMedicion.Text),
                Fecha = dtpFechaMedicion.Value,
                Detalle = txtDetalleMedicion.Text
            });

            LimpiarControlesMedicion();
            ActualizarHistorialMediciones();
        }

        private void ActualizarHistorialMediciones()
        {
            var mediciones = db.GetCollection<Medicion>(UtilGui.GetStrMediciones(indicador));
            dgvHistorialAgua.Columns.Clear();
            if (mediciones.Count() != 0)
            {
                BindingSource source = new BindingSource();
                source.DataSource = from m in mediciones.FindAll()
                                    select new { m.Id, m.Fecha, Medidor = m.Medidor.Codigo, m.Dato, Unidad = lblUnidad.Text, m.Detalle };
                dgvHistorialAgua.DataSource = source;
                var columnEditar = new DataGridViewButtonColumn();
                var columnBorrar = new DataGridViewButtonColumn();
                columnEditar.Name = "Editar";
                columnEditar.Text = "Editar";
                columnEditar.UseColumnTextForButtonValue = true;
                dgvHistorialAgua.Columns.Add(columnEditar);
                columnBorrar.Name = "Borrar";
                columnBorrar.Text = "Borrar";
                columnBorrar.UseColumnTextForButtonValue = true;
                dgvHistorialAgua.Columns.Add(columnBorrar);

                dgvHistorialAgua.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dgvHistorialAgua.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvHistorialAgua.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvHistorialAgua.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvHistorialAgua.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvHistorialAgua.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            //dgvHistorialAgua.ClearSelection();
        }

        private void LimpiarControlesMedicion()
        {
            cboMedidor.SelectedIndex = -1;
            txtDatoMedicion.Clear();
            txtDetalleMedicion.Clear();
            dtpFechaMedicion.Value = DateTime.Now;
        }

        private void dvgHistorialAgua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvHistorialAgua.Columns["Borrar"].Index)
            {
                var confirmResult = MessageBox.Show("¿Desea descartar esta medición?", "Descartar medición", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var medicionesAgua = db.GetCollection<Medicion>("medicionesAgua");
                    int IdMedicion = int.Parse(dgvHistorialAgua.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    medicionesAgua.Delete(x => x.Id == IdMedicion);
                }
            }

            if (e.ColumnIndex == dgvHistorialAgua.Columns["Editar"].Index)
            {
                var mediciones = db.GetCollection<Medicion>(UtilGui.GetStrMediciones(indicador));
                int IdMedicion = int.Parse(dgvHistorialAgua.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                var medicion = mediciones.FindOne(x => x.Id == IdMedicion);

                frmEditarMedicion editarMedicionAgua = new frmEditarMedicion(indicador, db, mediciones, medicion);
                editarMedicionAgua.ShowDialog(this);
            }
            ActualizarHistorialMediciones();
        }
    }
}
