using System;
using System.Collections.Generic;
using System.Text;
using HHRRSystem.Empleados;
using HHRRSystem.Interfaces;

namespace HHRRSystem.Contabiliad
{   //sigleton
    class Nomina : IPago, IIncentivo, IDescuento
    {
        private static Nomina Instance;
        private Nomina()
        {

        }
        public static Nomina Get()
        {
            if (Instance == null)
            {
                Instance = new Nomina();
            }
            return Instance;
        }
        public void AplicarIncentivo(Empleado empleado)
        {
            empleado.setIncentivo();
        }

        public void Descontar(Empleado empleado)
        {
            empleado.setDeduccion();
        }

        public void Pago()
        {
            Empleado.Personal.ForEach(empleado => empleado.pago());
        }
    }
}
