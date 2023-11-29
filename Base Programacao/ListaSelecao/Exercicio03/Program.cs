namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio,
            //para trocar entre si os valores de duas variáveis A e B.
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("- TROCA DE VALORES ENTRE DUAS VARIÁVEIS -");
            Console.WriteLine("-----------------------------------------");
            Console.Write("Digite um valor para A: ");
            double valorA = double.Parse(Console.ReadLine());

            Console.Write("Digite um valor para B: ");
            double valorB = double.Parse(Console.ReadLine());

            Console.WriteLine("valor A = " + valorA);
            Console.WriteLine("valor B = " + valorB);

            double troca;
            troca = valorA;
            valorA = valorB;
            valorB = troca;
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("------------ VALORES TROCADOS -----------");
            Console.WriteLine("valor A = " + valorA);
            Console.WriteLine("valor B = " + valorB);
            Console.WriteLine("-----------------------------------------");
        }
    }
}