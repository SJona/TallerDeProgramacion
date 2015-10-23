using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            FachadaMatematica fachada = new FachadaMatematica();
            Console.WriteLine("Programa para lanzar excepción de NO DIVIDIR POR CERO");

            Console.WriteLine("Ingrese el dividendo");
            int dividendo = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingrese el divisor");
            int divisor = Convert.ToInt16(Console.ReadLine());

            try
            {
                double resultado = fachada.Dividir(dividendo, divisor);
                Console.WriteLine("Resultado: {0}", resultado);
            }
            catch (DivisionPorCeroException porCero)
            {
                Console.WriteLine(porCero);
            }

            Console.ReadKey();
        }
    }
}
