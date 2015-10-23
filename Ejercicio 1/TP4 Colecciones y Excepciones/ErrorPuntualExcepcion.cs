using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Colecciones_y_Excepciones
{
    public class ErrorPuntualExcepcion : ApplicationException
    {
   
        DateTime iFechaHora;

        public ErrorPuntualExcepcion(String pMensaje) : base (pMensaje)
        {
            this.iFechaHora = DateTime.Now;
        }

        public override string ToString()
        {

            return (base.ToString() + "Fecha: " + Convert.ToString(iFechaHora.Date)
                + "Hora: " + Convert.ToString(iFechaHora.TimeOfDay));
        }

        /*public String Fecha
        {
            get { return Convert.ToString(iFechaHora.Date); }
        }

        public String Hora
        {
            get { return Convert.ToString(iFechaHora.TimeOfDay); }
        }
        */

    }
}
