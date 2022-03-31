using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploLibro
{
    // La clase EmpleadoPorHoras que extiende a Empleado.
    internal class EmpleadoPorHoras : Empleado
    {
        private decimal sueldo; // sueldo por hora
        private decimal horas; // horas trabajadas durante la semana

        // constructor con cinco parámetros
        public EmpleadoPorHoras(string nombre, string apellido, string nss,
         decimal sueldoPorHoras, decimal horasTrabajadas) : base(nombre, apellido, nss)
        {
         sueldo = sueldoPorHoras; // valida el sueldo por horas a través de una propiedad
         horas = horasTrabajadas; // valida las horas trabajadas a través de una propiedad
        }

        // propiedad que obtiene y establece el sueldo del empleado por horas
        public decimal Sueldo
        {
            get { return sueldo; }

            set
            {
                sueldo = (value >= 0) ? value : 0; // validación
            }
        }

        // propiedad que obtiene y establece las horas del empleado por horas
        public decimal Horas
        {
            get { return horas; }

            set
            {
              horas = ((value >= 0) && (value <= 168)) ? value : 0; // validación
            }
        }

        // calcula los ingresos; redefine el método abstracto Ingresos de Empleado
        public override decimal Ingresos()
        {
           if(horas < 40) // no hay tiempo extra
            {
                return Sueldo * Horas;
            }
            else
            {
                return (40 * Sueldo) + ((Horas - 40) * Sueldo * 1.5M);
            }
        }

        // devuelve la representación string del objeto EmpleadoPorHoras
        public override string ToString()
        {
            return string.Format("empleado por horas: {0}\n{1}: {2:C}; {3}: {4:F2}",
            base.ToString(), "sueldo por horas", Sueldo, "horas trabajadas", Horas);
        }

    }
}
