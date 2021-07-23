using System;
using System.Collections.Generic;
using System.Text;
using HHRRSystem.Contabiliad;
using HHRRSystem.Interfaces;


namespace HHRRSystem.Facade
{
    class CFacade : IDesvinculo, IPago, IContratacion
    {
        private HR HR = HR.Get();
        private Nomina Nomina = Nomina.Get();
        public void Contratar()
        {
            this.HR.Contratar();
        }

        public void Desvincular()
        {
            this.HR.Desvincular();
        }

        public void Pago()
        {
            this.Nomina.Pago();
        }
    }
}
