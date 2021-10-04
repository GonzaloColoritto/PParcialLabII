using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador: Trabajador
    {
        #region Constructores
        public Administrador(string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
            this.Contraseña = "admin123";
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobrecarga del metodo InformacionPersonal()
        /// </summary>
        /// <returns>Retorna el metodo llamado, sumado a "-Administrador"</returns>
        public override string InformacionPersonal()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.InformacionPersonal()} - Administrador");
           

            return sb.ToString();
        }

        /// <summary>
        /// Editara los datos del empleado buscado
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="lista"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <returns>retornara true si pudo hacerlo, false si no</returns>
        public static bool EditarEmpleado(string dni, List<Trabajador> lista,string nombre, string apellido)
        {
            int aux;

            if (ValidarDatos(nombre,apellido,dni))
            {
                aux = int.Parse(dni);
                foreach (Trabajador t in lista)
                {
                    if (t is Empleado)
                    {
                       if(aux == t.Dni)
                       {
                            t.Nombre = nombre;
                            t.Apellido = apellido;
                            return true;
                       }
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
