using Exercise11.models;
using Exercise3.models;
using Exercise6.models;
using Exericise12.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5.models
{
    class Auto : Persona
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }

        // Ejercicio 9:
        public bool AutoState { get; set; }

        public int Velocidad = 0;


        // Ejercicio 11:
        public Conductor Conductor = new Conductor() { Nombre = "Martin", Apellido = "Bosch", FechaDeNacimiento = 2001, ConductorState = true };


        // Ejercicio 12:
        public int Capacity { get; set; }
        public int CantidadPasajeros = 0;
        public Pasajeros Pasajero;

        // Ejericico 13:
        public int Posicion { get; set; } = 0;

        Mascota mascota = new Mascota() { NombreMascota = "zoe", TamañoMascota = "Pequeño" };



        public void MostrarAuto()
        {
            Console.WriteLine(" Modelo: " + Modelo + " Marca: " + Marca + " Color: " + Color);
        }

        public void EncenderMotor()
        {
            Conductor.Edad();
            // Ejercicio 11:

            /* 
              Si el conductor es menor de edad, no se puede
             encender el auto al no contar como un conductor
             acto.
            */

            if (Conductor.EdadPersona > 18)
            {
                CantidadPasajeros += 1;
                AutoState = true;
                Console.WriteLine("El motor esta encendido");
            } else if( CantidadPasajeros > Capacity)
            {
                Console.WriteLine("No puede encender el motor, verifique que el auto no sobrepase su capacidad de pasajeros");
            } else
            {
                Console.WriteLine("No puede encender el motor, verifique que tenga un conductor o que el conductor sea mayor de edad");
            }
        }

        public void ApagarMotor()
        {
            AutoState = false;
            Console.WriteLine("El motor esta apagado");

        }


        // Ejercicio 9:
        public void MostrarVelocidad()
        {
            Console.WriteLine("La velocidad del auto es de: " + Velocidad);
        }

        public void Acelerar()
        {
            if(AutoState == true)
            {
                do
                {
                    Velocidad += 10;
                    MostrarVelocidad();
                } while(Velocidad < 100);

            } else
            {
                Console.WriteLine("Debe encender el auto primero para poder acelerar");
            }
        }

        public void Frenar()
        {
            if (AutoState == true)
            {
                Velocidad -= 20;
                Console.WriteLine("La velocidad del auto es de: " + Velocidad);
            }
        }
        

        // Ejercicio 12:
        public void EntraPasajeros(Pasajeros pasajero)
        {
            CantidadPasajeros += 1;

            if(CantidadPasajeros == Capacity)
            {
                Console.WriteLine("Tu auto esta lleno: " + CantidadPasajeros);
            } else if(CantidadPasajeros > Capacity)
            {
                Console.WriteLine("Demasiados Pasajeros retire alguno");
            } else
            {
                Console.WriteLine("Todavia hay espacio pueden entrar: " + (Capacity - CantidadPasajeros));
            }
        }

        public void EntraMascota()
        {
            if(mascota.TamañoMascota == "Grande" | mascota.TamañoMascota == "Mediano")
            {
                CantidadPasajeros += 1;
                Console.WriteLine("Tu mascota ha entrado al auto, es muy grande asi que ocupara un espacio");
            } else if(CantidadPasajeros == Capacity)
            {
                Console.WriteLine("El auto esta lleno, tu mascota no puede subir");
            } else
            {
                Console.WriteLine("Tu mascota puede entra al auto en el regazo de alguien");
            }
        }

        // Ejercicio 13:
        public void ChangePosition( int PosicionMascota)
        {
            Posicion = PosicionMascota;
        }

        public void TrackingMascota(int Posicion)
        {
           if(mascota.TamañoMascota == "Pequeño")
            {
                switch (Posicion)
                {
                    case 1:
                        Console.WriteLine("Este es el asiento del conductor, no puedes poner a tu mascota aqui. Coloca un Numero del 2 al 5");
                        break;
                    case 2:
                        Console.WriteLine("Se encuentra en el regazo del pasajero copiloto del conductor");
                        break;
                    case 3:
                        Console.WriteLine("Se encuentra en el regazo del pasajero trasero lado izquierdo");
                        break;
                    case 4:
                        Console.WriteLine("Se encuentra en el regazo del pasajero trasero en el Medio");
                        break;
                    case 5:
                        Console.WriteLine("Se encuentra en el regazo del pasajero trasero lado Derecho");
                        break;

                    default:
                        Console.WriteLine("Coloca un Numero del 2 al 5");
                        break;
                }
            } else
            {
                Console.WriteLine("Tu Perro es muy grande, no esta en el regazo de nadie");
            }
        }


        // Ejercicio 14:

        public void BajarPasajeros()
        {
            if(Velocidad == 0 && Conductor.ConductorState == true)
            {
                Console.WriteLine("Todos los Pasajeros se bajaron del Auto, pero el conductor debe apagar el auto antes de bajar"); 
            } else
            {
                Console.WriteLine("Debe frenar y bajar su velocidad a 0, en este momento su velocidad es de: " + Velocidad);
            }
        }
    }
}
