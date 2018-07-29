namespace ConsumoEnergetico.Consumo
{
    partial class ucConsumoMensual
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalGas = new System.Windows.Forms.Label();
            this.lblTotalDineroGas = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalElectricidad = new System.Windows.Forms.Label();
            this.lblTotalDineroElectricidad = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalAgua = new System.Windows.Forms.Label();
            this.lblTotalDineroAgua = new System.Windows.Forms.Label();
            this.lblConsumoTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaComienzo = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chtConsumoGas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtConsumoElectricidad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtConsumoAgua = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtConsumoGas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtConsumoElectricidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtConsumoAgua)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblTotalGas);
            this.groupBox3.Controls.Add(this.lblTotalDineroGas);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(19, 412);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(209, 96);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "$";
            // 
            // lblTotalGas
            // 
            this.lblTotalGas.AutoSize = true;
            this.lblTotalGas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGas.Location = new System.Drawing.Point(107, 29);
            this.lblTotalGas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalGas.Name = "lblTotalGas";
            this.lblTotalGas.Size = new System.Drawing.Size(15, 15);
            this.lblTotalGas.TabIndex = 11;
            this.lblTotalGas.Text = "0";
            // 
            // lblTotalDineroGas
            // 
            this.lblTotalDineroGas.AutoSize = true;
            this.lblTotalDineroGas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDineroGas.Location = new System.Drawing.Point(123, 55);
            this.lblTotalDineroGas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalDineroGas.Name = "lblTotalDineroGas";
            this.lblTotalDineroGas.Size = new System.Drawing.Size(15, 15);
            this.lblTotalDineroGas.TabIndex = 8;
            this.lblTotalDineroGas.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 31);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Consumo Total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 57);
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
            this.label14.Location = new System.Drawing.Point(161, 29);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 15);
            this.label14.TabIndex = 4;
            this.label14.Text = "M3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblTotalElectricidad);
            this.groupBox2.Controls.Add(this.lblTotalDineroElectricidad);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(19, 295);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(209, 96);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Electricidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "$";
            // 
            // lblTotalElectricidad
            // 
            this.lblTotalElectricidad.AutoSize = true;
            this.lblTotalElectricidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalElectricidad.Location = new System.Drawing.Point(110, 29);
            this.lblTotalElectricidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalElectricidad.Name = "lblTotalElectricidad";
            this.lblTotalElectricidad.Size = new System.Drawing.Size(15, 15);
            this.lblTotalElectricidad.TabIndex = 10;
            this.lblTotalElectricidad.Text = "0";
            // 
            // lblTotalDineroElectricidad
            // 
            this.lblTotalDineroElectricidad.AutoSize = true;
            this.lblTotalDineroElectricidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDineroElectricidad.Location = new System.Drawing.Point(127, 55);
            this.lblTotalDineroElectricidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalDineroElectricidad.Name = "lblTotalDineroElectricidad";
            this.lblTotalDineroElectricidad.Size = new System.Drawing.Size(15, 15);
            this.lblTotalDineroElectricidad.TabIndex = 8;
            this.lblTotalDineroElectricidad.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Consumo Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 57);
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
            this.label9.Location = new System.Drawing.Point(159, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "KW";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTotalAgua);
            this.groupBox1.Controls.Add(this.lblTotalDineroAgua);
            this.groupBox1.Controls.Add(this.lblConsumoTotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(19, 181);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(209, 96);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agua";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "$";
            // 
            // lblTotalAgua
            // 
            this.lblTotalAgua.AutoSize = true;
            this.lblTotalAgua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAgua.Location = new System.Drawing.Point(109, 29);
            this.lblTotalAgua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalAgua.Name = "lblTotalAgua";
            this.lblTotalAgua.Size = new System.Drawing.Size(15, 15);
            this.lblTotalAgua.TabIndex = 9;
            this.lblTotalAgua.Text = "0";
            // 
            // lblTotalDineroAgua
            // 
            this.lblTotalDineroAgua.AutoSize = true;
            this.lblTotalDineroAgua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDineroAgua.Location = new System.Drawing.Point(128, 55);
            this.lblTotalDineroAgua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalDineroAgua.Name = "lblTotalDineroAgua";
            this.lblTotalDineroAgua.Size = new System.Drawing.Size(15, 15);
            this.lblTotalDineroAgua.TabIndex = 8;
            this.lblTotalDineroAgua.Text = "0";
            // 
            // lblConsumoTotal
            // 
            this.lblConsumoTotal.AutoSize = true;
            this.lblConsumoTotal.Location = new System.Drawing.Point(16, 31);
            this.lblConsumoTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConsumoTotal.Name = "lblConsumoTotal";
            this.lblConsumoTotal.Size = new System.Drawing.Size(78, 13);
            this.lblConsumoTotal.TabIndex = 3;
            this.lblConsumoTotal.Text = "Consumo Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Consumo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "M3";
            // 
            // dtpFechaComienzo
            // 
            this.dtpFechaComienzo.Location = new System.Drawing.Point(19, 56);
            this.dtpFechaComienzo.Name = "dtpFechaComienzo";
            this.dtpFechaComienzo.Size = new System.Drawing.Size(209, 20);
            this.dtpFechaComienzo.TabIndex = 16;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(19, 106);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(209, 20);
            this.dtpFechaFin.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fecha Comienzo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Fecha Finalización";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(153, 143);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chtConsumoGas
            // 
            this.chtConsumoGas.BorderlineColor = System.Drawing.Color.Black;
            this.chtConsumoGas.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.Name = "ChartArea1";
            this.chtConsumoGas.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chtConsumoGas.Legends.Add(legend4);
            this.chtConsumoGas.Location = new System.Drawing.Point(271, 340);
            this.chtConsumoGas.Margin = new System.Windows.Forms.Padding(2);
            this.chtConsumoGas.Name = "chtConsumoGas";
            this.chtConsumoGas.Size = new System.Drawing.Size(1078, 121);
            this.chtConsumoGas.TabIndex = 23;
            this.chtConsumoGas.Text = "Consumo Agua";
            // 
            // chtConsumoElectricidad
            // 
            this.chtConsumoElectricidad.BorderlineColor = System.Drawing.Color.Black;
            this.chtConsumoElectricidad.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea5.Name = "ChartArea1";
            this.chtConsumoElectricidad.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chtConsumoElectricidad.Legends.Add(legend5);
            this.chtConsumoElectricidad.Location = new System.Drawing.Point(271, 197);
            this.chtConsumoElectricidad.Margin = new System.Windows.Forms.Padding(2);
            this.chtConsumoElectricidad.Name = "chtConsumoElectricidad";
            this.chtConsumoElectricidad.Size = new System.Drawing.Size(1078, 121);
            this.chtConsumoElectricidad.TabIndex = 22;
            this.chtConsumoElectricidad.Text = "Consumo Agua";
            // 
            // chtConsumoAgua
            // 
            this.chtConsumoAgua.BorderlineColor = System.Drawing.Color.Black;
            this.chtConsumoAgua.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea6.Name = "ChartArea1";
            this.chtConsumoAgua.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chtConsumoAgua.Legends.Add(legend6);
            this.chtConsumoAgua.Location = new System.Drawing.Point(271, 56);
            this.chtConsumoAgua.Margin = new System.Windows.Forms.Padding(2);
            this.chtConsumoAgua.Name = "chtConsumoAgua";
            this.chtConsumoAgua.Size = new System.Drawing.Size(1078, 121);
            this.chtConsumoAgua.TabIndex = 21;
            this.chtConsumoAgua.Text = "Consumo Agua";
            // 
            // ucConsumoMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chtConsumoGas);
            this.Controls.Add(this.chtConsumoElectricidad);
            this.Controls.Add(this.chtConsumoAgua);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaComienzo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucConsumoMensual";
            this.Size = new System.Drawing.Size(1366, 650);
            this.Load += new System.EventHandler(this.ucConsumoMensual_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtConsumoGas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtConsumoElectricidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtConsumoAgua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTotalDineroGas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotalDineroElectricidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalDineroAgua;
        private System.Windows.Forms.Label lblConsumoTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaComienzo;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblTotalGas;
        private System.Windows.Forms.Label lblTotalElectricidad;
        private System.Windows.Forms.Label lblTotalAgua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtConsumoGas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtConsumoElectricidad;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtConsumoAgua;
    }
}
