namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 10.	Escreva um algoritmo que leia um vetor inteiro de 20 posições. 
             * Crie um segundo vetor, substituindo os valores nulos por 2. Mostre os 
             * vetores lidos e o vetor resultado.
             */
            double[] vetor1 = new double[5];
            double[] vetor2 = new double[5];
            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.Write("Digite o " + (i + 1) + " número: ");
                vetor1[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetor2.Length; i++)
            {

                vetor2[i] = vetor1[i];
                if (vetor1[i] == 0)
                {
                    vetor2[i] = 2;
                }
            }
            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine("V[" + i + "] = " + vetor2[i]);
            }
        }
    }
}