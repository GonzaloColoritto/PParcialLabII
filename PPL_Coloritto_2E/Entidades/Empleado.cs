using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado: Trabajador
    {
        
        public Empleado(string nombre, string apellido, int dni):base(nombre,apellido,dni)
        {
            this.Contraseña = "contraseña";
        }
        /// <summary>
        /// Sobrecarga de InformacionPersonal()
        /// </summary>
        /// <returns>Retornara el metodo base sumado con "-Empleado"</returns>
        public override string InformacionPersonal()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.InformacionPersonal()} - Empleado");
            

            return sb.ToString();
        }

        
    }
}
