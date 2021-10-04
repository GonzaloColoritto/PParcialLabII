using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        string nombre;
        string apellido;
        int dni;

        #region Propiedades
        public string Nombre
        {
            get
            {
                if(this.nombre != null)
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
                if (value != null && value != "")
                {
                    this.nombre = value;
                }
                else
                {
                    this.nombre = "Desconocido";

                }
            }

        }

        public string Apellido
        {
            get
            {
                if (this.apellido != null)
                {
                    return this.apellido;
                }
                else
                {
                    return null;
                }

            }
            set
            {
                if(value != null && value != "")
                {
                    this.apellido = value;
                }
                else
                {
                    this.apellido = "Desconocido";

                }
            }

        }
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                if (value > 1000000 && value <99999999)
                {
                    this.dni = value;
                }
                else
                {
                    this.dni = 1000001;
                }
            }

        }
        #endregion

        #region Constructores
        public Persona()
        {
            nombre = null;
            apellido = null;
            dni = 0;
        }

        protected Persona(string nombre, string apellido, int dni):this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Retornara el nombre, apellido y el DNI de la persona
        /// </summary>
        /// <returns>Retornara los datos en formato</returns>
        public virtual string InformacionPersonal()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Nombre} {this.Apellido} DNI: {this.Dni.ToString()}");
           // sb.AppendLine($"");
            
            return sb.ToString();
        }

        public abstract string MostrarInfo();

        /// <summary>
        /// Sobrecarga del metodo ToString()
        /// </summary>
        /// <returns>Retornara el nombre y apellido</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Nombre} {this.Apellido}");

            return sb.ToString();
        }
        #endregion
    }
}
