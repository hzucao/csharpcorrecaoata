using calc.Interface;

namespace calc.Model
{
    public class CalculadoraCientifica : ICalculadora
    {
        public void Adicao(double valor1, double valor2)
        {
           Console.WriteLine("Resultado Adição: "+(valor1+valor2));
        }

        public void Divisao(double valor1, double valor2)
        {
            Console.WriteLine("Resultado Divisão: "+(valor1/valor2));
        }

        public void Multiplicacao(double valor1, double valor2)
        {
            Console.WriteLine("Resultado Multiplicação: "+(valor1*valor2));
        }

        public void Subtracao(double valor1, double valor2)
        {
            Console.WriteLine("Resultado Subtração: "+(valor1-valor2));
        }

        public void Potencia(double valor1, int potencia){
            Console.WriteLine("Resultado potencia:" + Math.Pow(valor1, potencia));
        }
        
    }
}