// See https://aka.ms/new-console-template for more information
//Aula 25/08/2023 polimorfismo
using soma23.Model;
namespace soma23{
    public class Program{
        public static void Main(){
             var calc = new Calcular();
             calc.Soma(1,2);
             calc.Soma(1,2,3);
        }
    }
}
