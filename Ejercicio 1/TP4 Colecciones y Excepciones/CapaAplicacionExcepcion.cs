﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Colecciones_y_Excepciones
{
    public class CapaAplicacionExcepcion : ApplicationException
    {

        public CapaAplicacionExcepcion(String pMensaje, Exception pExc) : base(pMensaje, pExc)
        {

        }
    }
}
