using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaRepeticao.Lista02
{
    internal class Exercicio16
    {
        public static void multiplicacaoSucessiva()
        {
            /*
             16. Ler um número N qualquer menor ou igual a 50 e apresentar o 
            valor obtido da multiplicação sucessiva de N por 3 enquanto o 
            produto for menor que 250 (N*3; N*3*3; N*3*3*3; etc).
             */

            int numero;
            do
            {
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine());
            } while (numero <= 0 || numero > 50);

            Console.WriteLine(numero);
            do
            {
                numero *= 3;
                if (numero > 250)
                {
                    numero /= 3;
                    break;
                }
                Console.WriteLine(numero);
            } while (numero < 250);

        }
    }
}
