using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.IO;
using System.Threading;

namespace FormInicio
{
    public partial class FormInicio : Form
    {
        /*NOTA PARA LA CORRECION 
         La contraseña de los administradores es "admin123" y la de los empleados comunes es "contraseña"
         */


        public FormInicio()
        {
            InitializeComponent();

            #region Hardcodeo

            Administrador admin = new Administrador("PEPE", "PEPOSO", 42818596);
            Empleado emp1 = new Empleado("GONZALO", "COLORITTO", 35214596);
            Empleado emp2 = new Empleado("MIRKO", "LOPEZ", 30250265);

            Producto prod1 = new Producto("Dog Chaw", 285, 40, TipoProducto.Comida);
            Producto prod2 = new Producto("Cat Chaw", 275, 30, TipoProducto.Comida);
            Producto prod3 = new Producto("Pelota Chillona", 150, 60, TipoProducto.Juguete);
            Producto prod4 = new Producto("Pastito", 850, 60, TipoProducto.Cuidado);
            Producto prod5 = new Producto("Wiskas", 175, 30, TipoProducto.Comida);
            Producto prod6 = new Producto("Palito", 150, 60, TipoProducto.Juguete);
            Producto prod7 = new Producto("Vitaminas", 250, 1, TipoProducto.Cuidado);
            Producto prod8 = new Producto("Cama Simple", 150, 10, TipoProducto.Camas);
            Producto prod9 = new Producto("Cama Premium", 450, 10, TipoProducto.Camas);
            Producto prod10 = new Producto("Cama Estandar", 300, 10, TipoProducto.Camas);

            Cliente cliente1 = new Cliente("HECTOR", "GARCIA", 36524152, 1500, eMetodoDePago.Efectivo);
            Cliente cliente2 = new Cliente("MIONEL", "LESSI", 38652485, 500, eMetodoDePago.Efectivo);
            Cliente cliente3 = new Cliente("LIONEL", "SCALONI", 23524152, 1500, eMetodoDePago.Tarjeta);
            Cliente cliente4 = new Cliente("RISTIANO", "CONALDO", 68524152, 1500, eMetodoDePago.Tarjeta);


            Producto prodHardVenta1 = new Producto("Pelota de Diamante", 1450, 1, TipoProducto.Juguete);
            Producto prodHardVenta2 = new Producto("Cama Doble", 1000, 1, TipoProducto.Camas);

            #region hardcodeoVenta
            List<Producto> listaHardVenta = new List<Producto>();
            listaHardVenta.Add(prodHardVenta1);
            listaHardVenta.Add(prodHardVenta2);
            Cliente clienteHardVenta = new Cliente("JEFF", "BUZOS", 42824152, 10500, eMetodoDePago.Tarjeta, listaHardVenta);
            admin.RealizarVenta(clienteHardVenta);
            #endregion


            PetShop.ListaTrabajadores.Add(admin);
            PetShop.ListaTrabajadores.Add(emp1);
            PetShop.ListaTrabajadores.Add(emp2);

            PetShop.ListaProductos.Add(prod1);
            PetShop.ListaProductos.Add(prod2);
            PetShop.ListaProductos.Add(prod3);
            PetShop.ListaProductos.Add(prod4);
            PetShop.ListaProductos.Add(prod5);
            PetShop.ListaProductos.Add(prod6);
            PetShop.ListaProductos.Add(prod7);
            PetShop.ListaProductos.Add(prod8);
            PetShop.ListaProductos.Add(prod9);
            PetShop.ListaProductos.Add(prod10);

            PetShop.ListaClientes.Add(cliente1);
            PetShop.ListaClientes.Add(cliente2);
            PetShop.ListaClientes.Add(cliente3);
            PetShop.ListaClientes.Add(cliente4);
            PetShop.ListaClientes.Add(clienteHardVenta);
            #endregion

            SoundPlayer simpleSound = new SoundPlayer(Environment.CurrentDirectory + @"\Bienvenida.wav");
            simpleSound.Play();

        }

        private void altaClienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            FormAltaCliente formAltaCliente = new FormAltaCliente();

            formAltaCliente.ShowDialog();

        }

        private void altaClienteToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

            FormAltaCliente formAltaCliente = new FormAltaCliente();

            formAltaCliente.ShowDialog();

        }

        private void loguearseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Log formLog = new Log();
            if (formLog.ShowDialog() == DialogResult.OK)
            {
                lblTrabajadorActivo.Text = (string)PetShop.ListaTrabajadores[PetShop.IndiceTrabajador].InformacionPersonal();
                if (PetShop.ListaTrabajadores[PetShop.IndiceTrabajador] is Administrador)
                {
                    administradorToolStripMenuItem.Enabled = true;
                    stockToolStripMenuItem.Enabled = true;
                    loguearseToolStripMenuItem.Enabled = false;
                    MessageBox.Show("Ahora tiene los permisos de administrador", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cerrarsesionToolStripMenuItem.Enabled = true;
                    this.BackColor = Color.Aqua;

                }
                else
                {
                    loguearseToolStripMenuItem.Enabled = false;
                    empleadoToolStripMenuItem.Enabled = true;
                    stockToolStripMenuItem.Enabled = true;
                    cerrarsesionToolStripMenuItem.Enabled = true;
                    MessageBox.Show("Ahora tiene los permisos de empleado", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BackColor = Color.AliceBlue;
                }

            }

        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStock formStock = new FormStock();
            formStock.ShowDialog();
        }

        private void cerrarsesionToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("¿Esta seguro que desea cerrar sesion?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PetShop.IndiceTrabajador = -1;
                loguearseToolStripMenuItem.Enabled = true;
                empleadoToolStripMenuItem.Enabled = false;
                administradorToolStripMenuItem.Enabled = false;
                cerrarsesionToolStripMenuItem.Enabled = false;
                lblTrabajadorActivo.Text = null;
                this.BackColor = Color.Black;


            }


        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {

                e.Cancel = true;
            }
        }

        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVerClientes formClientes = new FormVerClientes();
            formClientes.Show();
        }

        private void verClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormVerClientes formClientes = new FormVerClientes();
            formClientes.Show();
        }

        private void listaEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVerEmpleados formVerEmpleados = new FormVerEmpleados();
            formVerEmpleados.Show();
        }

        private void nuevoTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormNuevoTrabajador formNuevoTrabajador = new FormNuevoTrabajador();
            formNuevoTrabajador.Show();

        }

        private void realizarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVenta formVenta = new FormVenta();
            formVenta.Show();
        }

        private void ventasRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormVerVentas formVerVentas = new FormVerVentas();
            formVerVentas.Show();
        }

        private void realizarVentaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormVenta formVenta = new FormVenta();
            formVenta.Show();
        }
    }
}
