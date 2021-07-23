using HHRRSystem.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace HHRRSystem.Empleados
{
    class Vacaciones
    {
        IOM IO = IOM.getIO();
        private DateTime fechaInicio { get; set; }
        private DateTime fechaFin { get; set; }

        public Vacaciones()
        {
            int dias = int.Parse(IO.capturar("Indique la cantidad de dias para las vacaciones"));
            this.fechaInicio = DateTime.Now;
            this.fechaFin = fechaInicio.AddDays(dias);
            IO.emitir("las vacaciones de este empleado inician el dia de hoy y finalizan en  " + this.fechaFin);
        }
    }
}
