using BlazorServer.Models;
using BlazorShared;

namespace BlazorServer.Services
{
    public class GentionVideojuegos : IUvideojuegos
    {

        readonly BlazorCrudContext dbContext = new();


        public GentionVideojuegos(BlazorCrudContext db)
        {
            dbContext = db;
        }

        public void ActualizarVideojuego(Videojuegos v)
        {
            throw new NotImplementedException();
        }

        public void BorrarVideojuego(int id)
        {
            throw new NotImplementedException();
        }

        public Videojuegos DatosVideojuego(int id)
        {
            throw new NotImplementedException();
        }

        public List<Videojuegos> Datosvideojuegos()
        {
            try
            {
                return dbContext.Videojuegos.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            
        }

        public void NuevoVideojuego(Videojuegos v)
        {
            throw new NotImplementedException();
        }
    }
}
