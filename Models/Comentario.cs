using System.Collections.Generic;
using System.IO;
using Projeto_InstaDev.Interfaces;

namespace Projeto_InstaDev.Models
{
    public class Comentario : InstaDevBase, IComentario

    {
        public int IdComentario { get; set; }
        public string Mensagem { get; set; }
        public int IdUsuario { get; set; }/*FK?????*/
        public int IdPublicacao { get; set; }
        public string PATH = "Database/Comentario.csv";       
        
        
        public Comentario(){
            CreateFolderAndFile(PATH);
        }

        public string Prepare(Comentario cLinha)

        {
            return $"{cLinha.IdComentario};{cLinha.Mensagem};{cLinha.IdUsuario};{cLinha.IdPublicacao}";
        }
        
        
        public void Create(Comentario c)
        {
            string[] linha = { Prepare(c) };
            File.AppendAllLines(PATH, linha);
        }

        public void Delete(int id)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            
            linhas.RemoveAll(x => x.Split(";")[0] == IdComentario.ToString());                        
            RewriteCSV(PATH, linhas);
        }

        public List<Comentario> ReadAll()
        {
            List<Comentario> comentarios = new List<Comentario>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");

                Comentario comment = new Comentario();

                comment.IdComentario     = int.Parse(linha[0]);
                comment.Mensagem         = linha[1];
                comment.IdUsuario        = int.Parse (linha[2]);
                comment.IdPublicacao     = int.Parse (linha[3]);

                comentarios.Add(comment);
            }
            return comentarios;
        }

        public void Update(Comentario c)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == c.IdComentario.ToString());
            linhas.Add( Prepare(c) );                        
            RewriteCSV(PATH, linhas); 
        }
    }
}