// EJERCICIO 1:

// int[] Notas = new int[10] { 3, 5, 10, 7, 5, 6, 7, 10, 3, 5 };

// int sumatoria = 0;

// foreach (int calificacion in Notas)
// {
//     sumatoria += calificacion;
// }

// double promedio = sumatoria / Notas.Length;

// foreach(var notas in Notas)
// {
//     Console.WriteLine("Nota: " + notas);
// }

// Console.WriteLine("Promedio: " + promedio);



// EJERCICIO 2:

// int[] Edades = new int[20] { 13, 25, 10, 17, 45, 56, 27, 14, 33, 55, 12, 25, 9, 17, 45, 26, 37, 64, 23, 75 };

// int mayores = 0;
// int menores = 0;

// foreach (int edades in Edades)
// {
//     if (edades >= 18) 

//         mayores++;
//     }

//     if (edades < 18)
//     {
//         menores++;
//     }
// }

// Console.WriteLine("Cantidad de Personas Mayores: " + mayores);
// Console.WriteLine("Cantidad de Personas Menores: " + menores);



// EJERCICIO 3:

// string[] Estudiantes = new string[] { "Martin", "Lautaro", "Fernando", "Agustin", "Benjamin", "Fabian", "Valentino" };


// string longestName = "";
// string shortestName = Estudiantes[0];

// foreach (var nombre in Estudiantes)
// {
//     if (name.Length > longestName.Length)
//     {
//         longestName = name;
//     }
//     if (name.Length < shortestName.Length)
//     {
//         shortestName = name;
//     }
// }

// Console.WriteLine("El nombre mas largo es: " + longestName);
// Console.WriteLine("El nombre mas corto es: " + shortestName);



// EJERCICIO 4:

//List<string> lista_supermercado = new List<string>();
//List<string> items_comprado = new List<string>();
//List<string> items_inexistentes = new List<string>();

//while (true)
//{
//    Console.WriteLine("Ingresa el nombre de un elemento que vas a comprar en el super:");
//    string item = Console.ReadLine();
//    if (item == "fin")
//    {
//        break;
//    }
//    if (lista_supermercado.Contains(item))
//    {
//        lista_supermercado.Remove(item);
//        items_comprado.Add(item);
//        Console.WriteLine(item + " ya estaba en la lista, fue removido.");
//    }
//    else
//    {
//        lista_supermercado.Add(item);
//        items_inexistentes.Add(item);
//        Console.WriteLine(item + " no estaba en la lista, fue agregado.");
//    }
//}

//Console.WriteLine("Elementos no comprados:");
//foreach (string item in lista_supermercado)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("Elementos comprados pero no estaban en la lista:");
//foreach (string item in items_inexistentes)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("Todos los elementos comprados:");
//foreach (string item in items_comprado)
//{
//    Console.WriteLine(item);
//}



// EJERCICIO 5:

// char[,] matriz = new char[5, 5];

// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 5; j++)
//     {
//         if ((i + j) % 2 == 0)
//         {
//             matriz[i, j] = 'P';
//         }
//         else
//         {
//             matriz[i, j] = 'I';
//         }
//     }
// }

// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 5; j++)
//     {
//         Console.Write(matriz[i, j] + " ");
//     }
//     Console.WriteLine();
// }



// EJERCICIO 6:

// Random rnd = new Random();
// int[,] matriz = new int[5, 7];

// int tempMax = int.MinValue;
// int tempMin = int.MaxValue;
// string diaMax = "";
// string diaMin = "";

// double[] promedios = new double[5];

// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 7; j++)
//     {
//         matriz[i, j] = rnd.Next(7, 39);
//     }
// }

// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 7; j++)
//     {
//         if (matriz[i, j] > tempMax)
//         {
//             tempMax = matriz[i, j];
//             diaMax = "Semana " + (i + 1) + " día " + (j + 1);
//         }
//         if (matriz[i, j] < tempMin)
//         {
//             tempMin = matriz[i, j];
//             diaMin = "Semana " + (i + 1) + " día " + (j + 1);
//         }
//     }
// }

// Console.WriteLine("La temperatura más alta fue de " + tempMax + " grados y se produjo en " + diaMax);
// Console.WriteLine("La temperatura más baja fue de " + tempMin + " grados y se produjo en " + diaMin);

// for (int i = 0; i < 5; i++)
// {
//     double suma = 0;
//     for (int j = 0; j < 7; j++)
//     {
//         suma += matriz[i, j];
//     }
//     promedios[i] = suma / 7;
// }

// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine("El promedio de la semana " + (i + 1) + " es " + promedios[i] + " grados");
// }

// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 7; j++)
//     {
//         if (matriz[i, j] > tempMax)
//         {
//             tempMax = matriz[i, j];
//             diaMax = "Semana " + (i + 1) + " día " + (j + 1);
//         }
//     }
// }

// Console.WriteLine("La temperatura más alta del mes fue de " + tempMax + " grados y se produjo en " + diaMax);



// EJERCICIO 7:

// int[,] matriz = new int[10, 10];

// for (int i = 0; i < 10; i++)
// {
//     matriz[0, i] = i;
//     matriz[i, 0] = i;
// }

// for (int i = 1; i < 10; i++)
// {
//     for (int j = 1; j < 10; j++)
//     {
//         matriz[i, j] = i * j;
//     }
// }

// for (int i = 0; i < 10; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         Console.Write(matriz[i, j] + " ");
//     }
//     Console.WriteLine();
// }



// EJERCICIO 8:

// Random random = new Random();
// int[,] matriz = new int[10, 10];
// int cantidadX = 5; // La cantidad de X que se van a esconder
// int aciertos = 0; // Contador de aciertos del usuario
// int intentos = 3; // Contador de intentos


// for (int i = 0; i < cantidadX; i++)
// {
//     int fila = random.Next(0, 10);
//     int columna = random.Next(0, 10);
//     matriz[fila, columna] = 1;
// }

// while (intentos > 0 && aciertos < cantidadX)
// {
//     Console.WriteLine("Ingresa la fila (0-9): ");
//     int fila = int.Parse(Console.ReadLine());
//     Console.WriteLine("Ingresa la columna (0-9): ");
//     int columna = int.Parse(Console.ReadLine());

//     if (matriz[fila, columna] == 1)
//     {
//         Console.WriteLine("¡Acierto!");
//         matriz[fila, columna] = 2;
//         aciertos++;
//     }
//     else
//     {
//         Console.WriteLine("¡Fallo!");
//         intentos--;
//     }
// }

// for (int i = 0; i < 10; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         if (matriz[i, j] == 1)
//         {
//             Console.Write("X ");
//         }
//         else if (matriz[i, j] == 2)
//         {
//             Console.Write("* ");
//         }
//         else
//         {
//             Console.Write("- ");
//         }
//     }
//     Console.WriteLine();
// }