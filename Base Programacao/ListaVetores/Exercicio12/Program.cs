namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * 12.	Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica 
            * se um número N, fornecido pelo usuário, existe no vetor. Se existir, indicar 
            * a(s) posição(ões), senão escrever a mensagem "O número fornecido não existe 
            * no vetor!".
            */
            double[] v = new double[10];
            double busca = 0;
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write("Digite o " + (i + 1) + " número: ");
                v[i] = double.Parse(Console.ReadLine());
            }
            Console.Write("Digite o valor que deseja procurar: ");
            busca = double.Parse(Console.ReadLine());
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] == busca)
                {
                    Console.WriteLine("V[" + i + "] = " + v[i]);
                }
                if (i == v.Length - 1 && v[i] != busca)
                {
                    Console.WriteLine("O número fornecido não existe no vetor!");
                }
            }


        }
    }
}