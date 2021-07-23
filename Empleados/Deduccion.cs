using HHRRSystem.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace HHRRSystem.Empleados
{
    class Deduccion
    {
        IOM IO = IOM.getIO();
        private string concepto;
        private double monto ;
        public Deduccion()
        {
            this.Monto = double.Parse(IO.capturar("Indique el monto a descontar"));
            this.Concepto = IO.capturar("Indique el concepto por el que este monto será descontado");

        }

        public double Monto { get => monto; set => monto = value; }
        public string Concepto { get => concepto; set => concepto = value; }
    }
}
