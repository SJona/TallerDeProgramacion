using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Cuenta
    {
        public double iSaldo;
        public Moneda iMoneda;

        /// <summary>
        /// Crea una cuenta con Saldo Inicial en 0
        /// </summary>
        /// <param name="pMoneda"></param>
        public Cuenta(Moneda pMoneda) : this(0, pMoneda) { }

        public Cuenta(double pSaldoInicial, Moneda pMoneda)
        {
            this.iSaldo = pSaldoInicial;
            this.iMoneda = pMoneda;
        }

        public double Saldo
        {
            get { return this.iSaldo; }
        }

        public void AcreditraSaldo(double pSaldo)
        {
            this.iSaldo += pSaldo;
        }

        public bool DebitarSaldo(double pSaldo)
        {
            if (this.iSaldo >= pSaldo)
            {
                this.iSaldo -= pSaldo;
                return true;
            }

            else { return false; }
        }


    }
}
