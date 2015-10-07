using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Herencia_e_Interfaces
{
    class GestorPrestamos
    {
        private IDictionary<TipoCliente, IEvaluador> iEvaluadoresPorCliente;

        public GestorPrestamos()
        {
            this.iEvaluadoresPorCliente = new Dictionary<TipoCliente, IEvaluador>();

            //this.iEvaluadoresPorCliente.Add(TipoCliente.Cliente, new EvaluardorCompuesto());
            this.iEvaluadoresPorCliente[TipoCliente.Cliente] = new EvaluadorCompuesto();
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return this.iEvaluadoresPorCliente[pSolicitud.Cliente.TipoCliente].EsValida(pSolicitud);
        }
    }
}
