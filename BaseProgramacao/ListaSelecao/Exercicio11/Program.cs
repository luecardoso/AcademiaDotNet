namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11) Escreva um algoritmo para ler o número de eleitores de um município, o número de votos brancos, nulos e válidos.
            //Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.
            Console.WriteLine("------------------------------------");
            Console.Write("Digite o total de eleitores no município: ");
            int eleitores = int.Parse(Console.ReadLine());

            Console.Write("Votos Brancos: ");
            int votosBrancos = int.Parse(Console.ReadLine());

            Console.Write("Votos Nulos: ");
            int votosNulos = int.Parse(Console.ReadLine());

            Console.Write("Votos Válidos: ");
            int votosValidos = int.Parse(Console.ReadLine());

            double percBranco = votosBrancos * 100 / eleitores;
            Console.WriteLine("Branco = " + percBranco + "%");
            double percNulo = votosNulos * 100 / eleitores;
            Console.WriteLine("Branco = " + percNulo + "%");
            double percValido = votosValidos * 100 / eleitores;
            Console.WriteLine("Branco = " + percValido + "%");
        }
    }
}