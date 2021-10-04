using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum TipoProducto
    {
        Juguete,
        Comida,
        Camas,
        Cuidado
    }
    public class Producto
    {
        string nombre;
        double valor;
        int cantidadEnStock;
        TipoProducto tipo;

        #region Constructores
        public Producto()
        {
            nombre = null;
            valor = double.MinValue;
            cantidadEnStock = 0;
            
        }
        public Producto(string nombre, double valor, int cantidadEnStock, TipoProducto tipo):this()
        {
            this.nombre = nombre;
            this.valor = valor;
            this.cantidadEnStock = cantidadEnStock;
            this.tipo = tipo;
        }

        #endregion


        #region Propiedades
        public string Nombre
        {
            get
            {
                if (nombre != null)
                {
                    return this.nombre;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value != null)
                {
                    this.nombre = value;
                }
            }
        }
        public int CantidadStock
        {
            get
            {
                if (cantidadEnStock >= 0)
                {
                    return this.cantidadEnStock;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                this.cantidadEnStock = value;
            }
        }
        public double Valor
        {
            get
            {
                if (this.valor > 0)
                {
                    return this.valor;
                }
                else
                {
                    return double.MinValue;
                }
            }
            set
            {
                if (value > 0)
                {
                    this.valor = value;
                }
                else
                {
                    this.valor = 40;
                }
            }
        }

        public TipoProducto Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        #endregion

        /// <summary>
        /// Mostrara la informacion del producto
        /// </summary>
        /// <returns>Retornara la informacion del producto en un formato</returns>
        public string InfoProducto()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{this.Nombre} {this.Tipo} ${this.Valor} Disponibles: {this.CantidadStock}");

            return sb.ToString();
        }
    }
}
