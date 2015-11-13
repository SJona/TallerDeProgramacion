using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7__otraForma_
{
    public class Evento
    {
        String iTituloEvento;
        DateTime iFechaHora;
        int iDuracion, iFrecuencia;

        /// <summary>
        /// Constructor de un evento
        /// </summary>
        /// <param name="pTituloEvento"></param>
        /// <param name="pDuracion">La duración del evento deberá estar dada en horas</param>
        /// <param name="pFrecuencia"></param>
        public Evento(String pTituloEvento, DateTime pFechaHora, int pDuracion, int pFrecuencia)
        {
            this.iTituloEvento = pTituloEvento;
            this.iFechaHora = pFechaHora;
            this.iDuracion = pDuracion;
            this.iFrecuencia = pFrecuencia;
        }

        public String Titulo
        {
            get { return this.iTituloEvento; }
            set { this.iTituloEvento = value; }
        }

        public int Duracion
        {
            get { return this.iDuracion; }
            set { this.iDuracion = value; }
        }

        /// <summary>
        /// La cantidad en días cada cuanto se repetirá el evento
        /// </summary>
        public int Frecuencia
        {
            get { return this.iFrecuencia; }
            set { this.iFrecuencia = value; }
        }

        public DateTime FechaHora
        {
            get { return this.iFechaHora; }
            set { this.iFechaHora = value; }
        }
    }
}
