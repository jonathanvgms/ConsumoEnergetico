namespace ConsumoEnergetico.Mediciones
{
    partial class frmEditarMedicion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarMedicion));
            this.txtDetalleMedicion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.txtDatoMedicion = new System.Windows.Forms.TextBox();
            this.dtpFechaMedicion = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMedidor = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDetalleMedicion
            // 
            this.txtDetalleMedicion.Location = new System.Drawing.Point(464, 103);
            this.txtDetalleMedicion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDetalleMedicion.Multiline = true;
            this.txtDetalleMedicion.Name = "txtDetalleMedicion";
            this.txtDetalleMedicion.Size = new System.Drawing.Size(319, 78);
            this.txtDetalleMedicion.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Detalle";
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(320, 108);
            this.lblUnidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(31, 20);
            this.lblUnidad.TabIndex = 16;
            this.lblUnidad.Text = "M3";
            // 
            // txtDatoMedicion
            // 
            this.txtDatoMedicion.Location = new System.Drawing.Point(100, 103);
            this.txtDatoMedicion.Name = "txtDatoMedicion";
            this.txtDatoMedicion.Size = new System.Drawing.Size(210, 26);
            this.txtDatoMedicion.TabIndex = 21;
            // 
            // dtpFechaMedicion
            // 
            this.dtpFechaMedicion.Location = new System.Drawing.Point(464, 25);
            this.dtpFechaMedicion.Name = "dtpFechaMedicion";
            this.dtpFechaMedicion.Size = new System.Drawing.Size(319, 26);
            this.dtpFechaMedicion.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Consumo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Medidor";
            // 
            // cboMedidor
            // 
            this.cboMedidor.FormattingEnabled = true;
            this.cboMedidor.Location = new System.Drawing.Point(100, 23);
            this.cboMedidor.Name = "cboMedidor";
            this.cboMedidor.Size = new System.Drawing.Size(210, 28);
            this.cboMedidor.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(532, 192);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 38);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(664, 192);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 38);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmEditarMedicion
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(801, 248);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDetalleMedicion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.txtDatoMedicion);
            this.Controls.Add(this.dtpFechaMedicion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMedidor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditarMedicion";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Medición";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDetalleMedicion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.TextBox txtDatoMedicion;
        private System.Windows.Forms.DateTimePicker dtpFechaMedicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMedidor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}