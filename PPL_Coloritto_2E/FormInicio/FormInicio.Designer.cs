
namespace FormInicio
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loguearseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoTrabajadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarsesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasRealizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verClientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarVentaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTrabajadorActivo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.administradorToolStripMenuItem,
            this.empleadoToolStripMenuItem,
            this.stockToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loguearseToolStripMenuItem,
            this.nuevoTrabajadorToolStripMenuItem,
            this.cerrarsesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // loguearseToolStripMenuItem
            // 
            this.loguearseToolStripMenuItem.Name = "loguearseToolStripMenuItem";
            this.loguearseToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.loguearseToolStripMenuItem.Text = "Loguearse";
            this.loguearseToolStripMenuItem.Click += new System.EventHandler(this.loguearseToolStripMenuItem_Click_1);
            // 
            // nuevoTrabajadorToolStripMenuItem
            // 
            this.nuevoTrabajadorToolStripMenuItem.Name = "nuevoTrabajadorToolStripMenuItem";
            this.nuevoTrabajadorToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.nuevoTrabajadorToolStripMenuItem.Text = "Nuevo trabajador";
            this.nuevoTrabajadorToolStripMenuItem.Click += new System.EventHandler(this.nuevoTrabajadorToolStripMenuItem_Click);
            // 
            // cerrarsesionToolStripMenuItem
            // 
            this.cerrarsesionToolStripMenuItem.Enabled = false;
            this.cerrarsesionToolStripMenuItem.Name = "cerrarsesionToolStripMenuItem";
            this.cerrarsesionToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.cerrarsesionToolStripMenuItem.Text = "Cerrar sesion";
            this.cerrarsesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarsesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaClienteToolStripMenuItem,
            this.realizarVentaToolStripMenuItem,
            this.listaEmpleadosToolStripMenuItem,
            this.ventasRealizadasToolStripMenuItem,
            this.verClientesToolStripMenuItem1});
            this.administradorToolStripMenuItem.Enabled = false;
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // altaClienteToolStripMenuItem
            // 
            this.altaClienteToolStripMenuItem.Name = "altaClienteToolStripMenuItem";
            this.altaClienteToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.altaClienteToolStripMenuItem.Text = "Alta cliente";
            this.altaClienteToolStripMenuItem.Click += new System.EventHandler(this.altaClienteToolStripMenuItem_Click_1);
            // 
            // realizarVentaToolStripMenuItem
            // 
            this.realizarVentaToolStripMenuItem.Name = "realizarVentaToolStripMenuItem";
            this.realizarVentaToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.realizarVentaToolStripMenuItem.Text = "Realizar venta";
            this.realizarVentaToolStripMenuItem.Click += new System.EventHandler(this.realizarVentaToolStripMenuItem_Click);
            // 
            // listaEmpleadosToolStripMenuItem
            // 
            this.listaEmpleadosToolStripMenuItem.Name = "listaEmpleadosToolStripMenuItem";
            this.listaEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.listaEmpleadosToolStripMenuItem.Text = "Lista empleados";
            this.listaEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.listaEmpleadosToolStripMenuItem_Click);
            // 
            // ventasRealizadasToolStripMenuItem
            // 
            this.ventasRealizadasToolStripMenuItem.Name = "ventasRealizadasToolStripMenuItem";
            this.ventasRealizadasToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.ventasRealizadasToolStripMenuItem.Text = "Facturacion";
            this.ventasRealizadasToolStripMenuItem.Click += new System.EventHandler(this.ventasRealizadasToolStripMenuItem_Click);
            // 
            // verClientesToolStripMenuItem1
            // 
            this.verClientesToolStripMenuItem1.Name = "verClientesToolStripMenuItem1";
            this.verClientesToolStripMenuItem1.Size = new System.Drawing.Size(191, 24);
            this.verClientesToolStripMenuItem1.Text = "Ver clientes";
            this.verClientesToolStripMenuItem1.Click += new System.EventHandler(this.verClientesToolStripMenuItem1_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaClienteToolStripMenuItem1,
            this.realizarVentaToolStripMenuItem1,
            this.verClientesToolStripMenuItem});
            this.empleadoToolStripMenuItem.Enabled = false;
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // altaClienteToolStripMenuItem1
            // 
            this.altaClienteToolStripMenuItem1.Name = "altaClienteToolStripMenuItem1";
            this.altaClienteToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.altaClienteToolStripMenuItem1.Text = "Alta cliente";
            this.altaClienteToolStripMenuItem1.Click += new System.EventHandler(this.altaClienteToolStripMenuItem1_Click_1);
            // 
            // realizarVentaToolStripMenuItem1
            // 
            this.realizarVentaToolStripMenuItem1.Name = "realizarVentaToolStripMenuItem1";
            this.realizarVentaToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.realizarVentaToolStripMenuItem1.Text = "Realizar venta";
            this.realizarVentaToolStripMenuItem1.Click += new System.EventHandler(this.realizarVentaToolStripMenuItem1_Click);
            // 
            // verClientesToolStripMenuItem
            // 
            this.verClientesToolStripMenuItem.Name = "verClientesToolStripMenuItem";
            this.verClientesToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.verClientesToolStripMenuItem.Text = "Ver clientes";
            this.verClientesToolStripMenuItem.Click += new System.EventHandler(this.verClientesToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Enabled = false;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // lblTrabajadorActivo
            // 
            this.lblTrabajadorActivo.AutoSize = true;
            this.lblTrabajadorActivo.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrabajadorActivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTrabajadorActivo.Location = new System.Drawing.Point(12, 419);
            this.lblTrabajadorActivo.Name = "lblTrabajadorActivo";
            this.lblTrabajadorActivo.Size = new System.Drawing.Size(0, 25);
            this.lblTrabajadorActivo.TabIndex = 1;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTrabajadorActivo);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BIENVENIDO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInicio_FormClosing);
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loguearseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarsesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem realizarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasRealizadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarVentaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.Label lblTrabajadorActivo;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verClientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoTrabajadorToolStripMenuItem;
    }
}

