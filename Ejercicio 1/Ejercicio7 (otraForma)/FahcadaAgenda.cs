using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7__otraForma_
{
    public class FachadaAgenda
    {
        public Agenda iAgenda = new Agenda("MiAgenda");

        public void CambiarNombreAgenda (String pNuevoNombre)
        {
            this.iAgenda.Nombre = pNuevoNombre;
        }

        public void AgregarCalendario(String pTitulo)
        {
            this.iAgenda.Calendarios.Add(new Calendario(pTitulo));
        }

        public Calendario BuscarCalendarioPorTitulo(String pTitulo)
        {
            return this.iAgenda.BuscarCalendario(pTitulo);
        }

        public void EliminarCalendario(String pTitulo)
        {
            Calendario cal = iAgenda.BuscarCalendario(pTitulo);
            iAgenda.EliminarCalendario(cal);
        }

        public void ModificarTituloCalendario(String pTituloViejo, String pTituloNuevo) // VER VER VER 
        {
             iAgenda.BuscarCalendario(pTituloViejo).Titulo = pTituloNuevo;
        }

        /// <summary>
        /// Método para agregar un evento a un calendario específico
        /// </summary>
        /// <param name="pTituloEvento">Título del evento</param>
        /// <param name="pFechaHora">Fecha y hora del evento</param>
        /// <param name="pDuracion">Duración del evento, en horas</param>
        /// <param name="pFrecuencia">Frecuencia del evento, en días, 0 única vez, 1 diaria, 7 semanal, 30 mensual, 365 anual</param>
        /// <param name="pCalendario"></param>
        public void AgregarEvento(String pTituloEvento, DateTime pFechaHora, int pDuracion, int pFrecuencia, Calendario pCalendario)
        {
            pCalendario.Eventos.Add(new Evento(pTituloEvento, pFechaHora, pDuracion, pFrecuencia));
        }

        public Evento BuscarEvento(String pTitulo, Calendario pCalendario)
        {
            return pCalendario.BuscarEvento(pTitulo);
        }

        public void EliminarEvento(String pTitulo, Calendario pCalendario)
        {
            pCalendario.Eventos.Remove(pCalendario.BuscarEvento(pTitulo));
        }

        public void ModificarTituloEvento(Evento pEvento, String pTituloNuevo)
        {
            pEvento.Titulo = pTituloNuevo;
        }

        public void ModificarDuracion(Evento pEvento, int pDuracion)
        {
            pEvento.Duracion = pDuracion;
        }

        public void ModificarFrecuencia(Evento pEvento, int pFrecuencia)
        {
            pEvento.Frecuencia = pFrecuencia;
        }

        public void ModificarFecha(Evento pEvento, DateTime pFechaHora)
        {
            pEvento.FechaHora = pFechaHora;
        }

    }
}
