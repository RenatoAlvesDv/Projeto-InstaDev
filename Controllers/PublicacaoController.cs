using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_InstaDev.Models;

namespace Projeto_InstaDev.Controllers
{
        [Route ("Feed")]//????
    public class PublicacaoController : Controller
    {
        Publicacao publis = new Publicacao();

        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.Publicacoes = publis.ReadAll();
            return View();
        }

        public IActionResult Publicar (IFormCollection form)
        {
            Publicacao novaPubli = new Publicacao();

            novaPubli.IdPublicacao = Int32.Parse (form ["IdPublicacao"]);
            novaPubli.Legenda      = form ["Legenda"];

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


            return LocalRedirect("~/Feed/Listar");
        }

        [Route("{id}")]

        public IActionResult Excluir(int id)
        {
            publis.Delete(id);
            ViewBag.Equipes = publis.ReadAll();

            return LocalRedirect("~/Feed/Listar");
        }

    }
}