using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploLibro
{
    // La clase EmpleadoAsalariado que extiende a Empleado.
    internal class EmpleadoAsalariado : Empleado
    {
        private decimal salarioSemanal;

        // constructor con cuatro parámetros
        public EmpleadoAsalariado(string nombre, string apellido, string nss,
        decimal salrio):base(nombre, apellido, nss)
        {
            salarioSemanal = salrio;//Se valida el salario a través de una propiedad
        }

        // propiedad que obtiene y establece el salario del empleado asalariado
        public decimal SalarioSemanal
        {
            get { return salarioSemanal; }

            set
            {
                salarioSemanal = ((value >= 0) ? value : 0);//Validacion
            }
        }

        //Se calculan los ingresos; redefine el método abstracto Ingresos en Empleado
        public override decimal Ingresos()
        {
           return salarioSemanal;
        }

        // devuelve la representación string del objeto EmpleadoAsalariado
        public override string ToString()
        {
         return string.Format("empleado asalariado: {0}\n{1}: {2:C}",
         base.ToString(), "salario semanal", SalarioSemanal);
        }

    }
}
