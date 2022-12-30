using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ejercicio 10:
using Exercise8.models;

namespace Exercise3.models
{
    class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        // Ejercicio 4;
        public int FechaDeNacimiento { get; set; }
        public int EdadPersona { get; set; }

        public void NombreCompleto()
        {
            Console.WriteLine(Nombre + " " + Apellido);
        }

        // Ejercicio 4;
        public void Edad()
        {
            int AñoActual = 2022;
            EdadPersona = AñoActual - FechaDeNacimiento;
        }


        // Ejercicio 10:
        public void ObtenerSmartPhone(string marca, string modelo, bool phoneState, int volumen, int brillo)
        {
            Smartphone smartphone = new Smartphone(marca, modelo, phoneState, volumen, brillo);
            smartphone.MostrarSmartPhone();
        }

    }
}
