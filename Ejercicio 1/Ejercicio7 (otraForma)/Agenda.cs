using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7__otraForma_
{
    public class Agenda
    {

        private List<Calendario> iCalendarios;
        private String iNombre;

        public Agenda(String pNombre)
        {
            this.iCalendarios = new List<Calendario>();
            this.iNombre = pNombre;
        }

        public String Nombre
        {
            get { return this.iNombre; }
            set { String viejo = this.iNombre;
                  this.iNombre.Replace(viejo, value); }
        }

        public List<Calendario> Calendarios
        {
            get { return this.iCalendarios; }
        }

        public Calendario BuscarCalendario(String pTitulo)
        {
            foreach (Calendario cal in this.iCalendarios)
            {
                if ((String.Compare(cal.Titulo, pTitulo) == 0))
                {
                    return cal;
                }
            }

            throw new CalendarioNoEncontradoException("No se encontró ningún calendario con el título ingresado");
        }

        public void AgregarCalendario(Calendario pCalendario)
        {
            this.iCalendarios.Add(pCalendario);
        }

        public void EliminarCalendario(Calendario pCalendario)
        {
            this.iCalendarios.Remove(pCalendario);
        }


    }
}
