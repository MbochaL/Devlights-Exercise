using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6.models
{
    class Mascota
    {
        public string NombreMascota { get; set; }
        public string TipoMascota { get; set; }

        // Ejercicio 7:
        public int EnergiaMascota { get; set; }

        // Ejercicio 13:
        public string TamañoMascota { get; set; }

        public void Alimentar()
        {
            EnergiaMascota += 30;

            if(EnergiaMascota <= 100) 
            {
                Console.WriteLine("Tu mascota esta al " + EnergiaMascota + " llena");
                Console.WriteLine("Puedes seguir Alimentandola");
            } else
            {
                Console.WriteLine("Tu mascota ya esta llena");
            }
        }

        // Ejercicio 7:
        public void Correr()
        {
            if(EnergiaMascota > 20)
            {
                EnergiaMascota -= 10;
                Console.WriteLine("Tu mascota esta corrienda, le queda de energia " + EnergiaMascota);
            } else if(EnergiaMascota <= 20) 
            {
                Console.WriteLine("Tu mascota esta cansada, alimentala");
            }
        }

    }
}
