using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_InstaDev.Models;

namespace Projeto_InstaDev.Controllers
{
        [Route ("Comentar")]
    public class ComentarioController : Controller
    {
        Comentario comentarioModel = new Comentario();

        [Route ("Listar")]

        public IActionResult Index()
        {
            ViewBag.Comentario = comentarioModel.ReadAll();
            return View();
        }

        [Route ("Comentar")]

        public IActionResult Comentar (IFormCollection form)
        {
            Comentario novoComentario = new Comentario();

            novoComentario.IdComentario = Int32.Parse (form ["IdComentario"]);
            novoComentario.Mensagem     = form ["Mensagem"];
            novoComentario.IdUsuario    = Int32.Parse (form ["IdUsuario"]);
            novoComentario.IdPublicacao = Int32.Parse (form ["IdPublicacao"]);


            if (form.Files.Count > 0)
            {
                var file  = form.Files [0];
                var folder = Path.Combine (Directory.GetCurrentDirectory(), "wwwroot");

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

            return LocalRedirect ("~/Comentar/Listar");
        }
        
        [Route("{id}")]

        public IActionResult Excluir(int id)
        {
            comentarioModel.Delete(id);
            ViewBag.Comentarios = comentarioModel.ReadAll();

            return LocalRedirect("~/Comentar/Listar");
        }
    }
}