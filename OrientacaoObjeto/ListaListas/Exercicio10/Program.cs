namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crie uma classe chamada Animal que tenha as propriedades Nome,
             * Especie e Idade. Crie também um método chamado EmitirSom, que 
             * imprime na tela o som do animal.
             * 
             */
            Animal cachorro = new Animal();
            cachorro.Nome = "Caramelo";
            cachorro.Especie = "SRD";
            cachorro.Idade = 5;
            cachorro.EmitirSom("Au au");

            Animal gato = new Animal("Mingau","Persa",6);
            gato.EmitirSom("Miauuu");
        }
    }
}