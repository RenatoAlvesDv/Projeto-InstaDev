
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_InstaDev.models;

namespace Projeto_InstaDev.Controllers
{
    [Route("Perfil")]
    public class PerfilController : Controller
    {

        public IActionResult Index([FromQuery] int idUsuario)
        {
            Usuario usuario = new Usuario();

            var userId = -1;

            if(idUsuario == 0)
                userId = int.Parse(HttpContext.Session.GetString("_IdLogado"));
            else
                userId = idUsuario;

            ViewBag.perfil = usuario.BuscarUsuarioPorId(userId); 

            return View();
        }

        [Route("Listar")]

        public IActionResult Listar()
        {
            
            return View();
        }

        [Route("Sair")]
        public IActionResult Sair()
        {
            HttpContext.Session.Remove("_IdLogado");
            return LocalRedirect("/Login");
        }
    }
}