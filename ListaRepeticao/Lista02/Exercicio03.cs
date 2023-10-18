using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaRepeticao.Lista02
{
    internal class Exercicio03
    {
        public static void verificarNumeroPrimo()
        {
            /*
                3. Fazer um laço (repetição) que fique solicitando 
                números ao usuário. Se o usuário digitar 0 o programa 
                em VS deve parar. Caso contrário, o programa em VS deve 
                informar se o número é par ou ímpar e se ele é um número primo.   
             */

            int numero, cont = 0;

            do
            {
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    break;
                }

                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero + " É PAR!");
                }
                else
                {
                    Console.WriteLine(numero + " É IMPAR!");
                }

                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        cont++;     
                    }
                }
                if (cont == 2)
                {
                    Console.WriteLine(numero + " É PRIMO!");
                }
                else
                {
                    Console.WriteLine(numero + " NÃO É PRIMO!");
                }
                cont = 0;
            } while (numero != 0);
        }
    }
}
