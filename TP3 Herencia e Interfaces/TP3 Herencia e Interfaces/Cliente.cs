using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Herencia_e_Interfaces
{
    class Cliente
    {
        private String iNombre, iApellido;
        private DateTime iFechaNacimiento;
        private TipoCliente iTipoCliente;
        private Empleo iEmpleo;

        public Cliente (String pNombre, String pApellido, DateTime pFechaNacimiento, Empleo pEmpleo, TipoCliente pTipoCliente)
        {
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iFechaNacimiento = pFechaNacimiento;
            this.iEmpleo = pEmpleo;
            this.iTipoCliente = 0;
        }

        //public Cliente (String pNombre, String pApellido, DateTime pFechaNacimiento, Empleo pEmpleo) : this(pNombre, pApellido, pFechaNacimiento, pEmpleo, 0);

        public String Nombre
        {
            get { return this.iNombre; }
        }

        public String Apellido
        {
            get { return this.iApellido; }
        }

        public DateTime FechaNacimiento
        {
            get { return this.iFechaNacimiento; }
        }

        public Empleo Empleo
        {
            get { return this.iEmpleo; }
        }

        public TipoCliente TipoCliente
        {
            get { return this.iTipoCliente; }
            set { this.iTipoCliente = value; }
        }
    }
}
