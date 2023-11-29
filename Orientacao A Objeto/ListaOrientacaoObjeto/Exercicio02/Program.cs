namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudio estudio = new Estudio();
            Console.Write("Digite o nome do Estúdio: ");
            estudio.nome = Console.ReadLine();
            Console.Write("Ano de Fundação: ");
            estudio.dataFundacao = DateOnly.Parse(Console.ReadLine());
            Console.Write("País de Origem: ");
            estudio.pais = Console.ReadLine();
            Console.Write("Número de jogos produzidos: ");
            estudio.quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Estúdio: " + estudio.nome);
            Console.WriteLine("Data de Fundação: " + estudio.dataFundacao);
            Console.WriteLine("Pais: " + estudio.pais);
            Console.WriteLine("Quantidade: " + estudio.quantidade);
        }
    }
}