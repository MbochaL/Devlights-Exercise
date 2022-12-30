using Exercise15.models;
using Exercise3.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15P2.models

//    15.Crear una clase Libro, que contenga Nombre, Autor, Cantidad de Páginas, y
//    una property llamada WasRead, que diga si el libro fue leído o no(boolean).
//    Crear una clase Estudiante, que hereda de Persona(la clase de los puntos
//    anteriores). El estudiante debe contener una lista de Libros, los cuales puede
//    ser que los haya leído o no. (Se pueden crear dos listas diferentes si se
//    complica mucho.Una lista con todos los libros, leídos o no, y otra lista sólo
//    con los libros leídos) Debe haber un método que muestre la lista de libros
//    leídos, y además otro método que permita calcular la suma de la cantidad de
//    páginas leídas totales, de todos los libros leídos.Y un método que permita
//    saber cuántos libros quedan sin leer. Otro método que permite agregar o
//    quitar libros de la lista de libros (dos métodos diferentes).


{
    class Estudiante : Persona
    {
        List<Libro> GetLibros = new List<Libro>();

        public void AddLibros(Libro Libros)
        {
            GetLibros.Add(Libros);
        }

        public void RemoveLibros(Libro Libros)
        {
            GetLibros.Remove(Libros);
        }

        public void ReadBooks(Libro libro)
        {
            if (libro.WasRead == true)
            {
                Console.WriteLine("Este libro ya fue leido: " + libro.Nombre);
            } else
            {
                Console.WriteLine("Todavia falta leer: " + libro.Nombre);
            }
        }

        public void PaginasTotales(Libro libro )
        {
            if(libro.WasRead == true)
            {
                libro.CantidadPaginas = libro.CantidadPaginasLeidas;
                Console.WriteLine("Usted ha leido: " + libro.CantidadPaginasLeidas + " paginas");
            } else
            {
                Console.WriteLine("Aun te falta terminar este libro, te quedan " + (libro.CantidadPaginas - libro.CantidadPaginasLeidas) + " paginas por leer");
            }
        }
    }
}
