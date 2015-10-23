using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Colecciones_y_Excepciones
{
    class CapaVista
    {
        public void Ejecutar()
        {
            CapaControlador instancia = new CapaControlador();
            try
            {
                instancia.Ejecutar();
            }
            catch (CapaAplicacionExcepcion e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
