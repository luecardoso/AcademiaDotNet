namespace ExemploAnimais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro("Caramelo");

            cachorro.Idade = 3;
            //cachorro.Nome = "Caramelo";
            cachorro.Especie = "SPM";
            cachorro.EmitirSom();

            Gato gato = new Gato("Mingau", 7);
            gato.Idade = 6;
            //gato.Nome = "Mingau";
            gato.Especie = "Persa";
            gato.EmitirSom();
            gato.Ronronar();

            cachorro.Movimentar();
            gato.Movimentar();
        }
    }
}