using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaVetores
{
    internal class Exercicio13
    {
        public static void numeroRepetido()
        {
            /*
             * 13.	Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir
             * quantas vezes aparecem os números 2, 4 e 8. O vetor terá no máximo 100 posições.
             * Sair do programa quando for digitado -1 ou quando atingir o máximo de posições 
             * do vetor.
             */

            int[] vetor = new int[10];
            int dois = 0, quatro = 0, oito = 0;

            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite o " + (i + 1) + " número: ");
                vetor[i] = int.Parse(Console.ReadLine());
                if (vetor[i] <= -1)
                {
                    break;
                }
                if (vetor[i] == 2)
                {
                    dois++;
                }
                if (vetor[i] == 4)
                {
                    quatro++;
                }
                if (vetor[i] == 8)
                {
                    oito++;
                }

            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Quantidade de 2 qua aparecem: " + dois);
            Console.WriteLine("Quantidade de 4 qua aparecem: " + quatro);
            Console.WriteLine("Quantidade de 8 qua aparecem: " + oito);
            //Console.WriteLine("Quantidade de 2,4,8 qua aparecem: " + (dois+quatro+oito));
            Console.WriteLine("-------------------------------------");
        }
    }
}
