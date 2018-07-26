namespace ConsumoEnergetico
{
    partial class ucConsumo
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConsumoTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalAgua = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalElectricidad = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotalGas = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvHistorialAnual = new System.Windows.Forms.DataGridView();
            this.lstAnios = new System.Windows.Forms.ListBox();
            this.chtConsumo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialAnual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtConsumo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar año";
            // 
            // lblConsumoTotal
            // 
            this.lblConsumoTotal.AutoSize = true;
            this.lblConsumoTotal.Location = new System.Drawing.Point(6, 34);
            this.lblConsumoTotal.Name = "lblConsumoTotal";
            this.lblConsumoTotal.Size = new System.Drawing.Size(116, 20);
            this.lblConsumoTotal.TabIndex = 3;
            this.lblConsumoTotal.Text = "Consumo Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "M3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Consumo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "$ valor ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalAgua);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblConsumoTotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(334, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 113);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agua";
            // 
            // lblTotalAgua
            // 
            this.lblTotalAgua.AutoSize = true;
            this.lblTotalAgua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAgua.Location = new System.Drawing.Point(146, 32);
            this.lblTotalAgua.Name = "lblTotalAgua";
            this.lblTotalAgua.Size = new System.Drawing.Size(21, 22);
            this.lblTotalAgua.TabIndex = 9;
            this.lblTotalAgua.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalElectricidad);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(678, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 113);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Electricidad";
            // 
            // lblTotalElectricidad
            // 
            this.lblTotalElectricidad.AutoSize = true;
            this.lblTotalElectricidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalElectricidad.Location = new System.Drawing.Point(170, 32);
            this.lblTotalElectricidad.Name = "lblTotalElectricidad";
            this.lblTotalElectricidad.Size = new System.Drawing.Size(21, 22);
            this.lblTotalElectricidad.TabIndex = 14;
            this.lblTotalElectricidad.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(170, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "$ valor ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Consumo Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Consumo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(244, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "KW";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotalGas);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(1018, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 113);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gas";
            // 
            // lblTotalGas
            // 
            this.lblTotalGas.AutoSize = true;
            this.lblTotalGas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGas.Location = new System.Drawing.Point(158, 32);
            this.lblTotalGas.Name = "lblTotalGas";
            this.lblTotalGas.Size = new System.Drawing.Size(21, 22);
            this.lblTotalGas.TabIndex = 15;
            this.lblTotalGas.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(158, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 22);
            this.label11.TabIndex = 8;
            this.label11.Text = "$ valor ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Consumo Total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Consumo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(247, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 22);
            this.label14.TabIndex = 4;
            this.label14.Text = "M3";
            // 
            // dgvHistorialAnual
            // 
            this.dgvHistorialAnual.AllowUserToAddRows = false;
            this.dgvHistorialAnual.AllowUserToDeleteRows = false;
            this.dgvHistorialAnual.AllowUserToResizeColumns = false;
            this.dgvHistorialAnual.AllowUserToResizeRows = false;
            this.dgvHistorialAnual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialAnual.Location = new System.Drawing.Point(27, 186);
            this.dgvHistorialAnual.Name = "dgvHistorialAnual";
            this.dgvHistorialAnual.ReadOnly = true;
            this.dgvHistorialAnual.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialAnual.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorialAnual.RowTemplate.Height = 28;
            this.dgvHistorialAnual.Size = new System.Drawing.Size(1293, 165);
            this.dgvHistorialAnual.TabIndex = 0;
            // 
            // lstAnios
            // 
            this.lstAnios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAnios.FormattingEnabled = true;
            this.lstAnios.ItemHeight = 22;
            this.lstAnios.Location = new System.Drawing.Point(27, 42);
            this.lstAnios.Name = "lstAnios";
            this.lstAnios.Size = new System.Drawing.Size(271, 114);
            this.lstAnios.TabIndex = 12;
            this.lstAnios.SelectedIndexChanged += new System.EventHandler(this.SeleccionarAnio_IndexChanged);
            // 
            // chtConsumo
            // 
            this.chtConsumo.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chtConsumo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtConsumo.Legends.Add(legend1);
            this.chtConsumo.Location = new System.Drawing.Point(27, 370);
            this.chtConsumo.Name = "chtConsumo";
            this.chtConsumo.Size = new System.Drawing.Size(1293, 269);
            this.chtConsumo.TabIndex = 13;
            this.chtConsumo.Text = "Consumo Agua";
            // 
            // ucConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvHistorialAnual);
            this.Controls.Add(this.chtConsumo);
            this.Controls.Add(this.lstAnios);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ucConsumo";
            this.Size = new System.Drawing.Size(1346, 671);
            this.Load += new System.EventHandler(this.ucConsumo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialAnual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtConsumo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConsumoTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvHistorialAnual;
        private System.Windows.Forms.ListBox lstAnios;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtConsumo;
        private System.Windows.Forms.Label lblTotalAgua;
        private System.Windows.Forms.Label lblTotalElectricidad;
        private System.Windows.Forms.Label lblTotalGas;
    }
}
