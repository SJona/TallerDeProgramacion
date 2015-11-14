using System;
using System.IO;
namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string line;
                int counter = 0;
                Console.Write("Indique la dirección del archivo: ");
                string dir = Console.ReadLine(); // se almacena la ruta del archivo en la variable dir
                StreamReader file = new StreamReader(dir); 
                while ((line = file.ReadLine()) != null) //se lee linea a linea el contendido del archivo mientras allá información.
                {
                    System.Console.WriteLine(line);
                    counter++;
                }
            }
            catch (FileNotFoundException) //excepcion que se ejecuta cuando no es encontrado el archivo especificado.
            {
                Console.WriteLine("El archivo no existe, compruebe la ruta especificada.");
            }
            catch (ArgumentException) //excepcion que se ejecuta cuando no encuentra la ruta que se especifico.
            {
                Console.WriteLine("La ruta no fue especificada.");
            }
            catch (DirectoryNotFoundException) //Excepcion que se ejecuta cuando la direccion no es valida.
            {
                Console.WriteLine("La ruta especificada es invalida.");
            }
            Console.ReadLine();
        }
    }
}