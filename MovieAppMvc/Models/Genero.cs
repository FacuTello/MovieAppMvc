using System.Collections.Generic;

namespace MovieAppMvc.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public List<Pelicula>? PeliculasGenero { get; set; }
    }
}
