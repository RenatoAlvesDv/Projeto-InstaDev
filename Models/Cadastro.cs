using System.Collections.Generic;
using System.IO;
using Projeto_InstaDev.Interfaces;

namespace Projeto_InstaDev.Models
{
    public class Cadastro : InstaDevBase, ICadastro
    {
        public string Email { get; set; }        
        public string Nome { get; set; }        
        public string Nick { get; set; }        
        public string Senha { get; set; }
        public string PATH = "Database/Cadastro.csv";

        public Cadastro()
        {
            CreateFolderAndFile(PATH);
        }

        public string Prepare(Cadastro cLinha)
        {
            return $"{cLinha.Email};{cLinha.Nome};{cLinha.Nick};{cLinha.Senha}";
        }

        public void Create(Cadastro c)
        {
            string[] linha = { Prepare(c) };
            File.AppendAllLines(PATH, linha);
        }

        public void Delete(string _nick)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            
            linhas.RemoveAll(x => x.Split(";")[2] == _nick);                        
            RewriteCSV(PATH, linhas);
        }

        public List<Cadastro> ReadAll()
        {
            List<Cadastro> cadastros = new List<Cadastro>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");

                Cadastro novoCadastro = new Cadastro();
                
                novoCadastro.Email = linha[0];
                novoCadastro.Nome  = linha[1];
                novoCadastro.Nick  = linha[2];
                novoCadastro.Senha = linha[3];

                cadastros.Add(novoCadastro);
                
            }
            return cadastros;
        }

        public void Update(Cadastro c)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[2] == c.Nick);
            linhas.Add( Prepare(c) );
            RewriteCSV(PATH, linhas);
        }
    }
}