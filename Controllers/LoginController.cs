using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_InstaDev.models;



namespace Projeto_InstaDev.Controllers
{
        [Route("Login")]
        public class LoginController : Controller
        {

        [TempData]
        public string Mensagem { get; set; }
        
        public LoginController(string mensagem) 
        {
            this.Mensagem = mensagem;
               
        }
        
        
        Usuario usuarioModel = new Usuario();

        public IActionResult Index()
        {
            return View();
        }

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
            // Lemos todos os arquivos do CSV
            List<string> csv = usuarioModel.ReadAllLinesCSV(usuarioModel.PATH);

            // Verificamos se as informações passadas existe na lista de string
            var logado = 
            csv.Find(
                x => 
                x.Split(";")[2] == form["Email"] && 
                x.Split(";")[3] == form["Senha"]
            );


            // Redirecionamos o usuário logado caso encontrado
            if(logado != null)
            {
                //Criamos uma sessão com os dados do usuário
                HttpContext.Session.SetString("_UserName", logado.Split(";")[1]);
                return LocalRedirect("~/Feed");
            }

            Mensagem = "Senha ou nome de Usuario incorreto, tente novamente";
            return LocalRedirect("~/Login");
        }

        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("_UserName");
            return LocalRedirect("~/Login");
        }
            }
}