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
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < PetShop.ListaProductos.Count; i++)
            {
                lstProductos.Items.Add((string)PetShop.ListaProductos[i].InfoProducto());
            }
        }
    }
}
