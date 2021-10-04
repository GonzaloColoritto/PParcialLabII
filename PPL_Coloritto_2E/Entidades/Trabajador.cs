using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Trabajador: Persona
    {
        
        string contraseña = null;
        List<Venta> listaDeVentas;
        public Trabajador(string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
            listaDeVentas = new List<Venta>();
            
        }

        //NO DEJAR ESTAS DOS PROPIEDADES ASI
        public string Contraseña 
        {
            get
            {
                return this.contraseña;
            }
            set
            {
                this.contraseña = value;
            }
        
        }
        
        /// <summary>
        /// llamara a InformacionPersonal de la clase padre
        /// </summary>
        /// <returns>retornara el stringbuilder con la informacion</returns>
        public override string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.InformacionPersonal());
            return sb.ToString();

        }
        
        /// <summary>
        /// Realizara la venta correspondiente calculando el precio total de esta
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>Retornara true si el cliente tiene mas dinero que el precio total, false si no</returns>
        public bool RealizarVenta( Cliente cliente)
        {
            double precioTotal = 0;
            
            if(cliente != null && cliente.ListaCompra != null)
            {
                foreach (Producto p in cliente.ListaCompra)
                {
                    precioTotal += p.Valor;
                }

                if (cliente.DineroEnBolsillo > precioTotal)
                {
                    Venta venta = new Venta(cliente, this,precioTotal);
                    PetShop.ListaVenta.Push(venta);
                    cliente.DineroEnBolsillo = cliente.DineroEnBolsillo - precioTotal;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Validara los datos pasados por parametro
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <returns>Retornara true si los datos son validos para usarse, false si no lo son</returns>
        public static bool ValidarDatos(string nombre, string apellido, string dni)
        {
            int auxDni;
            
            if (nombre != null && apellido != null && dni != null && nombre != "" && apellido != "" && dni != "")
            {
                if (Comandos.IsAllLetters(nombre) && Comandos.IsAllLetters(apellido))
                {

                    if (int.TryParse(dni, out auxDni))
                    {
                        return true;
                    }

                }

            }
            return false;

        }

        public static bool operator ==(Trabajador t1, Trabajador t2)
        {
            if (t1.Dni == t2.Dni)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Trabajador t1, Trabajador t2)
        {
            return !(t1 == t2);
        }
        

        public static bool operator +(Trabajador t, List<Trabajador> lista)
        {
            foreach (Trabajador trab in lista)
            {
                if(t == trab)
                {
                    return false;
                }
                
            }
            lista.Add(t);
            return true;
           
        }
        public static bool operator -(Trabajador t, List<Trabajador> lista)
        {
            foreach (Trabajador trab in lista)
            {
                if (t == trab)
                {
                    lista.Remove(trab);
                    return true;
                }

            }
            
            return false;

        }
        
    }
}
