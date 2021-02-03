namespace Projeto_InstaDev.Interfaces
{
    public class IUsuario
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
    }
}