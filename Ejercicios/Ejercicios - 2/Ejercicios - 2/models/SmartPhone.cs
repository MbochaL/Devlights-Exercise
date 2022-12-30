using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8.models
{
    class Smartphone
    {
        public string Marca  { get; set; }
        public string Modelo { get; set;}
        public bool PhoneState { get; set; }
        public int Volumen { get; set; }
        public int Brillo { get; set; }


        public Smartphone(string marca, string modelo, bool phoneState, int volumen, int brillo)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.PhoneState = phoneState;
            this.Volumen = volumen;
            this.Brillo = brillo;
        }

        public void Encender()
        {
            PhoneState = true;
            Console.WriteLine("Tu SmartPhone esta encendido");
        }

        public void Apagar()
        {
            PhoneState = false;
            Console.WriteLine("Tu SmartPhone esta Apagado");
        }

        public void SubirVolumen()
        {
            if(Volumen <= 100)
            {
                Volumen += 10;
                Console.WriteLine("El Volumen de tu smartphone esta al: " + Volumen);
            } else
            {
                Console.WriteLine("El Volumen ya esta al maximo");
            }
        }

        public void BajarVolumen()
        {
            Volumen -= 10;
            if (Volumen == 0)
            {
                Console.WriteLine("El Brillo esta en 0");
            }
        }

        public void Silenciar()
        {
            Volumen = 0;
            Console.WriteLine("El Volumen de tu smartphone ha sido silenciado: " + Volumen);
        }

        public void SubirBrillo()
        {
            if (Brillo <= 100)
            {
                Brillo += 10;
                Console.WriteLine("El Brillo de tu smartphone esta al: " + Brillo);
            }
            else
            {
                Console.WriteLine("El Brillo ya esta al maximo");
            }
        }

        public void BajarBrillo()
        {
            Brillo -= 10;
            Console.WriteLine("El Brillo de tu smartphone esta al: " + Brillo);

            if (Brillo == 0)
            {
                Console.WriteLine("El Brillo esta en: " + Brillo);
            }
        }

        public void MostrarSmartPhone()
        {
            Console.WriteLine("Marca del SmartPhone: " + Marca + " | " + "Modelo del SmartPhone: " + Modelo);
        }
    }
}
