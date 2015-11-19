using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            FachadaCuentas fachadaCuentas = new FachadaCuentas();
            Byte cuenta;
 
            do
            {
                Console.WriteLine("Manejo de Cuenta Bancaria");
                Console.WriteLine("");
                Console.WriteLine("Elija la cuenta a consultar");
                Console.WriteLine("1-Cuenta en pesos | 2-Cuenta en dólares | 0-Salir");
                cuenta = Convert.ToByte(Console.ReadLine());
                switch (cuenta)
                {
                    case 1:
                        {
                            MenuSaldos(fachadaCuentas, cuenta);
                            break;
                        }

                    case 2:
                        {
                            MenuSaldos(fachadaCuentas, cuenta);
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Número ingresado incorrecto");
                            break;
                        }

                }
                Console.Clear();

            } while (cuenta != 0);

        }


        /// <summary>
        /// Menú para las operaciones a realizar sobre el saldo de la cuenta bancaria
        /// </summary>
        /// <param name="fachada"></param>
        /// <param name="pCuenta"></param>
        private static void MenuSaldos(FachadaCuentas pFachada, Byte pCuenta)
        {
            Console.WriteLine("Elija la operación deseada: 1-Mostrar Saldo  2-Acreditar Saldo  3-Debitar Saldo");
            Byte op = Convert.ToByte(Console.ReadLine());

            switch (op)
            {
                case 1:
                    {
                        if (pCuenta == 2) { Console.WriteLine("El saldo de la cuenta es de {0}", pFachada.MostrarSaldoCuentaDolares()); }
                        if (pCuenta == 1) { Console.WriteLine("El saldo de la cuenta es de {0}", pFachada.MostrarSaldoCuentaPesos()); }
                        break;
                    }

                case 2:
                    {
                        Console.Write("Ingrese el monto a acreditar: ");
                        double monto = Convert.ToDouble(Console.ReadLine());

                        if (pCuenta == 2) { pFachada.AcreditarSaldoCuentaDolares(monto); }
                        if (pCuenta == 1) { pFachada.AcreditarSaldoCuentaPesos(monto); }
                        break;
                    }

                case 3:
                    {
                        Console.Write("Monto a debitar: ");
                        double monto = Convert.ToDouble(Console.ReadLine());
                        try
                        {
                            if (pCuenta == 2) { pFachada.DebitarSaldoCuentaDolares(monto); }
                            if (pCuenta == 1) { pFachada.DebitarSaldoCuentaPesos(monto); }
                        }
                        catch (ExcepcionSinSaldo e)
                        { Console.WriteLine(e); }

                        catch (ExcepcionSaldoInsuficiente e)
                        { Console.WriteLine(e); }
                        break;
                    }

                case 0:
                    {
                        Environment.Exit(0);
                        break;
                    }
            }

            Console.ReadKey();
        }
        //Fin de método "MenuSueldo"

    }
}
