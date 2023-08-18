namespace redesocial.Model{
    public class Instagram : Redesocial{
        //Atrinuto
        public string UltimaPublicacao { get; set; }

        //Método
        public void GetUltimaPubli(){
            Console.WriteLine(this.UltimaPublicacao);
        }
    }
}