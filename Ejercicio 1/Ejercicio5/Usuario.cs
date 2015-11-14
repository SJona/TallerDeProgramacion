using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Usuario
    {
        private string iCodigo;
        private string iNombreCompleto;
        private string iCorreoElectronico;

        public string Codigo {
            get { return this.iCodigo; }
            set { iCodigo = value; }
        }

        public string NombreCompleto {
            get { return this.iNombreCompleto; }
            set { iNombreCompleto = value; }
        }

        public string CorreoElectronico {
            get { return this.iCorreoElectronico; }
            set { iCorreoElectronico = value; }
        }

        public IDictionary<string,Usuario> Usuarios{
            get; set;
            }
    }
}
