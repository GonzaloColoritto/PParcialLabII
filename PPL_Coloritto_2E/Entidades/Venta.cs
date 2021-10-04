using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        Cliente cliente;
        Trabajador realizadorVenta;
        double precioTotal;
        
        public Venta(Cliente cliente, Trabajador realizadorVenta, double precioTotal)
        {
            this.Cliente = cliente;
            this.RealizadorVenta = realizadorVenta;
            this.PrecioTotal = precioTotal;
        }

        /// <summary>
        /// Retornara la venta en cuestion casteandolo a string
        /// </summary>
        /// <returns></returns>
        public string InformacionVenta()
        {
            return (string)this;
        }
         #region Propiedades
        public Cliente Cliente
        {
            get
            {
                return this.cliente;
            }
            set
            {
                    this.cliente = value;
            }
        }

        public Trabajador RealizadorVenta
        {
            get
            {
                return this.realizadorVenta;
            }
            set
            {
                this.realizadorVenta = value;
            }
        }

        public double PrecioTotal
        {
            get
            {
                return this.precioTotal;
            }
            set
            {
                if (value > 0)
                {
                    this.precioTotal = value;
                }
            }
        }
#endregion
        /// <summary>
        /// Generara un stringbuilder con la info necesaria de la venta
        /// </summary>
        /// <param name="v"></param>
        public static explicit operator string(Venta v)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Cliente:{v.Cliente.ToString()}  Realizo la venta:{v.RealizadorVenta.ToString()}  Productos comprados:{v.Cliente.InfoListaCompras()}");
           
            return sb.ToString();
        }
    }
}
