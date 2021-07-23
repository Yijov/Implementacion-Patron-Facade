using HHRRSystem.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace HHRRSystem.Empleados
{
    class Ingreso
    {
        IOM IO = IOM.getIO();
        private string concepto;
        private double monto;
        public string Concepto { get => concepto; set => concepto = value; }
        public double Monto { get => monto; set => monto = value; }
        public Ingreso()
        {
            this.Monto = double.Parse(IO.capturar("Indique el monto de ingreso"));
            this.Concepto = IO.capturar("Indique el concepto por el que este monto fue recibido");

        }

       
    }
}
