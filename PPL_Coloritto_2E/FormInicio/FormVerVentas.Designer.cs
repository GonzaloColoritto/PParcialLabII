
namespace FormInicio
{
    partial class FormVerVentas
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
            this.lstVentas = new System.Windows.Forms.ListBox();
            this.lblFacturacionTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstVentas
            // 
            this.lstVentas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstVentas.FormattingEnabled = true;
            this.lstVentas.ItemHeight = 17;
            this.lstVentas.Location = new System.Drawing.Point(10, 12);
            this.lstVentas.Name = "lstVentas";
            this.lstVentas.Size = new System.Drawing.Size(751, 412);
            this.lstVentas.TabIndex = 0;
            // 
            // lblFacturacionTotal
            // 
            this.lblFacturacionTotal.AutoSize = true;
            this.lblFacturacionTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFacturacionTotal.Location = new System.Drawing.Point(548, 438);
            this.lblFacturacionTotal.Name = "lblFacturacionTotal";
            this.lblFacturacionTotal.Size = new System.Drawing.Size(0, 20);
            this.lblFacturacionTotal.TabIndex = 1;
            // 
            // FormVerVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(773, 462);
            this.Controls.Add(this.lblFacturacionTotal);
            this.Controls.Add(this.lstVentas);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormVerVentas";
            this.Text = "FormVerVentas";
            this.Load += new System.EventHandler(this.FormVerVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVentas;
        private System.Windows.Forms.Label lblFacturacionTotal;
    }
}