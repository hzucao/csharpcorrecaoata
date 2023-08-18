//Aula 17/08/2023 Classes
namespace bicicleta2.Model{
    
    public class Bicicleta{
        public int Aro { get; set;}
        public string Marca { get; set;}
        public string Modelo { get; set;}

         public class Rodar{
            public double Distancia(int pedalada){
               return pedalada*1.5;
            }
        }

        public void Apresentar(){
            Console.WriteLine("Aro:"+this.Aro);
            Console.WriteLine("Marca:"+this.Marca);
            Console.WriteLine("Modelo:"+this.Modelo);
            var r = new Rodar();
            Console.WriteLine("Disntancia:"+r.Distancia(50));
        }
    }
}