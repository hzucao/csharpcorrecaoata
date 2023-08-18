// See https://aka.ms/new-console-template for more information
using redesocial.Model;
namespace redesocial{
    public class Program{
        public static void Main(){
            var insta = new Instagram();
            insta.Usuario = "hzucao";
            insta.Senha = "123";
            insta.UltimaPublicacao = "Aula de classe abstrata";
            insta.GetUltimaPubli();
        }
    }

}
