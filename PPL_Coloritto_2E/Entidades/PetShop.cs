using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PetShop
    {
        static List<Cliente> listaClientes;
        static List<Producto> listaProductos;
        static Stack<Venta> listaVentas;
        static List<Trabajador> listaTrabajadores;
        static int indiceTrabajadorActivo;
        #region Constructores
        
         static PetShop()
        {
            listaClientes = new List<Cliente>();
            listaTrabajadores = new List<Trabajador>();
            listaProductos = new List<Producto>();
            listaVentas = new Stack<Venta>();
        }
        #endregion

        #region Propiedades

         public static List<Cliente> ListaClientes
        {
            get
            {
                return listaClientes;
            }
        }
      
        public static List<Producto> ListaProductos
        {
            get
            {
                return listaProductos;
            }
        }

        public static  List<Trabajador> ListaTrabajadores
        {
            get
            {
                return listaTrabajadores;
            }
        }

        public static Stack<Venta> ListaVenta
        {
            get
            {
                return listaVentas;
            }
            set
            {
                listaVentas = value;
            }
        }

        public static int IndiceTrabajador
        {
            get { return indiceTrabajadorActivo; }
            set { indiceTrabajadorActivo = value; }
        }
        #endregion

        #region Metodos

        /// <summary>
        /// recorrera la lista de clientes y validara que sea el mismo nombre y apellido
        /// </summary>
        /// <param name="nombreYApellido"></param>
        /// <returns>retornara true si encuentra el cliente, false si no</returns>
        public static bool Existe(string nombreYApellido)
        {
            foreach (Cliente c in listaClientes)
            {
                if (String.Equals(c.ToString(), nombreYApellido))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Recorrera la lista comparando los nombres y apellidos
        /// </summary>
        /// <param name="nombreYApellido"></param>
        /// <returns>Retornara el cliente cuando lo encuentre, sino retornara null</returns>
        public static Cliente getClientePorNombreYApellido(string nombreYApellido)
        {
            Cliente cliente = null;

            foreach (Cliente c in listaClientes)
            {
                if (String.Equals(c.ToString(), nombreYApellido))
                {
                    cliente = c;
                    break;
                }
            }

            return cliente;
        }

       

        /// <summary>
        /// Recorrera la lista comparando los DNI
        /// </summary>
        /// <param name="nombreYApellido"></param>
        /// <returns>Retornara true si encuentra el dni, sino retornara false</returns>
        public static bool BuscarEmpleadoPorDni(int dniAux)
        {
            foreach (Trabajador t in listaTrabajadores)
            {
                if (t is Empleado)
                {
                    if (t.Dni == dniAux)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion

    }
}
