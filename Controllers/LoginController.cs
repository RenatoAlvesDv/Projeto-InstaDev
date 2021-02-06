using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_InstaDev.models;




namespace Projeto_InstaDev.Controllers
{
     [Route("Login")]
    public class LoginController : Controller
    {
        
        Usuario usuarioModel = new Usuario();

        public IActionResult Index()
        {
            return View();
        }

        
        [TempData]
        public string Mensagem { get; set; }

        
        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
            // Lemos todos os arquivos do CSV
            List<string> csv = usuarioModel.ReadAllLinesCSV("Database/Usuario.csv");

            // Verificamos se as informações passadas existe na lista de string
            var logado = 
            csv.Find(
                x => 
                x.Split(";")[5] == form["Email"] && 
                x.Split(";")[7] == form["Senha"]
            );

            

            // Redirecionamos o usuário logado caso encontrado
            if(logado != null)
            {
                HttpContext.Session.SetString("IdLogado", logado.Split(";")[0]);
                return LocalRedirect("~/Feed");
            }

            Mensagem = "Dados incorretos, tente novamente...";
            return LocalRedirect("~/login");

            }
    }
}