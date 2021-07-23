using System;
using System.Collections.Generic;
using System.Text;

namespace HHRRSystem.Empleados
{
    class Empleado
    {
        public static List<Empleado> Personal = new List<Empleado>();
        public enum Status
        {
            INACTIVO,
            ACTIVO,
            VACACIONES,
            SUSPENDIDO,
            DESAUCIADO,
            RENUNCIA,
            PERMISO,
            LICENCIA,
        }

        public enum Tipos
        {
            FIJO,
            CANDIDATO,
            CONTRATISTA
        }
        
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Departamento { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public string Apellido { get; set; }
        public Status StatusActual { get; set; }
        public Tipos Tipo { get; set; }
        private Vacaciones vacaciones { get; set; }
        private List<Ingreso> otrosIngresos = new List<Ingreso>();
        private List<Deduccion> deducciones = new List<Deduccion>();

        public Empleado() { }
      
        public void pago()
        {
            string fromat = " Nombre: {0} \n Departamento: {1} \n Salario: {2} \n Otros ingresos: {3} \n AFP: {4} \n ARS: {5} \n Otros descuentos: {6} \n Sueldo neto: {7} ";
            Console.WriteLine(fromat, this.Nombre + " " + this.Apellido, this.Departamento, this.Salario, this.getIncentivo(), this.getAFP(), this.getARS(), this.getDeduccion(), this.getSueldoNeto());
        }
         public double getAFP()
        {
            return this.Salario * 0.287;
        }
        public double getARS()
        {
            return this.Salario * 0.301;
        }
        public void  setVacaciones()
        {
           this.vacaciones = new Vacaciones();
        }

        public void setIncentivo()
        {
            this.otrosIngresos.Add(new Ingreso());
        }
        public void setDeduccion()
        {
            Deduccion toAdd = new Deduccion();
            this.deducciones.Add(toAdd);
        }

        public double getIncentivo()
        {
            double result=0.0;
            otrosIngresos.ForEach(ing => result += ing.Monto);
            return result;
        }
        public double getDeduccion()
        {
            double result=0.0;
            deducciones.ForEach(ing => result += ing.Monto);
            return result;
        }

        public double getSueldoNeto()
        {
            return this.Salario - this.getDeduccion() + this.getIncentivo();
        }
    }
}
