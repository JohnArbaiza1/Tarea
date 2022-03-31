﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploLibro
{
    //Clase abstracta empleado
    internal abstract class Empleado
    {
        //Propiedades 
        private string primerNombre;
        private string apellidoPaterno;
        private string numeroSeguroSocial;

        //Constructor con tres parametros
        public Empleado(string nombre, string apellido, string nss)
        {
            primerNombre = nombre;
            apellidoPaterno = apellido; 
            numeroSeguroSocial = nss;
        }

        // propiedad de sólo lectura que obtiene el primer nombre del empleado
        public string PrimerNombre
        {
            get { return primerNombre; }
        }

        // propiedad de sólo lectura que obtiene el apellido paterno del empleado
        public string NumeroSeguroSocial
        {
            get { return numeroSeguroSocial; }
        }

        // devuelve la representación string del objeto Empleado, usando las propiedades
        public override string ToString()
        {
            return string.Format("{0} {1}\nnúmero de seguro social: {2}",
            PrimerNombre, apellidoPaterno, NumeroSeguroSocial);
        }

        // método abstracto redefinido por las clases derivadas
        public abstract decimal Ingresos(); // no hay implementación aquí


    }
}
