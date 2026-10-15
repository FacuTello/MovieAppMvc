using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace MovieAppMvc.Models
{
    public class Usuario : IdentityUser
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string ImagenPerfilUrl { get; set; }

        public List<Favorito> ListaPeliculasFavoritas { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Favorito>? PeliculasFavoritas { get; set; }


    }
}
