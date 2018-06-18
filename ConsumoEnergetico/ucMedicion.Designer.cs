namespace ConsumoEnergetico
{
    partial class ucMedicion
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
            this.cboIndicador = new System.Windows.Forms.ComboBox();
            this.cboMedidor = new System.Windows.Forms.ComboBox();
            this.btnNuevoMedidor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIndicador = new System.Windows.Forms.Label();
            this.lblDescripcionMedidor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtDatoMedicion = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboIndicador
            // 
            this.cboIndicador.FormattingEnabled = true;
            this.cboIndicador.Location = new System.Drawing.Point(136, 57);
            this.cboIndicador.Name = "cboIndicador";
            this.cboIndicador.Size = new System.Drawing.Size(210, 28);
            this.cboIndicador.TabIndex = 0;
            // 
            // cboMedidor
            // 
            this.cboMedidor.FormattingEnabled = true;
            this.cboMedidor.Location = new System.Drawing.Point(529, 57);
            this.cboMedidor.Name = "cboMedidor";
            this.cboMedidor.Size = new System.Drawing.Size(210, 28);
            this.cboMedidor.TabIndex = 1;
            // 
            // btnNuevoMedidor
            // 
            this.btnNuevoMedidor.Location = new System.Drawing.Point(775, 49);
            this.btnNuevoMedidor.Name = "btnNuevoMedidor";
            this.btnNuevoMedidor.Size = new System.Drawing.Size(160, 43);
            this.btnNuevoMedidor.TabIndex = 2;
            this.btnNuevoMedidor.Text = "Agregar Medidor";
            this.btnNuevoMedidor.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1143, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDatoMedicion);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblDescripcionMedidor);
            this.groupBox1.Controls.Add(this.lblIndicador);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cboIndicador);
            this.groupBox1.Controls.Add(this.btnNuevoMedidor);
            this.groupBox1.Controls.Add(this.cboMedidor);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1316, 214);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva Medición";
            // 
            // lblIndicador
            // 
            this.lblIndicador.AutoSize = true;
            this.lblIndicador.Location = new System.Drawing.Point(43, 60);
            this.lblIndicador.Name = "lblIndicador";
            this.lblIndicador.Size = new System.Drawing.Size(75, 20);
            this.lblIndicador.TabIndex = 4;
            this.lblIndicador.Text = "Indicador";
            // 
            // lblDescripcionMedidor
            // 
            this.lblDescripcionMedidor.AutoSize = true;
            this.lblDescripcionMedidor.Location = new System.Drawing.Point(525, 103);
            this.lblDescripcionMedidor.Name = "lblDescripcionMedidor";
            this.lblDescripcionMedidor.Size = new System.Drawing.Size(92, 20);
            this.lblDescripcionMedidor.TabIndex = 5;
            this.lblDescripcionMedidor.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Medidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Consumo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(529, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(328, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // txtDatoMedicion
            // 
            this.txtDatoMedicion.Location = new System.Drawing.Point(136, 159);
            this.txtDatoMedicion.Name = "txtDatoMedicion";
            this.txtDatoMedicion.Size = new System.Drawing.Size(210, 26);
            this.txtDatoMedicion.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(14, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1316, 390);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historial";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1272, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // ucMedicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucMedicion";
            this.Size = new System.Drawing.Size(1345, 671);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDatoMedicion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescripcionMedidor;
        private System.Windows.Forms.Label lblIndicador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboIndicador;
        private System.Windows.Forms.Button btnNuevoMedidor;
        private System.Windows.Forms.ComboBox cboMedidor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
