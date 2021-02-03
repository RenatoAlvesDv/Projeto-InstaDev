namespace Projeto_InstaDev.Models
{
    public class Usuario : InsDevBase, IUsuario 
    {
        public int IdUsuario { get; set;}
        public string Nome { get; set;}
        public string Foto { get; set;}
        public DateTime DataNascimento {get; set;}
        public int Seguidos {get; set;}

        public string Email {get; set;}

        public string Username {get; set;}

        public string Senha {get; set;}

    }
}