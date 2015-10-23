using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Colecciones_y_Excepciones
{
    class CapaPersistencia
    {

        public void Ejecutar()
        {
            throw new ErrorPuntualExcepcion("Se ha producido un error puntual");
        }
    }
}
