using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public sealed class Archivador
    {
        private readonly string ruta;

        #region Constructores
        public Archivador(string path)
        {
            this.ruta = path;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Creara un txt con la informacion de una venta
        /// </summary>
        /// <param name="text"></param>
        public void CrearTicket(string text)
        {
            StreamWriter writer = null;

            try
            {
                
                    writer = new StreamWriter(this.ruta, false);
                    writer.WriteLine(text);
                    writer.WriteLine("Hora de compra: " + DateTime.Now);
                    writer.WriteLine("---");
                
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }

        }
        #endregion

    }
}
