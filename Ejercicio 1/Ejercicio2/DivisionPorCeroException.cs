using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class DivisionPorCeroException : Exception
    {
        DateTime iFechaHora;

        /// <summary>
        /// Excepción que trata la division por cero
        /// </summary>
        /// <param name="pMensaje"></param>
        public DivisionPorCeroException(String pMensaje) : base (pMensaje)
        {
            this.iFechaHora = DateTime.Now;
        }

        public override string ToString()
        {

            return (base.ToString() + "Fecha: " + Convert.ToString(iFechaHora.Date)
                + "Hora: " + Convert.ToString(iFechaHora.TimeOfDay));
        }
    }
}
