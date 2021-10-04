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
    public partial class FormVerEmpleados : Form
    {
        public FormVerEmpleados()
        {
            InitializeComponent();
        }

        private void FormVerEmpleados_Load(object sender, EventArgs e)
        {
            foreach(Trabajador emp in PetShop.ListaTrabajadores)
            {
                if(emp is Empleado)
                {
                    lstEmpleados.Items.Add($"{emp.InformacionPersonal()}");
                }
               
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int dniAux;
            

            if(int.TryParse(txtDniEmpleado.Text,out dniAux))
            {

                if (PetShop.BuscarEmpleadoPorDni(dniAux))
                {
                    MessageBox.Show($"{MostrarEmpleado(dniAux, PetShop.ListaTrabajadores)}", "Empleado encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No se encontro coincidencia del DNI ingresado", "Empleado no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                
            }

        }

        public static string MostrarEmpleado(int dni, List<Trabajador> lista)
        {
            foreach (Trabajador emp in lista)
            {
                
                    if (emp is Empleado && dni == emp.Dni)
                    {
                        return emp.MostrarInfo();
                    }
                
            }
            return null;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int dniAux;
            if (int.TryParse(txtDniEmpleado.Text, out dniAux))
            {
                foreach (Trabajador emp in PetShop.ListaTrabajadores)
                {

                    if (emp is Empleado && dniAux == emp.Dni)
                    {
                        
                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        txtNombre.Visible = true;
                        txtApellido.Visible = true;
                        btnConfirmar.Visible = true;
                        lblError.Visible = false;
                    }

                }
                if (label4.Visible == false)
                {
                    lblError.Visible = true;
                }
            }
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtDniEmpleado.Text != null && txtNombre.Text != null && txtDniEmpleado.Text != "" && txtNombre.Text != "")
            {
                if (Administrador.EditarEmpleado(txtDniEmpleado.Text, PetShop.ListaTrabajadores, txtNombre.Text, txtApellido.Text))
                {
                    MessageBox.Show($"Empleado modificado con exito.", "Edicion confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Ocurrio un error inesperado en la edicion. \nVerifique que los datos esten bien ingresados.", "Edicion denegada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Ingrese ambos datos. \nVerifique que los datos esten bien ingresados.", "Edicion denegada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
