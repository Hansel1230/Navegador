namespace Navegador
{
    partial class FomNavegador
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnAtras = new System.Windows.Forms.ToolStripButton();
            this.BtnAdelante = new System.Windows.Forms.ToolStripButton();
            this.BtnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.BtnInicio = new System.Windows.Forms.ToolStripButton();
            this.BtnBusqueda = new System.Windows.Forms.ToolStripButton();
            this.TxtIr = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.webBrowser1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.862385F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.33945F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(761, 438);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 49);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(755, 386);
            this.webBrowser1.TabIndex = 6;
            this.webBrowser1.NewWindow += new System.ComponentModel.CancelEventHandler(this.webBrowser1_NewWindow);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.95364F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.04636F));
            this.tableLayoutPanel3.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.TxtIr, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(755, 40);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAtras,
            this.BtnAdelante,
            this.BtnRefrescar,
            this.BtnInicio,
            this.BtnBusqueda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(127, 40);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnAtras
            // 
            this.BtnAtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAtras.Image = global::Navegador.Properties.Resources.Atras;
            this.BtnAtras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(23, 41);
            this.BtnAtras.Text = "<";
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click_1);
            // 
            // BtnAdelante
            // 
            this.BtnAdelante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAdelante.Image = global::Navegador.Properties.Resources.Adelante;
            this.BtnAdelante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAdelante.Name = "BtnAdelante";
            this.BtnAdelante.Size = new System.Drawing.Size(23, 41);
            this.BtnAdelante.Text = ">";
            this.BtnAdelante.Click += new System.EventHandler(this.BtnAdelante_Click_1);
            // 
            // BtnRefrescar
            // 
            this.BtnRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnRefrescar.Image = global::Navegador.Properties.Resources.Refresh;
            this.BtnRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.Size = new System.Drawing.Size(23, 41);
            this.BtnRefrescar.Text = "Refrescar";
            this.BtnRefrescar.Click += new System.EventHandler(this.BtnRefrescar_Click);
            // 
            // BtnInicio
            // 
            this.BtnInicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnInicio.Image = global::Navegador.Properties.Resources.Home;
            this.BtnInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(23, 41);
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click_1);
            // 
            // BtnBusqueda
            // 
            this.BtnBusqueda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnBusqueda.Image = global::Navegador.Properties.Resources.busqueda1;
            this.BtnBusqueda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBusqueda.Name = "BtnBusqueda";
            this.BtnBusqueda.Size = new System.Drawing.Size(23, 41);
            this.BtnBusqueda.Text = "Busqueda";
            this.BtnBusqueda.Click += new System.EventHandler(this.BtnBusqueda_Click);
            // 
            // TxtIr
            // 
            this.TxtIr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxtIr.Location = new System.Drawing.Point(130, 17);
            this.TxtIr.Name = "TxtIr";
            this.TxtIr.Size = new System.Drawing.Size(622, 20);
            this.TxtIr.TabIndex = 9;
            this.TxtIr.Click += new System.EventHandler(this.TxtIr_Click_1);
            this.TxtIr.Leave += new System.EventHandler(this.TxtIr_Leave_1);
            // 
            // FomNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 438);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FomNavegador";
            this.Text = "Navegador";
            this.Load += new System.EventHandler(this.FomNavegador_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnAtras;
        private System.Windows.Forms.ToolStripButton BtnAdelante;
        private System.Windows.Forms.ToolStripButton BtnRefrescar;
        private System.Windows.Forms.ToolStripButton BtnInicio;
        private System.Windows.Forms.ToolStripButton BtnBusqueda;
        private System.Windows.Forms.TextBox TxtIr;
    }
}

