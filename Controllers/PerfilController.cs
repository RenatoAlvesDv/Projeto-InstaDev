
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_InstaDev.models;

namespace Projeto_InstaDev.Controllers
{
    [Route("Perfil")]
    public class PerfilController : Controller
    { 
            Usuario usuarioModel = new Usuario();

            public IActionResult Index()    
            {
                ViewBag.Usuario = usuarioModel.ReadAll();
                return View();
            }
   
    }
}