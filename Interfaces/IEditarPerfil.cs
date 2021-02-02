using System.Collections.Generic;
using Projeto_InstaDev.Models;

namespace Projeto_InstaDev.Interfaces
{
    public interface IEditarPerfil
    {
        void Create(EditarPerfil u);

        List<EditarPerfil> ReadAll();

        void Update(EditarPerfil u);

        void Delete(EditarPerfil u);
    }
}