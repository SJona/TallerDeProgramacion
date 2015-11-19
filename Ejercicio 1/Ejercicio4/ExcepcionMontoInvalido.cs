using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class ExcepcionMontoInvalido : Exception
    {
        DateTime iFechaHora;

        public ExcepcionMontoInvalido(String pMensaje) : base (pMensaje)
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
