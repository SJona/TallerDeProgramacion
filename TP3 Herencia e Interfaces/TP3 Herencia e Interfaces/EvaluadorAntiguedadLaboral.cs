using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Herencia_e_Interfaces
{
    class EvaluadorAntiguedadLaboral : IEvaluador
    {
        private int iAntiguedadMinima;

        public EvaluadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            this.iAntiguedadMinima = pAntiguedadMinima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            DateTime fIngreso = pSolicitud.Cliente.Empleo.FechaIngreso;   //Fecha de ingreso del cliente
            DateTime fIngresoMasSeis = fIngreso.AddMonths(6);             //fIngresoMasSeis es fIngreso aumentada en seis meses (cantidad de meses de antiguedad necesaria)

            if (DateTime.Compare(fIngresoMasSeis, DateTime.Today) >= 0)
            { return true; }

            else { return false; }
        }
    }
}
