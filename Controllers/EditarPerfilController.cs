using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_InstaDev.Models;

namespace Projeto_InstaDev.Controllers
{
    [Route("EditarPerfil")]
    public class EditarPerfilController : Controller
    {
        EditarPerfil usuario = new EditarPerfil(); 

        [Route("Listar")]
        public IActionResult Index(){
            ViewBag.EditarPerfil = usuario.ReadAll();
            return View();
       }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form){
            EditarPerfil novoUsuario = new EditarPerfil();
            novoUsuario.Nome = form["Nome"];
            novoUsuario.Nomeusuario = form["Nomeuser"];
            novoUsuario.Email = form["Email"];

            return LocalRedirect("~/EditarPerfil/Listar");
       }

        [Route("{usuario}")]
        public IActionResult Excluir(EditarPerfil usuario){
           usuario.Delete(usuario);
           ViewBag.EditarPerfil = usuario.ReadAll();

           return LocalRedirect("~/EditarPerfil/Listar");
       }
    }
}