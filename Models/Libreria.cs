using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class Libreria
    {
        public List<Libro> Libros { get; set; }

        public Libreria() 
        {
            Libros = new List<Libro>()
            {
                new Libro("12345678", "El señor de los anillos", "J.K Rowlin", 2010),
                new Libro("87654321", "Star Wars. El imperio contrataca", "El Jedi", 1950),
                new Libro("12332145", "Las aventuras de Winny de Poe", "Margarita Flores", 1993)
            };
        }
    }
}