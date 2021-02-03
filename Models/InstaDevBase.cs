using System.IO;
using System.Collections.Generic;

namespace Projeto_InstaDev.Models
{
    public class InstaDevBase
    {
        public void CreateFolderAndFile(string _path)
<<<<<<< HEAD
        {
            string folder = _path.Split("/")[0];

            if(!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if(!File.Exists(_path))
            {
                File.Create(_path);
            }
        }

        public List<string> ReadAllLinesCSV(string path)
=======

            {
                string folder = _path.Split("/")[0];

                if(!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                if(!File.Exists(_path))
                {
                    File.Create(_path);
                }
            }

        public List<string> ReadAllLinesCSV(string path)
        
>>>>>>> main
        {
            List<string> linhas = new List<string>();

            using(StreamReader file = new StreamReader(path))
<<<<<<< HEAD
=======
            
>>>>>>> main
            {
                string linha;

                while ((linha = file.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
            }

            return linhas;            
        }
        
        public void RewriteCSV(string _path, List<string> linhas)
        {
            using(StreamWriter saida = new StreamWriter(_path))
            {
                foreach (var item in linhas)
                {
                    saida.Write(item + '\n');
                }
            }
        }
    }
}