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
    public partial class FormVerClientes : Form
    {
        public FormVerClientes()
        {
            InitializeComponent();
        }

        private void FormVerClientes_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < PetShop.ListaClientes.Count; i++)
            {
                lstClientes.Items.Add((string)PetShop.ListaClientes[i].MostrarInfo());
            }
        }
    }
}
