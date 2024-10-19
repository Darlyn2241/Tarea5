using BlazorShared;

namespace BlazorServer.Services
{
    public interface IUvideojuegos
    {
        public List<Videojuegos> Datosvideojuegos();

        public void NuevoVideojuego(Videojuegos v);

        public void ActualizarVideojuego(Videojuegos v);

        public Videojuegos DatosVideojuego(int id);

        public void BorrarVideojuego(int id);

    }
}
