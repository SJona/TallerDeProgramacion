using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Colecciones_y_Excepciones
{
    class CapaAplicacion
    {
        public void Ejecutar()
        {
            CapaDominio instancia = new CapaDominio();
            try
            {
                instancia.Ejecutar();
            }
            catch (ErrorPuntualExcepcion errorPuntual)
            {
                throw new CapaAplicacionExcepcion("Error Genérico", errorPuntual);
            }
           
        }
    }
}
