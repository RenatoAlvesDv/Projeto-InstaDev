using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_InstaDev.Models;

namespace Projeto_InstaDev.Controllers
{
        [Route ("Publicar")]//????
    public class PublicacaoController : Controller
    {
        Publicacao publis = new Publicacao();

        [Route("Lista")]
        public IActionResult Index()
        {
            ViewBag.Publicacoes = publis.ReadAll();
            return View();
        }

        [Route ("Publicar")]

        public IActionResult Publicar (IFormCollection form)
        {
            Publicacao novaPubli = new Publicacao();

            novaPubli.IdPublicacao = Int32.Parse (form ["IdPublicacao"]);
            novaPubli.Legenda      = form ["Legenda"];
            // novaPubli.Imagem       = form ["Imagem"];
            novaPubli.IdUsuario    = Int32.Parse (form ["IdUsuario"]);


            //Upload - INICIO
            if (form.Files.Count > 0)
            {
                var file    = form.Files[0];
                var folder  = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Publicacoes");

                if (!Directory.Exists(folder))
                {   
                    Directory.CreateDirectory(folder);
                }
                
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaPubli.Imagem = file.FileName;
            }
            else
            {
                novaPubli.Imagem = "padrao.png";
            }
            //Upload - FIM


            if (form.Files.Count > 0)
            {
                var file    = form.Files[0];
                var folder  = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory (folder);
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", folder, file.FileName);

                using(var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaPubli.Imagem = file.FileName;
            }
            else
            {
                Console.WriteLine("Insira uma imagem e tente novamente");
                
            }

            publis.Create(novaPubli);
            ViewBag.Publicacoes = publis.ReadAll();


            return LocalRedirect("~/Publicar/Lista");
        }

        [Route("{id}")]

        public IActionResult Excluir(int id)
        {
            publis.Delete(id);
            ViewBag.Publicacoes = publis.ReadAll();

            return LocalRedirect("~/Publicar/Lista");
        }

    }
}