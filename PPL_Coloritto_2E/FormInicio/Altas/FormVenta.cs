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
    
    public partial class FormVenta : Form
    {
        Cliente clienteAux;
        List<Producto> listaAux;
        List<Producto> listaCarrito;
        double valor;
        int numeroAumentado = 1;
        public FormVenta()
        {
            InitializeComponent();
            clienteAux = new Cliente();
            listaAux = new List<Producto>();
            listaCarrito = new List<Producto>();
            valor = 0;
            numeroAumentado++;
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            foreach (Cliente c in PetShop.ListaClientes)
            {
                cmbClientes.Items.Add(c.ToString());
            }
            listaAux = PetShop.ListaProductos;
            btnAgregar.Enabled = false;
            btnFinalizar.Enabled = false;
            btnQuitar.Enabled = false;
            
            RefrescarDataGrid();
        }

        /// <summary>
        /// Selecciona el cliente al que se le realizara la venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeleccionCliente_Click(object sender, EventArgs e)
        {
            /*preguntar en clase de repaso como poder solucionar esto*/
            if (cmbClientes.SelectedIndex != -1)
            {
                if (cmbClientes.SelectedItem.ToString() != null)
                {
                    if (PetShop.Existe(cmbClientes.SelectedItem.ToString()))
                    {
                        clienteAux = PetShop.getClientePorNombreYApellido(cmbClientes.SelectedItem.ToString());
                        btnSeleccionCliente.Enabled = false;
                        cmbClientes.Enabled = false;
                        MessageBox.Show("Cliente seleccionado");
                        btnAgregar.Enabled = true;
                        btnFinalizar.Enabled = true;
                        btnQuitar.Enabled = true;
                        dtgCarrito.Enabled = true;
                        dtgProductosDisponibles.Enabled = true;
                        lblBolsilloCliente.Text = "Dinero disponible $" + clienteAux.DineroEnBolsillo.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un cliente");

                }
            }
            else
            {
                MessageBox.Show("Ocurrio un error.");

            }




        }

        private void RefrescarDataGrid()
        {
            dtgProductosDisponibles.DataSource = null;
            dtgProductosDisponibles.DataSource = listaAux;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto productoAux = (Producto)dtgProductosDisponibles.SelectedRows[0].DataBoundItem;
            
            if (productoAux.CantidadStock > 0)
            {
                productoAux.CantidadStock--;
                AgregarAlCarrito(productoAux);
                RefrescarDataGrid();
            }
            else
            {
                MessageBox.Show("No hay mas stock en ese producto");
            }

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            
            clienteAux.ListaCompra = CastearListaEnCarrito();
            if(clienteAux.ListaCompra != null && clienteAux.ListaCompra.Count > 0)
            {
                if (PetShop.ListaTrabajadores[PetShop.IndiceTrabajador].RealizarVenta(clienteAux))
                {
                    
                    string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @$"\Ticket-{clienteAux.Nombre}.txt";
                    
                    Archivador arch = new Archivador(ruta);
                    arch.CrearTicket(clienteAux.InfoTicket());
                    MessageBox.Show("Se guardo el ticket en el escritorio", "Venta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El cliente solicitado no tiene suficiente dinero.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
            }
        }

        private List<Producto> CastearListaEnCarrito()
        {
            List<Producto> listaCarritoAux = new List<Producto>();

            for (int i = 0; i < dtgCarrito.Rows.Count; i++)
            {
                Producto p = (Producto)dtgCarrito.Rows[i].DataBoundItem;
                listaCarritoAux.Add(p);
            }

            return listaCarritoAux;
        }

        private void AgregarAlCarrito(Producto p)
        {
            
            lblTotal.Text = "";
            listaCarrito.Add(p);
            dtgCarrito.DataSource = null;
            dtgCarrito.DataSource = listaCarrito;
            valor += p.Valor;
            lblTotal.Text += $"Precio total: ${valor}";
            btnQuitar.Enabled = true;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dtgCarrito.Rows.Count == 0)
            {
                btnQuitar.Enabled = false;
                MessageBox.Show("No hay productos en el carrito, no intente romperme :(");
            }
            if (dtgCarrito.Rows.Count > 0)
            {
                    Producto productoAux = (Producto)dtgCarrito.SelectedRows[0].DataBoundItem;
                    productoAux.CantidadStock++;
                    quitarDelCarrito(productoAux);
                    RefrescarDataGrid();
                
            }



        }
        private void quitarDelCarrito(Producto p)
        {
            lblTotal.Text = "";
            listaCarrito.Remove(p);
            dtgCarrito.DataSource = null;
            dtgCarrito.DataSource = listaCarrito;
            valor -= p.Valor;
            lblTotal.Text += $"Precio total: ${valor}";
        }
    }
}
