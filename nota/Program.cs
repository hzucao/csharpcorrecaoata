// See https://aka.ms/new-console-template for more information
class Program{
    public static void Main(){
        string[] nome = new string[3];
        float[][] nota = new float[3][];

        for(int i=0; i<3;i++){
           Console.WriteLine("Digite o nome do aluno:");
           nome[i] = Console.ReadLine();
           nota[i] = new float[2];
           Console.WriteLine("Digite a nota 1 do aluno "+i+1);
           nota[i][0] = float.Parse(Console.ReadLine());
           Console.WriteLine("Digite a nota 2 do aluno "+i+1);
           nota[i][1] = float.Parse(Console.ReadLine());
        } 

        for(int i=0; i <= nome.Length-1; i++){
            float media = (nota[i][0]+nota[i][1])/2;
            Console.WriteLine("Aluno: "+ nome[i]+ " media: "+media);
        
        }
    }
}
