namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x
            //elevado na y sem utilizar a função pow.
            Console.Write("Digite o valor de X: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de Y: ");
            double y = double.Parse(Console.ReadLine());
            double elevado = 1;

            for (int i = 0; i < y; i++)
            {
                elevado *= x;
            }
            Console.WriteLine("Potencia de X elevado a Y: " + elevado);
        }
    }
}