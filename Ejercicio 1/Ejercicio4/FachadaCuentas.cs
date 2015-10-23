using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class FachadaCuentas
    {
        public double MostrarSaldo(Cuenta pCuenta)
        {
            return pCuenta.iSaldo;
        }

        public void AcreditarSaldo(Cuenta pCuenta, double pSaldo)
        {
            pCuenta.AcreditraSaldo(pSaldo);
        }

        public void DebitarSaldo(Cuenta pCuenta, double pSaldo)
        {
            pCuenta.DebitarSaldo(pSaldo);
        }
    }
}
