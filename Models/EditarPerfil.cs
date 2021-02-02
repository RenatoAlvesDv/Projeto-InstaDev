using System.Collections.Generic;
using System.IO;
using Projeto_InstaDev.Interfaces;

namespace Projeto_InstaDev.Models
{
    public class EditarPerfil : InstaDevBase , IEditarPerfil 
    {
       public string Nome {get;set;}
       public string Email {get;set;}
       public string Nomeusuario {get;set;}
       private const string  PATH = "Database/Usuário.csv";

        public EditarPerfil(){
            CreateFolderAndFile(PATH);
        }

        public void Create(EditarPerfil usuario){
            string[] linha = {Prepare(usuario)};
            File.AppendAllLines(PATH, linha);
        }

        private string Prepare(EditarPerfil usuario){
            return $"{usuario.Nome};{usuario.Email};{usuario.Nomeusuario}";
        }

        public void Update(EditarPerfil usuario){
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == usuario.ToString());
            linhas.Add(Prepare(usuario));
            RewriteCSV(PATH, linhas);
        }

        public void Delete(EditarPerfil usuario){
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == usuario.ToString());
            RewriteCSV(PATH, linhas);
        }

        public List<EditarPerfil> ReadAll(){
            List<EditarPerfil> usuarios = new List<EditarPerfil>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach(var item in linhas)
            {
                string[] linha = item.Split(";");
                EditarPerfil usuario = new EditarPerfil();
                usuario.Nome = linha[1];
                usuario.Nomeusuario = linha[2];
                usuario.Email = linha[3];

                usuarios.Add(usuario);
            }
            return usuarios;
        }
    }


}