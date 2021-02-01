using System.IO;
using System.Collections.Generic;
using Projeto_InstaDev.Interfaces;

namespace Projeto_InstaDev.Models
{
    public class Publicacao
    {
        public int IdPublicacao { get; set; }
        public int IdUsuario { get; set; }
        public int Likes { get; set; }
        public string Imagem { get; set; }        
        public string Legenda { get; set; }
        public string PATH = "Database/Publicacao.csv";
        
        

        public Publicacao(){
            CreateFolderAndFile(PATH);
        }

        public string Prepare(Publicacao pLinha)
        //Método para criar a estrutura de linha do CSV
        {
            return $"{pLinha.IdPublicacao};{pLinha.Imagem};{pLinha.Legenda};{pLinha.IdUsuario}";
        }

        public void Create(Publicacao p)
        {
            string[] linha = { Prepare(p) };
            File.AppendAllLines(PATH, linha);
        }

        public void Delete(int id)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            
            linhas.RemoveAll(x => x.Split(";")[0] == IdPublicacao.ToString());                        
            RewriteCSV(PATH, linhas);
        }

        public List<Publicacao> ReadAll()
        {
            List<Publicacao> publicacoes = new List<Publicacao>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");

                Publicacao publi = new Publicacao();

                publi.IdPublicacao   = int.Parse(linha[0]);
                publi.Imagem         = linha[1];
                publi.Legenda        = linha[2];
                publi.IdUsuario      = int.Parse (linha[3]);

                publicacoes.Add(publi);
            }
            return publicacoes;
        }

        public void Update(Publicacao p)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == p.IdPublicacao.ToString());
            linhas.Add( Prepare(p) );                        
            RewriteCSV(PATH, linhas); 
        }
    }
}