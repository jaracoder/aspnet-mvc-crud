using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class Libro
    {
        [DisplayName("Isbn")]
        [Required(ErrorMessage = "El Isbn es obligatorio")]
        public string Isbn { get; set; }


        [DisplayName("Título")]
        [Required(ErrorMessage = "El Título es obligatorio")]
        [StringLength(255, MinimumLength=1, ErrorMessage="El título debe tener entre 1 y 255 carácteres")]
        public string Titulo { get; set; }


        [DisplayName("Autor")]
        [Required(ErrorMessage = "El Autor es obligatorio")]
        [StringLength(255, MinimumLength = 1, ErrorMessage = "El autor debe tener entre 1 y 255 carácteres")]
        public string Autor { get; set; }


        [DisplayName("Año")]
        [Required(ErrorMessage = "El Año es obligatorio")]
        [Range(1900, 2017, ErrorMessage="El formato de año no es correcto")]
        public int Anyo { get; set; }

        public Libro(string Isbn, string Titulo, string Autor, int Anyo) 
        {
            this.Isbn = Isbn;
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.Anyo = Anyo;
        }
    }
}