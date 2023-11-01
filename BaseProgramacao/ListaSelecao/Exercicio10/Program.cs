namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Um programa para gerenciar os saques de um caixa eletrônico deve 
             * possuir algum mecanismo para decidir o número de notas de cada 
             * valor que deve ser disponibilizado para o cliente que realizou o 
             * saque. Um possível critério seria o da “distribuição ótima” no 
             * sentido de que as notas de menor valor fossem distribuídas em 
             * número mínimo possível. 
             * Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa 
             * deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00, uma 
             * nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00.
             * Escreva um programa que receba o valor da quantia solicitada e 
             * retorne a distribuição das notas de acordo com o critério da 
             * “distribuição ótima”.
             */

            Console.WriteLine("------------------------------------");
            Console.WriteLine("----------CAIXA ELETRÔNICO----------");
            Console.Write("Insira o valor a ser retirado: ");
            int valorSacado = int.Parse(Console.ReadLine());
            int nota50 = 0, nota20 = 0, nota10 = 0, nota5 = 0, nota2 = 0, nota1 = 0;


            nota50 = valorSacado / 50;
            valorSacado = valorSacado - nota50 * 50;
            Console.WriteLine("Notas de 50: " + nota50);

            nota20 = valorSacado / 20;
            valorSacado = valorSacado - nota20 * 20;
            Console.WriteLine("Notas de 20: " + nota20);

            nota10 = valorSacado / 10;
            valorSacado = valorSacado - nota10 * 10;
            Console.WriteLine("Notas de 10: " + nota10);

            nota5 = valorSacado / 5;
            valorSacado = valorSacado - nota5 * 5;
            Console.WriteLine("Notas de 5: " + nota5);

            nota2 = valorSacado / 2;
            valorSacado = valorSacado - nota2 * 2;
            Console.WriteLine("Notas de 2: " + nota2);

            nota1 = valorSacado / 1;
            valorSacado = valorSacado - nota1 * 1;
            Console.WriteLine("Notas de 1: " + nota1);
            Console.WriteLine("------------------------------------");
        }
    }
}