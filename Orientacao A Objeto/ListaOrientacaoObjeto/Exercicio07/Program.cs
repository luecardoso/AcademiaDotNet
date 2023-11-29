namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personagem personagem = new Personagem();
            Console.WriteLine("-------------------------------------------------");
            Console.Write("Escreva o nome do seu personagem ");
            personagem.nome = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("1 - Espadachim");
            Console.WriteLine("2 - Animago");
            Console.WriteLine("3 - Necromante ");
            Console.WriteLine("4 - Guerreiro ");
            Console.WriteLine("5 - Mago ");
            Console.Write("Escolha: ");
            personagem.classe = Console.ReadLine();


        }
    }
}