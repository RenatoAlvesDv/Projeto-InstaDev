using System.Collections.Generic;
using Projeto_InstaDev.Models;

namespace Projeto_InstaDev.Interfaces
{
    public interface ICadastro
    {
         void Create (Cadastro c);
        List<Cadastro> ReadAll();
        void Update (Cadastro c);
        void Delete(string _nick); 
    }
}