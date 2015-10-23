using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Colecciones_y_Excepciones
{
    class CapaDominio
    {
        public void Ejecutar()
        {
            CapaPersistencia instancia = new CapaPersistencia();
            instancia.Ejecutar();
        }
    }
}
