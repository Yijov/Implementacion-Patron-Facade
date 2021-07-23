using HHRRSystem.Empleados;
using HHRRSystem.Interfaces;
using HHRRSystem.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace HHRRSystem // aplicando singleton
{ 
    class HR : IContratacion, IDesvinculo, IPermiso, IVacaciones
    {
        private IOM IO = IOM.getIO();
        private static HR Instance;
        
        private HR()
        {

        }
        public static HR Get()
        {
            if (Instance == null)
            {
                Instance = new HR();
            }
            return Instance;
        }
        public void AplicarVacaciones()
        {
            Empleado empleado = buscarPorCedula();
            string confirm = IO.Menu("Se asignara vacaciones a " + empleado.Nombre + " " + empleado.Apellido, "Confirmar", "Cancelar");
            if (confirm == "1")
            {
                empleado.setVacaciones();
                empleado.StatusActual = Empleado.Status.VACACIONES;
            }
            else
            {
                IO.emitir("Proceso cancelado");
            }
            
            
        }

        public void Contratar()
        {
            Empleado nuevo = new Empleado();
            nuevo.Nombre= IO.capturar("Indique el nombre del Candidato");
            nuevo.Apellido = IO.capturar("Indiqque el apellido de "+ nuevo.Nombre);
            nuevo.Cedula = IO.capturar("Indiqque la cedula sin guiones de " + nuevo.Nombre +" " + nuevo.Apellido);
            nuevo.Cargo = IO.capturar("Indiqque el cargo de " + nuevo.Nombre + " " + nuevo.Apellido);
            nuevo.Departamento = IO.capturar("¿En que Departamento estará laborando " + nuevo.Nombre + " " + nuevo.Apellido +"?");
            nuevo.Salario = double.Parse(IO.capturar("Indiqque el salario a devengar de " + nuevo.Nombre + " " + nuevo.Apellido));
            Empleado.Personal.Add(nuevo);
        }

        public void Desvincular()
        {
            Empleado empleado = buscarPorCedula();
            string confirm = IO.Menu("Desvinculando a " + empleado.Nombre + " "  + empleado.Nombre, "confirmar", "Cancelar");
            if(confirm== "1")
            {
                empleado.StatusActual = Empleado.Status.DESAUCIADO;
                IO.emitir("El empleado " + empleado.Nombre + " " + empleado.Nombre + " ha sido desauciado");

            }
            else
            {
                IO.emitir("Peoceso cancelado");
            }
            
        }

        public void OtorgarPermiso(Empleado empleado)
        {
            empleado.StatusActual = Empleado.Status.PERMISO;
        }

        private Empleado buscarPorCedula()
        {
            string cedula = IO.capturar("Indique la cédula del Empleado");
            Empleado empleado = Empleado.Personal.Find(emp => emp.Cedula == cedula);
            return empleado;
        }
    }
}
