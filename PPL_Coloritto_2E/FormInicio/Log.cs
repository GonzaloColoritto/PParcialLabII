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
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        private void Log_Load(object sender, EventArgs e)
        {
            for(int i =0; i< PetShop.ListaTrabajadores.Count; i++)
            {
                lstTrabajadores.Items.Add((string)PetShop.ListaTrabajadores[i].InformacionPersonal());
            }
            txtContraseña.PasswordChar = 'X';
           
        }

      /// <summary>
      /// VAlidara el ingreso  mediante el dni y la contraseña, y asignara el valor a indiceTrabajador
      /// </summary>
      /// <param name="dni"></param>
      /// <param name="contraseña"></param>
      /// <param name="listaTrabajadores"></param>
      /// <returns>retornara true si encontro coincidencia, caso contrario retornara false</returns>
        public bool ValidarIngreso(int dni, string contraseña, List<Trabajador> listaTrabajadores)
        {
          
            for(int i = 0; i < listaTrabajadores.Count; i++)
            {
                if (dni == listaTrabajadores[i].Dni && contraseña == listaTrabajadores[i].Contraseña)
                {
                    PetShop.IndiceTrabajador = i;
                    return true;
                }
            }

            return false;
        }
         
        /// <summary>
        /// Llamara al metodo VAlidarIngreso() y validara los textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int dni;
            string contraseña;
            if (txtDni.Text != null && txtContraseña.Text != null && txtDni.Text != "" && txtContraseña.Text != "")
            {

                if (int .TryParse(txtDni.Text, out dni))
                {
                     contraseña = (txtContraseña.Text);
                    if (ValidarIngreso(dni, contraseña, PetShop.ListaTrabajadores))
                    {
                        
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo iniciar sesion", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error en el DNI ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No ha ingresado datos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            
        }


        /// <summary>
        /// Completara los datos de los textbox correspondientes con los datos del administrador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAutocompletar_Click(object sender, EventArgs e)
        {
            txtDni.Text = "42818596";
            txtContraseña.Text = "admin123";
        }

        /// <summary>
        /// Borrara el texto de los texbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtDni.Text = null;
            txtContraseña.Text = null;
        }

        

        /// <summary>
        /// Completara los datos de los textbox correspondientes con los datos del empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompletarEmpleado_Click(object sender, EventArgs e)
        {
            txtDni.Text = "35214596";
            txtContraseña.Text = "contraseña";
        }

        

    }
}
