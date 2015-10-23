using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Moneda
    {
        private string iCodigoISO, iNombre, iSimbolo;

        public Moneda(string pCodigoIso, string pNombre, string pSimbolo)
        {
            this.iCodigoISO = pCodigoIso;
            this.iNombre = pNombre;
            this.iSimbolo = pSimbolo;
        }

        public string CodigoISO
        {
            get { return this.iCodigoISO; }
        }

        public string Nombre
        {
            get { return this.iNombre; }
        }

        public string Simbolo
        {
            get { return this.iSimbolo; }
        }


    }
}
