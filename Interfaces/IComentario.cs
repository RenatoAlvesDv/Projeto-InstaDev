using System.Collections.Generic;
using Projeto_InstaDev.Models;

namespace Projeto_InstaDev.Interfaces
{
    public interface IComentario
    {
        void Create (Comentario c);
        List<Comentario> ReadAll();
        void Update (Comentario c);
        void Delete(int id); 
    }
}