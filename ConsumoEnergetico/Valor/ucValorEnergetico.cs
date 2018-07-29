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
    public partial class ucValorEnergetico : UserControl
    {
        private string indicador;
        private LiteDatabase db;

        public ucValorEnergetico()
        {
            InitializeComponent();
        }

        public ucValorEnergetico(string indicador, LiteDatabase db)
        {
            this.indicador = indicador;
            this.db = db;
            InitializeComponent();
            lblNombreEje.Text = UtilGui.FormatIndicador(indicador);
            lblUnidadValor.Text = GetUnidadCobro();
            switch (indicador)
            {
                case "agua":
                    {
                        //groupBox1.BackColor = Color.LightBlue;
                        this.BackColor = Color.AliceBlue;
                        break;
                    }
                case "electricidad":
                    this.BackColor = Color.LightPink;
                    break;
                case "gas":
                    this.BackColor = Color.LightYellow;
                    break;
            }
            LimpiarControlesCostos();
            ActualizarHistorialCostos();
        }

        private string GetUnidadCobro()
        {
            return indicador.Equals("electricidad") ? string.Format("$ / {0}H", UtilGui.GetUnidad(indicador)) : string.Format("$ / {0}", UtilGui.GetUnidad(indicador));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var costos = db.GetCollection<Costo>(UtilGui.GetStrCostos(indicador));

            if (!ValidarCosto())
            {
                return;
            }

            double valor = 0;
            double.TryParse(txtCosto.Text, out valor);

                costos.Insert(new Costo
            {
                Valor = valor,
                Fecha = dtpFechaCosto.Value
            });

            LimpiarControlesCostos();
            ActualizarHistorialCostos();
        }

        private bool ValidarCosto()
        {
            if (string.IsNullOrEmpty(txtCosto.Text))
            {
                MessageBox.Show("El campo 'Costo' es invalido");
                return false;
            }

            double valor = 0;

            if (!double.TryParse(txtCosto.Text, out valor))
            {
                MessageBox.Show("El campo 'Costo' es invalido");
                return false;
            }

            return true;
        }

        private void ActualizarHistorialCostos()
        {
            var costos = db.GetCollection<Costo>(UtilGui.GetStrCostos(indicador));
            dgvHistorial.Columns.Clear();
            if (costos.Count() != 0)
            {
                BindingSource source = new BindingSource();
                source.DataSource = from m in costos.FindAll()
                                    select new { m.Id, m.Fecha, m.Valor, Unidad = GetUnidadCobro() };
                dgvHistorial.DataSource = source;
                var columnEditar = new DataGridViewButtonColumn();
                var columnBorrar = new DataGridViewButtonColumn();
                columnEditar.Name = "Editar";
                columnEditar.Text = "Editar";
                columnEditar.UseColumnTextForButtonValue = true;
                dgvHistorial.Columns.Add(columnEditar);
                columnBorrar.Name = "Borrar";
                columnBorrar.Text = "Borrar";
                columnBorrar.UseColumnTextForButtonValue = true;
                dgvHistorial.Columns.Add(columnBorrar);

                dgvHistorial.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dgvHistorial.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvHistorial.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvHistorial.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void LimpiarControlesCostos()
        {
            txtCosto.Clear();
            dtpFechaCosto.ResetText();
        }

        private void dgvHistoriaValor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvHistorial.Columns["Borrar"].Index)
            {
                var confirmResult = MessageBox.Show("¿Desea descartar este valor?", "Descartar valor", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var valores = db.GetCollection<Medicion>(UtilGui.GetStrCostos(indicador));
                    int Id = int.Parse(dgvHistorial.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    valores.Delete(x => x.Id == Id);
                }
            }

            if (e.ColumnIndex == dgvHistorial.Columns["Editar"].Index)
            {
                var valores = db.GetCollection<Costo>(UtilGui.GetStrCostos(indicador));
                int Id = int.Parse(dgvHistorial.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                var costo = valores.FindOne(x => x.Id == Id);

                frmEditarValor editarMedicionAgua = new frmEditarValor(indicador, db, valores, costo);
                editarMedicionAgua.ShowDialog(this);
            }
            ActualizarHistorialCostos();
        }
    }
}
