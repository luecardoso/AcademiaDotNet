namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo = new Jogo();
            Console.WriteLine("------------------------------------");
            Console.Write("Digite o nome do jogo: ");
            jogo.titulo = Console.ReadLine();
            Console.Write("Insira o gênero do jogo: ");
            jogo.genero = Console.ReadLine();
            Console.Write("Plataformas disponíveis: ");
            jogo.plataforma = Console.ReadLine();
            Console.Write("Digite o ano de Lançamento: ");
            jogo.dataLancamento = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");

            Console.WriteLine("Jogo: " + jogo.titulo);
            Console.WriteLine("Genero: " + jogo.genero);
            Console.WriteLine("Plataformas: " + jogo.plataforma);
            Console.WriteLine("Data de Lançamento: " + jogo.dataLancamento);
            Console.WriteLine("------------------------------------");
        }
    }
}