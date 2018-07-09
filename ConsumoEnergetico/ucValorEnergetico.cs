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
            this.lblNombreEje.Text = indicador;
            this.lblUnidadValor.Text = GetUnidadCobro();
            LimpiarControlesCostos();
            ActualizarHistorialCostos();
        }

        private string GetUnidadCobro()
        {
            return indicador.Equals("electricidad") ? string.Format("$/{0}H", UtilGui.GetUnidad(indicador)) : string.Format("$/{0}", UtilGui.GetUnidad(indicador));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var costos = db.GetCollection<Costo>(UtilGui.GetStrCostos(indicador));

            if (!ValidarCosto())
            {
                return;
            }

            costos.Insert(new Costo
            {
                Valor = Convert.ToDouble(txtCosto.Text),
                Fecha = dtpFechaCosto.Value
            });

            LimpiarControlesCostos();
            ActualizarHistorialCostos();
        }

        private bool ValidarCosto()
        {
            if (string.IsNullOrEmpty(txtCosto.Text))
            {
                MessageBox.Show("Verifique el costo de indicador.");
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
    }
}
