using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Matematica
    {
        /// <summary>
        /// Realiza división de dos números enteros
        /// </summary>
        /// <param name="pDividendo">Número a dividir</param>
        /// <param name="pDivisor">Número que divide</param>
        /// <returns></returns>
        public static double Dividir(int pDividendo, int pDivisor)
        {
            if (pDivisor == 0)
            {
                throw new DivisionPorCeroException("El dividendo no puede ser 0 (cero)");
            }

            else { return pDividendo / pDivisor; }
        }
    }
}
