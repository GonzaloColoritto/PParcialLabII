using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public enum eMetodoDePago
    {
        Tarjeta,
        Efectivo
    }
    public class Cliente : Persona
    {

        double dineroEnBolsillo;
        eMetodoDePago metodoDePago;
        List<Producto> listaCompra;

        #region Constructores
        public Cliente() : base()
        {
            this.listaCompra = new List<Producto>();
        }
        public Cliente(string nombre, string apellido, int dni, double dinero, eMetodoDePago metodo) :this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.dineroEnBolsillo = dinero;
            this.metodoDePago = metodo;
        }

        public Cliente(string nombre, string apellido, int dni, double dinero, eMetodoDePago metodo, List<Producto> lista):this(nombre,apellido,dni,dinero,metodo) 
        {
            this.ListaCompra = lista;
        }
        #endregion

        #region Propiedades
        public double DineroEnBolsillo
        {
            get { return this.dineroEnBolsillo; }
            set
            {
                if(value > 0)
                {
                    this.dineroEnBolsillo = value;
                }
            }
        }
        public eMetodoDePago MetodoDePAgo
        {
            get { return this.metodoDePago; }
            set
            {
                this.metodoDePago = value;
            }
        }

        public List<Producto> ListaCompra
        {
            get
            {
                return this.listaCompra;
            }
            set
            {
                this.listaCompra = value;
            }
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Sobrecarga, mostrara la informacion del cliente
        /// </summary>
        /// <returns>retornara la informacion</returns>
        public override string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{this.InformacionPersonal()}");
            sb.AppendLine($" Dinero disponible:${this.dineroEnBolsillo}");
            sb.AppendLine($" Paga con:{this.metodoDePago.ToString()}");

            return sb.ToString();
        }

        public static bool operator +(Cliente cliente, List<Cliente> listaClientes)
        {
            foreach (Cliente c in listaClientes)
            {
                if(cliente.Dni == c.Dni)
                {
                    return false;
                }
                else
                {
                    listaClientes.Add(cliente);
                    return true;
                }
            }
            return false;
        }
        public static bool operator -(Cliente cliente, List<Cliente> listaClientes)
        {
            foreach (Cliente c in listaClientes)
            {
                if (cliente.Dni == c.Dni)
                {
                    listaClientes.Remove(cliente);
                    return true;
                }
                
            }
            return false;
        }
        
        /// <summary>
        /// Validara que los datos ingresados del cliente sean correctos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="dinero"></param>
        /// <returns>retornara true si son todos validos, false sino</returns>
        public static bool ValidarDatosCliente(string nombre,string apellido, string dni, string dinero)
        {
            int auxDni;
            double auxDinero;
            if (nombre!=null && apellido != null && dni!=null && dinero!= null)
            {
                if (Comandos.IsAllLetters(nombre) && Comandos.IsAllLetters(apellido))
                {

                    if (double.TryParse(dinero,out auxDinero) && int.TryParse(dni,out auxDni))
                    {
                        return true;
                    }

                }

            }
            return false;

        }

       
        /// <summary>
        /// Mostrara la lista de compras completa, y calculara el valor total
        /// </summary>
        /// <returns>Retornara la informacion en formato</returns>
       public string InfoListaCompras()
       {
            StringBuilder sb = new StringBuilder();
            double valorTotal = 0;
            foreach (Producto p in this.ListaCompra)
            {
                sb.Append($"{p.Nombre} ");
                valorTotal += p.Valor;
            }
            sb.Append($" Precio total: ${valorTotal}");
            return sb.ToString();
       }

        /// <summary>
        /// Mostrara la lista de compras completa, y calculara el valor total
        /// </summary>
        /// <returns>Retornara la informacion en formato</returns>
        public string InfoTicket()
        {
            StringBuilder sb = new StringBuilder();
            double valorTotal = 0;
            foreach (Producto p in this.ListaCompra)
            {
                sb.AppendLine($"{p.Nombre} ${p.Valor}");
                valorTotal += p.Valor;
            }
            sb.AppendLine("___");
            sb.AppendLine($"Precio total: ${valorTotal}");
            return sb.ToString();
        }

        #endregion
    }
}
