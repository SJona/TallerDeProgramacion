using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7__otraForma_
{
    public class Calendario
    {
        private String iTituloCalendario;
        private DateTime iFechaHora;
        private List<Evento> iEventos;
        

        public Calendario(String pTitulo)
        {
            this.iEventos = new List<Evento>();
            this.iTituloCalendario = pTitulo;
            this.iFechaHora = DateTime.Now;
        }

        public String Titulo
        {
            get { return this.iTituloCalendario; }
            set { this.iTituloCalendario = value; }
        }

        public DateTime Fecha
        {
            get { return this.iFechaHora.Date; }
        }

        public TimeSpan Hora
        {
            get { return this.iFechaHora.TimeOfDay; }
        }

        /// <summary>
        /// Devuelve la lista con los eventos creados para un calendario
        /// </summary>
        public List<Evento> Eventos
        {
            get { return this.iEventos; }
        }

        /// <summary>
        /// Agregar un evento al calendario
        /// </summary>
        /// <param name="pEvento"></param>
        public void AgregarEvento(Evento pEvento)
        {
            this.iEventos.Add(pEvento);
        }

        /// <summary>
        /// Devuelve el evento que tenga el titulo pasado como parámetro
        /// </summary>
        /// <param name="pTitulo">Titulo del evento buscado</param>
        /// <returns></returns>
        public Evento BuscarEvento(String pTitulo)
        {
            foreach (Evento ev in this.iEventos)
            {
                if (ev.Titulo == pTitulo)
                {
                    return ev;
                }
            }
            
            throw new EventoNoEncontradoException("El evento con dicho titulo no se ha encontrado");
        }


        public void EliminarEvento(String pTitulo)
        {
            this.iEventos.Remove(this.BuscarEvento(pTitulo));
        }

    }
}
