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
            if (Math.Abs(pSaldo) != pSaldo) { throw new ExcepcionMontoInvalido("El saldo ingresado no puede ser negativo"); }

            this.iSaldo += pSaldo;
        }

        public bool DebitarSaldo(double pSaldo)
        {
            bool resul = false;

            if (this.iSaldo == 0) { throw new ExcepcionSinSaldo ("Su cuenta no posee saldo actualmente"); }

            if (this.iSaldo < pSaldo) { throw new ExcepcionSaldoInsuficiente("Es imposible hacer el débito, el saldo es insuficiente"); }

            else
            {
                this.iSaldo -= pSaldo;
                resul = true;
            }
            return resul;
        }

    }
}
