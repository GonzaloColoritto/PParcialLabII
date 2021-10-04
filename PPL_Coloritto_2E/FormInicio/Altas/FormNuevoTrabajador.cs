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
    public partial class FormNuevoTrabajador : Form
    {
        SoundPlayer simpleSound = new SoundPlayer(Environment.CurrentDirectory + @"\ALTATRABAJADORES.wav");
        public FormNuevoTrabajador()
        {
            InitializeComponent();
            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Empleado");
        }

        
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int parseAux;
            if (Trabajador.ValidarDatos(txtNombre.Text, txtApellido.Text, txtDni.Text))
            {
                if (cmbRol.SelectedIndex == 0)
                {
                    if (int.TryParse(txtDni.Text, out parseAux))
                    {
                        if (parseAux < 99999999 && parseAux > 1000000)
                        {
                            Administrador admin = new Administrador(txtNombre.Text, txtApellido.Text, parseAux);
                            if (admin + PetShop.ListaTrabajadores)
                            {
                                MessageBox.Show("Nuevo administrador creado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Ese DNI ya fue ingresado previamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show("El DNI ingresado no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                    }
                    else
                    {
                        MessageBox.Show("Error en el ingreso de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    if (int.TryParse(txtDni.Text, out parseAux))
                    {
                        if (parseAux <99999999 && parseAux>1000000)
                        {
                            Empleado emp = new Empleado(txtNombre.Text, txtApellido.Text, parseAux);
                            if (emp + PetShop.ListaTrabajadores)
                            {
                                MessageBox.Show("Nuevo empleado creado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error en el ingreso de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El DNI ingresado no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Error en el ingreso de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error en el ingreso de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormNuevoTrabajador_Load(object sender, EventArgs e)
        {
            
            simpleSound.Play();
        }

        private void FormNuevoTrabajador_FormClosing(object sender, FormClosingEventArgs e)
        {
            simpleSound.Stop();
        }
    }
}
