namespace ConsumoEnergetico.Consumo
{
    partial class ucConsumoAnual
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConsumoTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalAgua = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalElectricidad = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotalGas = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvHistorialAnual = new System.Windows.Forms.DataGridView();
            this.lstAnios = new System.Windows.Forms.ListBox();
            this.chtConsumoAgua = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtConsumoElectricidad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtConsumoGas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalDineroAgua = new System.Windows.Forms.Label();
            this.lblTotalDineroElectricidad = new System.Windows.Forms.Label();
            this.lblTotalDineroGas = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialAnual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtConsumoAgua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtConsumoElectricidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtConsumoGas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar año";
            // 
            // lblConsumoTotal
            // 
            this.lblConsumoTotal.AutoSize = true;
            this.lblConsumoTotal.Location = new System.Drawing.Point(4, 22);
            this.lblConsumoTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConsumoTotal.Name = "lblConsumoTotal";
            this.lblConsumoTotal.Size = new System.Drawing.Size(78, 13);
            this.lblConsumoTotal.TabIndex = 3;
            this.lblConsumoTotal.Text = "Consumo Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "M3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Consumo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalDineroAgua);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTotalAgua);
            this.groupBox1.Controls.Add(this.lblConsumoTotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 148);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(201, 73);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agua";
            // 
            // lblTotalAgua
            // 
            this.lblTotalAgua.AutoSize = true;
            this.lblTotalAgua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAgua.Location = new System.Drawing.Point(97, 20);
            this.lblTotalAgua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalAgua.Name = "lblTotalAgua";
            this.lblTotalAgua.Size = new System.Drawing.Size(15, 15);
            this.lblTotalAgua.TabIndex = 9;
            this.lblTotalAgua.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalDineroElectricidad);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblTotalElectricidad);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(18, 234);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(201, 73);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Electricidad";
            // 
            // lblTotalElectricidad
            // 
            this.lblTotalElectricidad.AutoSize = true;
            this.lblTotalElectricidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalElectricidad.Location = new System.Drawing.Point(97, 20);
            this.lblTotalElectricidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalElectricidad.Name = "lblTotalElectricidad";
            this.lblTotalElectricidad.Size = new System.Drawing.Size(15, 15);
            this.lblTotalElectricidad.TabIndex = 14;
            this.lblTotalElectricidad.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Consumo Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Consumo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(165, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "KW";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotalDineroGas);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblTotalGas);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(18, 323);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(201, 73);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gas";
            // 
            // lblTotalGas
            // 
            this.lblTotalGas.AutoSize = true;
            this.lblTotalGas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGas.Location = new System.Drawing.Point(97, 20);
            this.lblTotalGas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalGas.Name = "lblTotalGas";
            this.lblTotalGas.Size = new System.Drawing.Size(15, 15);
            this.lblTotalGas.TabIndex = 15;
            this.lblTotalGas.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Consumo Total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 46);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Consumo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(165, 20);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 15);
            this.label14.TabIndex = 4;
            this.label14.Text = "M3";
            // 
            // dgvHistorialAnual
            // 
            this.dgvHistorialAnual.AllowUserToAddRows = false;
            this.dgvHistorialAnual.AllowUserToDeleteRows = false;
            this.dgvHistorialAnual.AllowUserToResizeColumns = false;
            this.dgvHistorialAnual.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialAnual.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistorialAnual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialAnual.Location = new System.Drawing.Point(270, 27);
            this.dgvHistorialAnual.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHistorialAnual.Name = "dgvHistorialAnual";
            this.dgvHistorialAnual.ReadOnly = true;
            this.dgvHistorialAnual.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialAnual.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHistorialAnual.RowTemplate.Height = 28;
            this.dgvHistorialAnual.Size = new System.Drawing.Size(862, 107);
            this.dgvHistorialAnual.TabIndex = 0;
            // 
            // lstAnios
            // 
            this.lstAnios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAnios.FormattingEnabled = true;
            this.lstAnios.ItemHeight = 15;
            this.lstAnios.Location = new System.Drawing.Point(18, 27);
            this.lstAnios.Margin = new System.Windows.Forms.Padding(2);
            this.lstAnios.Name = "lstAnios";
            this.lstAnios.Size = new System.Drawing.Size(201, 109);
            this.lstAnios.TabIndex = 12;
            this.lstAnios.SelectedIndexChanged += new System.EventHandler(this.SeleccionarAnio_IndexChanged);
            // 
            // chtConsumoAgua
            // 
            this.chtConsumoAgua.BorderlineColor = System.Drawing.Color.Black;
            chartArea4.Name = "ChartArea1";
            this.chtConsumoAgua.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chtConsumoAgua.Legends.Add(legend4);
            this.chtConsumoAgua.Location = new System.Drawing.Point(270, 148);
            this.chtConsumoAgua.Margin = new System.Windows.Forms.Padding(2);
            this.chtConsumoAgua.Name = "chtConsumoAgua";
            this.chtConsumoAgua.Size = new System.Drawing.Size(862, 121);
            this.chtConsumoAgua.TabIndex = 13;
            this.chtConsumoAgua.Text = "Consumo Agua";
            // 
            // chtConsumoElectricidad
            // 
            this.chtConsumoElectricidad.BorderlineColor = System.Drawing.Color.Black;
            chartArea5.Name = "ChartArea1";
            this.chtConsumoElectricidad.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chtConsumoElectricidad.Legends.Add(legend5);
            this.chtConsumoElectricidad.Location = new System.Drawing.Point(270, 279);
            this.chtConsumoElectricidad.Margin = new System.Windows.Forms.Padding(2);
            this.chtConsumoElectricidad.Name = "chtConsumoElectricidad";
            this.chtConsumoElectricidad.Size = new System.Drawing.Size(862, 121);
            this.chtConsumoElectricidad.TabIndex = 14;
            this.chtConsumoElectricidad.Text = "Consumo Agua";
            // 
            // chtConsumoGas
            // 
            this.chtConsumoGas.BorderlineColor = System.Drawing.Color.Black;
            chartArea6.Name = "ChartArea1";
            this.chtConsumoGas.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chtConsumoGas.Legends.Add(legend6);
            this.chtConsumoGas.Location = new System.Drawing.Point(270, 409);
            this.chtConsumoGas.Margin = new System.Windows.Forms.Padding(2);
            this.chtConsumoGas.Name = "chtConsumoGas";
            this.chtConsumoGas.Size = new System.Drawing.Size(862, 121);
            this.chtConsumoGas.TabIndex = 15;
            this.chtConsumoGas.Text = "Consumo Agua";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "$";
            // 
            // lblTotalDineroAgua
            // 
            this.lblTotalDineroAgua.AutoSize = true;
            this.lblTotalDineroAgua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDineroAgua.Location = new System.Drawing.Point(118, 44);
            this.lblTotalDineroAgua.Name = "lblTotalDineroAgua";
            this.lblTotalDineroAgua.Size = new System.Drawing.Size(15, 15);
            this.lblTotalDineroAgua.TabIndex = 11;
            this.lblTotalDineroAgua.Text = "0";
            // 
            // lblTotalDineroElectricidad
            // 
            this.lblTotalDineroElectricidad.AutoSize = true;
            this.lblTotalDineroElectricidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDineroElectricidad.Location = new System.Drawing.Point(118, 44);
            this.lblTotalDineroElectricidad.Name = "lblTotalDineroElectricidad";
            this.lblTotalDineroElectricidad.Size = new System.Drawing.Size(15, 15);
            this.lblTotalDineroElectricidad.TabIndex = 12;
            this.lblTotalDineroElectricidad.Text = "0";
            // 
            // lblTotalDineroGas
            // 
            this.lblTotalDineroGas.AutoSize = true;
            this.lblTotalDineroGas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDineroGas.Location = new System.Drawing.Point(118, 44);
            this.lblTotalDineroGas.Name = "lblTotalDineroGas";
            this.lblTotalDineroGas.Size = new System.Drawing.Size(15, 15);
            this.lblTotalDineroGas.TabIndex = 16;
            this.lblTotalDineroGas.Text = "0";
            // 
            // ucConsumoAnual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chtConsumoGas);
            this.Controls.Add(this.chtConsumoElectricidad);
            this.Controls.Add(this.dgvHistorialAnual);
            this.Controls.Add(this.chtConsumoAgua);
            this.Controls.Add(this.lstAnios);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucConsumoAnual";
            this.Size = new System.Drawing.Size(1150, 650);
            this.Load += new System.EventHandler(this.ucConsumo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialAnual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtConsumoAgua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtConsumoElectricidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtConsumoGas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConsumoTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvHistorialAnual;
        private System.Windows.Forms.ListBox lstAnios;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtConsumoAgua;
        private System.Windows.Forms.Label lblTotalAgua;
        private System.Windows.Forms.Label lblTotalElectricidad;
        private System.Windows.Forms.Label lblTotalGas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtConsumoElectricidad;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtConsumoGas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalDineroAgua;
        private System.Windows.Forms.Label lblTotalDineroElectricidad;
        private System.Windows.Forms.Label lblTotalDineroGas;
    }
}
