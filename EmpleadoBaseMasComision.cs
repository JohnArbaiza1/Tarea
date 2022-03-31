using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploLibro
{
    // La clase EmpleadoBaseMasComision que extiende a EmpleadoPorComision.
    internal class EmpleadoBaseMasComision : EmpleadoPorComision
    {
        private decimal salarioBase; // salario base por semana
        public EmpleadoBaseMasComision(string nombre, string apellido, string nss, decimal ventas,
        decimal tarifas,decimal salario) : base(nombre, apellido, nss, ventas, tarifas)
        {
            salarioBase = salario; // valida el salario base a través de una propiedad
        }

        /* propiedad que obtiene y establece
         el salario base del empleado por comisión con salario base */

        public decimal SalarioBase
        {
            get { return salarioBase; }

            set
            {
                salarioBase = (value >= 0) ? value : 0; // validación
            }
        }

        // calcula los ingresos; redefine el método Ingresos en EmpleadoPorComision
        public override decimal Ingresos()
        {
            return SalarioBase + base.Ingresos();
        }

        // devuelve representación string del objeto EmpleadoBaseMasComision
        public override string ToString()
        {
            return string.Format("{0} {1}; {2}: {3:C}",
            "salario base +", base.ToString(), "salario base", SalarioBase);
        }

    }
}
