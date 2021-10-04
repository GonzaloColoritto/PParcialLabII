
namespace FormInicio
{
    partial class FormVenta
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
            this.dtgProductosDisponibles = new System.Windows.Forms.DataGridView();
            this.dtgCarrito = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.btnSeleccionCliente = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblBolsilloCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgProductosDisponibles
            // 
            this.dtgProductosDisponibles.AllowUserToAddRows = false;
            this.dtgProductosDisponibles.AllowUserToDeleteRows = false;
            this.dtgProductosDisponibles.AllowUserToResizeColumns = false;
            this.dtgProductosDisponibles.AllowUserToResizeRows = false;
            this.dtgProductosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductosDisponibles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgProductosDisponibles.Enabled = false;
            this.dtgProductosDisponibles.Location = new System.Drawing.Point(13, 67);
            this.dtgProductosDisponibles.MultiSelect = false;
            this.dtgProductosDisponibles.Name = "dtgProductosDisponibles";
            this.dtgProductosDisponibles.ReadOnly = true;
            this.dtgProductosDisponibles.RowTemplate.Height = 25;
            this.dtgProductosDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProductosDisponibles.Size = new System.Drawing.Size(327, 307);
            this.dtgProductosDisponibles.TabIndex = 0;
            // 
            // dtgCarrito
            // 
            this.dtgCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCarrito.Enabled = false;
            this.dtgCarrito.Location = new System.Drawing.Point(472, 67);
            this.dtgCarrito.Name = "dtgCarrito";
            this.dtgCarrito.RowTemplate.Height = 25;
            this.dtgCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCarrito.Size = new System.Drawing.Size(327, 307);
            this.dtgCarrito.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Productos disponibles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(472, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Carrito";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(349, 112);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 39);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar al carrito";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(349, 157);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(115, 39);
            this.btnQuitar.TabIndex = 5;
            this.btnQuitar.Text = "Quitar del carrito";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(349, 335);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(115, 39);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.Text = "Finalizar compra";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(349, 12);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(115, 23);
            this.cmbClientes.TabIndex = 7;
            // 
            // btnSeleccionCliente
            // 
            this.btnSeleccionCliente.Location = new System.Drawing.Point(349, 41);
            this.btnSeleccionCliente.Name = "btnSeleccionCliente";
            this.btnSeleccionCliente.Size = new System.Drawing.Size(115, 23);
            this.btnSeleccionCliente.TabIndex = 8;
            this.btnSeleccionCliente.Text = "Seleccionar cliente";
            this.btnSeleccionCliente.UseVisualStyleBackColor = true;
            this.btnSeleccionCliente.Click += new System.EventHandler(this.btnSeleccionCliente_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(681, 45);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 15);
            this.lblTotal.TabIndex = 9;
            // 
            // lblBolsilloCliente
            // 
            this.lblBolsilloCliente.AutoSize = true;
            this.lblBolsilloCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBolsilloCliente.Location = new System.Drawing.Point(472, 12);
            this.lblBolsilloCliente.Name = "lblBolsilloCliente";
            this.lblBolsilloCliente.Size = new System.Drawing.Size(0, 17);
            this.lblBolsilloCliente.TabIndex = 10;
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(811, 386);
            this.Controls.Add(this.lblBolsilloCliente);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSeleccionCliente);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgCarrito);
            this.Controls.Add(this.dtgProductosDisponibles);
            this.Name = "FormVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgProductosDisponibles;
        private System.Windows.Forms.DataGridView dtgCarrito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Button btnSeleccionCliente;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblBolsilloCliente;
    }
}