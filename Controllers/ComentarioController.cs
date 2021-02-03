using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_InstaDev.Models;

namespace Projeto_InstaDev.Controllers
{
        [Route ("Feed")]
    public class ComentarioController : Controller
    {
        Comentario comentarioModel = new Comentario();

        [Route ("Listar")]

        public IActionResult Index()
        {
            ViewBag.Comentarios = comentarioModel.ReadAll();
            return View();
        }

        [Route ("Comentar")]

        public IActionResult Comentar (IFormCollection form)
        {
            Comentario novoComentario = new Comentario();

            novoComentario.IdComentario = Int32.Parse (form ["IdComentario"]);
            novoComentario.Mensagem     = form ["Mensagem"];

            if (form.Files.Count > 0)
            {
                var file  = form.Files [0];
                var folder = Path.Combine (Directory.GetCurrentDirectory(), "wwwroot/img");

                if (Directory.Exists(folder))
                {
                    Directory.CreateDirectory (folder);
                }

                var path = Path.Combine (Directory.GetCurrentDirectory(), "wwwroot", folder, file.Name);

                using (var stream = new FileStream (path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novoComentario.Mensagem = file.FileName;

            }
            else
            {
                Console.WriteLine("Ocorreu um erro.");
            }
            comentarioModel.Create(novoComentario);
            ViewBag.Comentarios = comentarioModel.ReadAll();

            return LocalRedirect ("~/Feed/Listar");
        }
    }
}