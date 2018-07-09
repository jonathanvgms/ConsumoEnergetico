namespace ConsumoEnergetico
{
    partial class frnInicial
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frnInicial));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aguaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.electricidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aguaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.electricidadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.picPortada = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.medicionToolStripMenuItem,
            this.resultadosToolStripMenuItem,
            this.valorToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirToolStripMenuItem.Text = "Importar";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // medicionToolStripMenuItem
            // 
            this.medicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aguaToolStripMenuItem,
            this.electricidadToolStripMenuItem,
            this.gasToolStripMenuItem});
            this.medicionToolStripMenuItem.Name = "medicionToolStripMenuItem";
            this.medicionToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.medicionToolStripMenuItem.Text = "Medicion";
            // 
            // aguaToolStripMenuItem
            // 
            this.aguaToolStripMenuItem.Name = "aguaToolStripMenuItem";
            this.aguaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aguaToolStripMenuItem.Text = "Agua";
            this.aguaToolStripMenuItem.Click += new System.EventHandler(this.aguaToolStripMenuItem_Click);
            // 
            // electricidadToolStripMenuItem
            // 
            this.electricidadToolStripMenuItem.Name = "electricidadToolStripMenuItem";
            this.electricidadToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.electricidadToolStripMenuItem.Text = "Electricidad";
            this.electricidadToolStripMenuItem.Click += new System.EventHandler(this.electricidadToolStripMenuItem_Click);
            // 
            // gasToolStripMenuItem
            // 
            this.gasToolStripMenuItem.Name = "gasToolStripMenuItem";
            this.gasToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.gasToolStripMenuItem.Text = "Gas";
            this.gasToolStripMenuItem.Click += new System.EventHandler(this.gasToolStripMenuItem_Click);
            // 
            // resultadosToolStripMenuItem
            // 
            this.resultadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.mensualToolStripMenuItem});
            this.resultadosToolStripMenuItem.Name = "resultadosToolStripMenuItem";
            this.resultadosToolStripMenuItem.Size = new System.Drawing.Size(71, 22);
            this.resultadosToolStripMenuItem.Text = "Consumo";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.generalToolStripMenuItem.Text = "Anual";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // mensualToolStripMenuItem
            // 
            this.mensualToolStripMenuItem.Name = "mensualToolStripMenuItem";
            this.mensualToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mensualToolStripMenuItem.Text = "Mensual";
            this.mensualToolStripMenuItem.Click += new System.EventHandler(this.mensualToolStripMenuItem_Click);
            // 
            // valorToolStripMenuItem
            // 
            this.valorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aguaToolStripMenuItem1,
            this.electricidadToolStripMenuItem1,
            this.gasToolStripMenuItem1});
            this.valorToolStripMenuItem.Name = "valorToolStripMenuItem";
            this.valorToolStripMenuItem.Size = new System.Drawing.Size(45, 22);
            this.valorToolStripMenuItem.Text = "Valor";
            // 
            // aguaToolStripMenuItem1
            // 
            this.aguaToolStripMenuItem1.Name = "aguaToolStripMenuItem1";
            this.aguaToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.aguaToolStripMenuItem1.Text = "Agua";
            this.aguaToolStripMenuItem1.Click += new System.EventHandler(this.aguaToolStripMenuItem1_Click);
            // 
            // electricidadToolStripMenuItem1
            // 
            this.electricidadToolStripMenuItem1.Name = "electricidadToolStripMenuItem1";
            this.electricidadToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.electricidadToolStripMenuItem1.Text = "Electricidad";
            this.electricidadToolStripMenuItem1.Click += new System.EventHandler(this.electricidadToolStripMenuItem1_Click);
            // 
            // gasToolStripMenuItem1
            // 
            this.gasToolStripMenuItem1.Name = "gasToolStripMenuItem1";
            this.gasToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.gasToolStripMenuItem1.Text = "Gas";
            this.gasToolStripMenuItem1.Click += new System.EventHandler(this.gasToolStripMenuItem1_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.AutoSize = true;
            this.pnlPrincipal.Controls.Add(this.picPortada);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 24);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(884, 597);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // picPortada
            // 
            this.picPortada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picPortada.Image = ((System.Drawing.Image)(resources.GetObject("picPortada.Image")));
            this.picPortada.Location = new System.Drawing.Point(30, 26);
            this.picPortada.Name = "picPortada";
            this.picPortada.Size = new System.Drawing.Size(931, 584);
            this.picPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPortada.TabIndex = 0;
            this.picPortada.TabStop = false;
            // 
            // frnInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 621);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frnInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumo Energético";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aguaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem electricidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.PictureBox picPortada;
        private System.Windows.Forms.ToolStripMenuItem valorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aguaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem electricidadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gasToolStripMenuItem1;
    }
}

