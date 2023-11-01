namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo 
                (lado a, b e c), e então diga se esses lados podem ou não formar um 
                triangulo. Para que os lados formem um triângulo, todos os lados devem
                ser menores ou iguais a soma dos outros dois lados. Caso os lados formem 
                um triangulo, diga se o mesmo é equilátero (todos os lados iguais), 
                isósceles (somente 2 lados são iguais) ou escaleno (os 3 lados são 
                diferentes).
             */
            Console.WriteLine("--------------------------");
            Console.WriteLine("------ *TRIANGULO* ------");
            Console.Write("Lado A: ");
            int ladoA = int.Parse(Console.ReadLine());
            Console.Write("Lado B: ");
            int ladoB = int.Parse(Console.ReadLine());
            Console.Write("Lado C: ");
            int ladoC = int.Parse(Console.ReadLine());

            if (ladoA <= ladoB + ladoC && ladoB <= ladoA + ladoC && ladoC <= ladoA + ladoB)
            {
                if (ladoA == ladoB && ladoB == ladoC)
                {
                    Console.WriteLine("TRIÂNGULO EQUILÁTERO");
                }
                else
                if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    Console.WriteLine("TRIÂNGULO ISÓSCELES");
                }
                else
                {
                    Console.WriteLine("TRIÂNGULO ESCALENO");
                }
            }
            else
            {
                Console.WriteLine("VALORES NÃO FORMAM UM TRIÂNGULO");
            }
            Console.WriteLine("--------------------------");

        }
    }
}