﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Herencia_e_Interfaces
{
    class Empleo
    {
        private double iSueldo;
        private DateTime iFechaIngreso;

        public Empleo(double pSueldo, DateTime pFechaIngreso)
        {
            this.iSueldo = pSueldo;
            this.iFechaIngreso = pFechaIngreso;
        }

        public double Sueldo
        {
            get { return this.iSueldo; }
        }

        public DateTime FechaIngreso
        {
            get { return this.iFechaIngreso; }
        }
       
    }
}
