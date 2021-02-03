using System.Collections.Generic;
using EPlayers_AspNetCore.Models;


namespace Projeto_InstaDev.Interfaces
{
     public interface IUsuario
    {
          //Criar
        void Create(Usuario u);
        //Ler
        List<Usuario> ReadAll();
        //Alterar
        void Update(Usuario u);
        //Excluir
        void Delete(int id);  
    }
}