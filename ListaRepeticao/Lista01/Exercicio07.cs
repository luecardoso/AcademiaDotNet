using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaRepeticao.Lista01
{
    internal class Exercicio07
    {
        public static void quantidadeImparEPar()
        {
            //7. Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e
            //ímpares digitados por um usuário. Apresente o resultado.
            int par = 0, impar = 0;


            for (int i = 0; i < 20; i++)
            {
                Console.Write("Digite o " + (i + 1) + "o número: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }

            }
            Console.WriteLine("Pares: " + par);
            Console.WriteLine("Impares: " + impar);
        }
    }
}
