using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShared
{
    public class Videojuegos
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string Desarrollador { get; set; } = null!;

        public string? Plataforma { get; set; }

        public string Genero { get; set; } = null!;

        public DateOnly FechaLanzamiento { get; set; }

        public string ImagenPortada { get; set; } = null!;

        public string? Descripcion { get; set; }
    }
}
