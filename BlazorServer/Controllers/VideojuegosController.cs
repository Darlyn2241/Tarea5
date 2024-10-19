using BlazorServer.Models;
using BlazorServer.Services;
using BlazorShared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideojuegosController : ControllerBase
    {
        private readonly IUvideojuegos iuvideosjuegos;

        public VideojuegosController(IUvideojuegos iuvideosjuegos)
        {
            iuvideosjuegos = iuvideosjuegos;
        }

        [HttpGet]
        public async Task<List<Videojuegos>> ListaVideojuegos()
        {
            return await Task.FromResult(iuvideosjuegos.Datosvideojuegos());
        }

    }
}
