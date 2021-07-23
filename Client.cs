using HHRRSystem.IO;
using HHRRSystem.Facade;
using System;
using System.Collections.Generic;
using System.Text;

namespace HHRRSystem
{
    class Client
    {
        private IOM IO = IOM.getIO();
        private CFacade system = new CFacade();


        public  void Start(){
           string acction = this.IO.Menu("Seleccione la accion que desea realizar", "Contratar", "Desvincular", "Pago", "Cancelar");
            if (acction == "1")
            {
                this.system.Contratar();
            }else if (acction == "2")
            {
                this.system.Desvincular();
            } else if(acction == "3")
            {
                this.system.Pago();
            }else if (acction == "4")
            {
                IO.emitir("Fracias");
                return;
            }
                Start();
        }
        
    }
}
