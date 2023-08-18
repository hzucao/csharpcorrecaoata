// See https://aka.ms/new-console-template for more information
//Aula 17/08/2023 Classes
using bicicleta.Model;
namespace bicicleta{
    public class Program{
        public static void Main(){
            var bike = new Bicicleta();
            bike.Aro = 27;
            bike.Marca = "Caloi";
            bike.Modelo = "Speed";
            bike.Apresentar();
        }
    }
}
