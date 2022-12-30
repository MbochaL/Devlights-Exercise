using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.models
{
    class Guia
    {
        public void ejercicio1()
        {
            Console.Write("Ingrese un valor mayor o menor a 100:");

            var value = Console.ReadLine();
            int num;
            Int32.TryParse(value, out num);

            if (num > 100)
            {
                Console.WriteLine("El valor es mayor a 100");
            }
            else
            {
                Console.WriteLine("El valor es menor o igual a 100");
            }
        }

        public void ejercicio2()
        {
            Console.Write("Ingrese un valor:");

            var value2 = Console.ReadLine();
            int num2;
            Int32.TryParse(value2, out num2);

            if ((num2 % 2) == 0)
            {
                Console.WriteLine("ES PAR");
            }
            else if ((num2 % 3) == 0)
            {
                Console.WriteLine("ES IMPAR");
            }
            else
            {
                Console.WriteLine("Indefinido");
            }
        }

        public void ejercicio3()
        {
            Console.Write("Ingrese un valor:");

            var value3 = Console.ReadLine();
            int num3;
            Int32.TryParse(value3, out num3);

            if ((num3 / 3) % 2 == 0)
            {
                Console.WriteLine("Cumple esta condicion");
            }
            else
            {
                Console.WriteLine("No cumple esta condicion");
            }
        }

        public void ejercicio4()
        {
            Console.Write("Ingrese un valor:");
            var value4 = Console.ReadLine();
            int num4;
            Int32.TryParse(value4, out num4);

            switch (num4)
            {
                case 1:
                    Console.WriteLine("1 es igual a I en numero romano");
                    break;
                case 2:
                    Console.WriteLine("2 es igual a II en numero romano");
                    break;
                case 3:
                    Console.WriteLine("3 es igual a III en numero romano");
                    break;
                case 4:
                    Console.WriteLine("4 es igual a IV en numero romano");
                    break;
                case 5:
                    Console.WriteLine("5 es igual a V en numero romano");
                    break;
                case 6:
                    Console.WriteLine("6 es igual a VI en numero romano");
                    break;
                case 7:
                    Console.WriteLine("7 es igual a VII en numero romano");
                    break;
                case 8:
                    Console.WriteLine("8 es igual a VIII en numero romano");
                    break;
                case 9:
                    Console.WriteLine("9 es igual a IX en numero romano");
                    break;
                case 10:
                    Console.WriteLine("10 es igual a X en numero romano");
                    break;
                default:
                    break;
            }
        }

        public void ejercicio5()
        {
            string persona1 = "Martin";
            string persona2 = "Juan";

            Console.Write("Ingrese las edades:");

            var value1 = Console.ReadLine();
            int edad1;
            Int32.TryParse(value1, out edad1);

            var value2 = Console.ReadLine();
            int edad2;
            Int32.TryParse(value2, out edad2);

            if (edad1 < edad2)
            {
                Console.WriteLine(persona1);
            }
            else if (edad2 < edad1)
            {
                Console.WriteLine(persona2);
            }
            else
            {
                Console.WriteLine("Ambos tienen el mismo valor");
            }
        }

        public void ejercicio6()
        {
            //Lados del triangulo:
            double l1, l2, l3;
            Console.Write("Primer Lado: ");
            l1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Segundo Lado: ");
            l2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tercer Lado: ");
            l3 = Convert.ToDouble(Console.ReadLine());

            //Perimetro del triangulo:

            double perimetro = l1 + l2 + l3;
            Console.WriteLine($"{perimetro} cm");

            //Vemos que tipo de triangulo es:

            if (l1 == l2 && l1 == l3)
            {
                Console.WriteLine("Es Equilatero");
            }
            else if (l1 == l2 || l1 == l3 || l3 == l2)
            {
                Console.WriteLine("Es Isoseles");
            }
            else if (l1 != l2 || l2 != l3 || l3 != l1)
            {
                Console.WriteLine("Es Escaleno");
            }

            //Calculamos el area de un triangulo:

            Console.Write("Introduzca la base del triangulo:");
            int base_t = int.Parse(Console.ReadLine());
            Console.Write("Introduzca la altura del triangulo:");
            int altura = int.Parse(Console.ReadLine());
            double area = (base_t * altura) / 2;
            Console.Write("El area del triangulo es: " + area + " cm²");
        }

        public void ejercicio7()
        {
            float CAN;
            int B1000, B500, B200, B100, B50, B20, B10, B5, B2, B1;
            B1000 = 0;
            B500 = 0;
            B200 = 0;
            B100 = 0;
            B50 = 0;
            B20 = 0;
            B10 = 0;
            B5 = 0;
            B2 = 0;
            B1 = 0;

            string linea;
            Console.Write("Indica una cantidad :");
            linea = Console.ReadLine();

            CAN = float.Parse(linea);
            Console.Write("La Cantidad introducida es: " + CAN);
            if ((CAN >= 1000))
            {
                B1000 = ((int)CAN / 1000);
                CAN = CAN - (B1000 * 1000);
            }
            if ((CAN >= 500))
            {
                B500 = ((int)CAN / 500);
                CAN = CAN - (B500 * 500);
            }
            if ((CAN >= 200))
            {
                B200 = ((int)CAN / 200);
                CAN = CAN - (B200 * 200);
            }
            if ((CAN >= 100))
            {
                B100 = ((int)CAN / 100);
                CAN = CAN - (B100 * 100);
            }
            if ((CAN >= 50))
            {
                B50 = ((int)CAN / 50);
                CAN = CAN - (B50 * 50);
            }
            if ((CAN >= 20))
            {
                B20 = ((int)CAN / 20);
                CAN = CAN - (B20 * 20);
            }
            if ((CAN >= 10))
            {
                B10 = (int)(CAN / 10);
                CAN = CAN - (B10 * 10);
            }
            if ((CAN >= 5))
            {
                B5 = (int)(CAN / 5);
                CAN = CAN - (B5 * 5);
            }
            if ((CAN >= 2))
            {
                B2 = (int)(CAN / 2);
                CAN = CAN - (B2 * 2);
            }
            if ((CAN >= 1))
            {
                B2 = (int)(CAN / 1);
                CAN = CAN - (B2 * 1);
            }

            Console.WriteLine("Billetes de 1000: " + B1000);
            Console.WriteLine("Billetes de 500: " + B500);
            Console.WriteLine("Billetes de 200: " + B200);
            Console.WriteLine("Billetes de 100: " + B100);
            Console.WriteLine("Billetes de 50: " + B50);
            Console.WriteLine("Monedas de 20: " + B20);
            Console.WriteLine("Monedas de 10: " + B10);
            Console.WriteLine("Monedas de 5: " + B5);
            Console.WriteLine("Monedas de 2: " + B2);
            Console.WriteLine("Monedas de 1: " + B1);
        }

        public void ejercicio8()
        {
            Console.Write("Ingresar un valor:");
            var value = Console.ReadLine();
            int n;
            Int32.TryParse(value, out n);

            for (int i = 1; i <= n; ++i)
            {
                Console.WriteLine(i);
            }
        }

        public void ejercicio9()
        {
            int num;
            int suma = 0;

            for (int i = 1; i <= 15; ++i)
            {
                Console.Write("Introduce un número entero: ");
                num = Int32.Parse(Console.ReadLine());
                suma += num;
            }

            Console.WriteLine("La suma es: " + suma);
        }

        public void ejercicio10()
        {
            int num;

            for (int i = 1; i <= 5; ++i)
            {
                Console.Write("Introduce un número entero: ");
                num = Int32.Parse(Console.ReadLine());
                if (num % 3 == 0)
                {
                    Console.WriteLine(num + " Es multiplo de 3");
                }
            }
        }

        public void ejercicio11()
        {
            string password;
            //attempts
            int j = 0;

            while (j < 1)
            {
                Console.Write("Ingresa contraseña: ");
                password = Console.ReadLine();

                if (password == "epicPassword123")
                {
                    Console.WriteLine("Contraseña Correcta");
                    j += 1;
                }
                else
                {
                    Console.WriteLine("Contraseña Incorrecta. Vuelva a ingresarla");
                }
            }
        }

        public void ejercicio12()
        {
            string password;
            //attempts
             int j = 0, i = 0;

            do
            {
                Console.Write("Ingresa la contraseña: ");
                password = Console.ReadLine();

                if (password == "epicPassword123")
                {
                    j = 1;
                }
                else
                {
                    Console.WriteLine("Contraseña Incorrecta. Vuelva a ingresarla");
                    i++;
                }
            } while (i < 3 && j == 0);

            if (j == 1)
            {
                Console.WriteLine("Contraseña confirmada");
            }
            else
            {
                Console.Write("Se han acabado los 3 intentos");
            }
        }

        public void ejercicio13()
        {

            int randomNum, res, inserted;

            Console.WriteLine("Adivinar un número");

            //De esta forma generamos un numero aleatorio
           Random generator = new Random();
            randomNum = generator.Next(1, 21);
            //restante
           res = 10;

            do
            {
                Console.WriteLine("Intentos restantes: " + res);
                Console.Write("Dime un número: ");

                inserted = Convert.ToInt32(Console.ReadLine());
                res--;

            } while ((inserted != randomNum) && (res > 0));

            if (inserted == randomNum)
            {
                Console.WriteLine("Has Acertado!");
            }
            else
            {
                Console.WriteLine("El número era: " + randomNum);
            }
        }

        public void ejercicio14()
        {
            int randomNum, res, inserted;

            Console.WriteLine("Adivinar un número");
            Random generator = new Random();
            randomNum = generator.Next(1, 21);
            res = 10;

            do
            {
                Console.WriteLine("Intentos restantes: " + res);
                Console.Write("Dime un número: ");
                inserted = Convert.ToInt32(Console.ReadLine());

                //Avisar si el numero random es mayor al introducido

                 if (inserted > randomNum)
                {
                    Console.WriteLine("Te pasaste del numero aleatorio");
                }

                //Avisar si el numero random es menor al introducido

                 if (inserted < randomNum)
                {
                    Console.WriteLine("Te falta mucho para alcanzar al numero aleatorio");
                }

                res--;

            } while ((inserted != randomNum) && (res > 0));

            if (inserted == randomNum)
            {
                Console.WriteLine("Has Acertado!");
            }
            else
            {
                Console.WriteLine("El número era: " + randomNum);
            }
        }

        public void ejercicio15()
        {
            string end;
            int e = 0;
            int num = 0;
            int suma = 0;

            do
            {
                Console.Write("Ingresa un número: ");
                num = int.Parse(Console.ReadLine());
                suma += num;
                Console.Write("Si desea finalizar el juego ponga 'fin', sino ingresar 'no': ");
                end = Console.ReadLine();

                if (end == "fin")
                {
                    e += 1;
                }

            } while (e < 1);

            Console.WriteLine("El resultado de la suma es: " + suma);
        }
    }
}
