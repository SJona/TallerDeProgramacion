using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    /// <summary>
    /// Mantiene las instancias de Cuenta en pesos y en dólares, y permite recuperar las mismas
    /// </summary>
    class Cuentas
    {
        public Cuenta iCuentaEnDolares, iCuentaEnPesos;

        //Constructor
        public Cuentas()
        {
            this.iCuentaEnDolares = new Cuenta(new Moneda("123", "Dólar", "u$s"));
            this.iCuentaEnPesos = new Cuenta(new Moneda("321", "Peso", "AR$"));
        }


        //Propiedades
        public Cuenta CuentaEnPesos
        {
            get { return this.iCuentaEnPesos; }
        }

        public Cuenta CuentaEnDolares
        {
            get { return this.iCuentaEnDolares; }
        }


    }
}
