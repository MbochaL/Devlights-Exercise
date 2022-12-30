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
