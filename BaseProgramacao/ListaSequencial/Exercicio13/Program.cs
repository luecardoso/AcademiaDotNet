namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa
                um programa no VS que calcule seu peso ideal, utilizando as seguintes
                fórmulas:

                Para homens: (72.7 * h) - 58
                Para mulheres: (62.1 * h) - 44.7
             */
            Console.WriteLine("--------------------------------------");
            Console.Write("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("infome seu sexo: (M) (F) ");
            string sexo = Console.ReadLine().ToUpper();

            double pesoIdeal = 0;

            if (sexo == "M")
            {
                pesoIdeal = 72.7 * altura - 58;
            }
            else
            {
                pesoIdeal = 62.1 * altura - 44.7;
            }

            Console.WriteLine("Seu peso ideal é: " + pesoIdeal.ToString("F2"));
            Console.WriteLine("--------------------------------------");
        }
    }
}