using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormInicio
{
    public partial class FormVerVentas : Form
    {
        
        public FormVerVentas()
        {
            InitializeComponent();
            
        }

        private void FormVerVentas_Load(object sender, EventArgs e)
        {
            double facturacionTotal = 0;
           foreach (Venta v in PetShop.ListaVenta)
           {
                lstVentas.Items.Add($"{v.InformacionVenta()}");
                facturacionTotal += v.PrecioTotal;
           }

            lblFacturacionTotal.Text = "Ingresos hasta ahora: $" +facturacionTotal.ToString();
            
        }
    }
}
