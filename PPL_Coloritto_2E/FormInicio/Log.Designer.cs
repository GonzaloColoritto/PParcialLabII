
namespace FormInicio
{
    partial class Log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAutocompletar = new System.Windows.Forms.Button();
            this.lstTrabajadores = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCompletarEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(12, 48);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(154, 23);
            this.txtDni.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese su DNI";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(12, 121);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(95, 34);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtContraseña.Location = new System.Drawing.Point(12, 92);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(154, 23);
            this.txtContraseña.TabIndex = 1;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(113, 121);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(53, 34);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAutocompletar
            // 
            this.btnAutocompletar.Location = new System.Drawing.Point(12, 161);
            this.btnAutocompletar.Name = "btnAutocompletar";
            this.btnAutocompletar.Size = new System.Drawing.Size(154, 22);
            this.btnAutocompletar.TabIndex = 5;
            this.btnAutocompletar.Text = "Autocompletar Admin";
            this.btnAutocompletar.UseVisualStyleBackColor = true;
            this.btnAutocompletar.Click += new System.EventHandler(this.btnAutocompletar_Click);
            // 
            // lstTrabajadores
            // 
            this.lstTrabajadores.Enabled = false;
            this.lstTrabajadores.FormattingEnabled = true;
            this.lstTrabajadores.ItemHeight = 15;
            this.lstTrabajadores.Location = new System.Drawing.Point(201, 35);
            this.lstTrabajadores.Name = "lstTrabajadores";
            this.lstTrabajadores.Size = new System.Drawing.Size(290, 289);
            this.lstTrabajadores.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "TRABAJADORES";
          
            // 
            // btnCompletarEmpleado
            // 
            this.btnCompletarEmpleado.Location = new System.Drawing.Point(12, 189);
            this.btnCompletarEmpleado.Name = "btnCompletarEmpleado";
            this.btnCompletarEmpleado.Size = new System.Drawing.Size(154, 22);
            this.btnCompletarEmpleado.TabIndex = 6;
            this.btnCompletarEmpleado.Text = "Autocompletar Empleado";
            this.btnCompletarEmpleado.UseVisualStyleBackColor = true;
            this.btnCompletarEmpleado.Click += new System.EventHandler(this.btnCompletarEmpleado_Click);
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(503, 339);
            this.Controls.Add(this.btnCompletarEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstTrabajadores);
            this.Controls.Add(this.btnAutocompletar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicie sesion";
            this.Load += new System.EventHandler(this.Log_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAutocompletar;
        private System.Windows.Forms.ListBox lstTrabajadores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCompletarEmpleado;
    }
}