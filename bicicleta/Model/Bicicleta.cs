//Aula 17/08/2023 Classes
namespace bicicleta.Model{
    
    public class Bicicleta{
        public int Aro { get; set;}
        public string Marca { get; set;}
        public string Modelo { get; set;}

       

        public void Apresentar(){
            Console.WriteLine("Aro:"+this.Aro);
            Console.WriteLine("Marca:"+this.Marca);
            Console.WriteLine("Modelo:"+this.Modelo);
        }
    }
}