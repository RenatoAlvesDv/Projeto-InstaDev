using System.Collections.Generic;
using Projeto_InstaDev.Models;

namespace Projeto_InstaDev.Interfaces
{
    public interface IPublicacao
    {
        void Create (Publicacao p);
        List<Publicacao> ReadAll();
        void Update (Publicacao p);
        void Delete(int id);  
    }
}