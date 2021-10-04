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


namespace FormInicio
{
    public partial class FormAltaCliente : Form
    {
        SoundPlayer simpleSound = new SoundPlayer(Environment.CurrentDirectory + @"\ALTACLIENTE.wav");
        public FormAltaCliente()
        {
            InitializeComponent();
        }

        private void FormAltaCliente_Load(object sender, EventArgs e)
        {
            cmbMetodoPago.Items.Add("Tarjeta");
            cmbMetodoPago.Items.Add("Efectivo");

            
            simpleSound.Play();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            int dni ;
            double dinero;
            eMetodoDePago metodoPago;

            if(Cliente.ValidarDatosCliente(txtNombre.Text, txtApellido.Text, txtDni.Text, txtDinero.Text))
            {
                nombre = txtNombre.Text;
                apellido = txtApellido.Text;
                dni = int.Parse(txtDni.Text);
                dinero = double.Parse(txtDinero.Text);
                
                    if (cmbMetodoPago.SelectedIndex == 0)
                    {
                        metodoPago = eMetodoDePago.Tarjeta;
                    }
                    else
                    {
                        metodoPago = eMetodoDePago.Efectivo;
                    }

                    Cliente cliente = new Cliente(nombre, apellido, dni, dinero, metodoPago);
                    if (cliente + PetShop.ListaClientes)
                    {
                        MessageBox.Show($"{cliente.MostrarInfo()}", "Nuevo cliente creado");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"El DNI ya fue ingresado previamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
               /*continuar aca, el cmb deja pasar los null*/ 
            }
            else
            {
                MessageBox.Show($"Ocurrio un error en la carga de datos", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void FormAltaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            simpleSound.Stop();
        }
    }
}
