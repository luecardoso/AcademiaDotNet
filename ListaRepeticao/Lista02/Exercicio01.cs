using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaRepeticao.Lista02
{
    internal class Exercicio01
    {
        public static void quantidadeParesIntervalo()
        {
            /*
                 1. Faça um programa em VS que solicite um número 
                inteiro positivo ao usuário, validando a entrada de 
                dados (informando se ele estiver errado e repetindo 
                a solicitação até que esteja correto). Após o programa 
                em VS deve informar todos os números pares existentes 
                entre 1 e o número fornecido pelo usuário.

                Exemplo:
                Digite um número inteiro positivo: -8
                Valor incorreto!
                Digite um número inteiro positivo: 8
                Numero digitado: 8
                Números inteiros pares entre 1 e 8: 2, 4, 6.
             */
            int numero, par = 0;
            do
            {
                Console.Write("Digite um número inteiro positivo: ");
                numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    Console.WriteLine("Valor incorreto!");
                }

            } while (numero < 0);

            Console.WriteLine("Número digitado: " + numero);
            Console.Write("Números inteiros pares entre 1 e " + numero + ": ");
            for (int i = 1; i < numero; i++)
            {

                if (i % 2 == 0)
                {
                    par = i;
                    Console.Write(i + " ");
                }
            }
        }
    }
}
