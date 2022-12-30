using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15.models
{
    class Libro
    {
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public int CantidadPaginas { get; set; }
        public int CantidadPaginasLeidas { get; set; }
        public bool WasRead { get; set; }


    }
}
