using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Herencia_e_Interfaces
{
    class EvaluadorEdad : IEvaluador
    {
        private int iEdadMinima, iEdadMaxima;

        public EvaluadorEdad(int pEdadMinima, int pEdadMaxima)
        {
            this.iEdadMaxima = pEdadMaxima;
            this.iEdadMinima = pEdadMinima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            DateTime fNacimiento = pSolicitud.Cliente.FechaNacimiento;
            int edad = DateTime.Today.AddTicks(-fNacimiento.Ticks).Year - 1;

            if (edad >= iEdadMinima && edad <= iEdadMaxima)
            { return true; }

            else { return false; }
        }
    }
}
