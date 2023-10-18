using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaSelecao
{
    internal class Exercicio06
    {
        public static void controleEstoque()
        {
            //6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, isto é,
            //o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem de IPI (única) a ser acrescentada. 

            Console.WriteLine("------------------");
            Console.WriteLine("----Parafuso A----");

            Console.Write("Código: ");
            string codigoA = Console.ReadLine();

            Console.Write("Quantidade: ");
            int quantidadeA = int.Parse(Console.ReadLine());

            Console.Write("Valor $: ");
            double valorA = double.Parse(Console.ReadLine());

            Console.Write("Porcentagem IPI: ");
            int porcentagemA = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------");
            Console.WriteLine("----Parafuso B----");

            Console.Write("Código: ");
            string codigoB = Console.ReadLine();

            Console.Write("Quantidade: ");
            int quantidadeB = int.Parse(Console.ReadLine());

            Console.Write("Valor $: ");
            double valorB = double.Parse(Console.ReadLine());

            Console.Write("Porcentagem IPI: ");
            int porcentagemB = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------");
            Console.WriteLine("-------Dados------");
            Console.WriteLine("Parafuso A");
            Console.WriteLine("Código " + codigoA);
            Console.WriteLine("Quantidade" + quantidadeA);
            Console.WriteLine("Valor $: " + valorA);
            Console.WriteLine("Porcentagem IPI " + porcentagemA + "%");
            Console.WriteLine("------------------");
            Console.WriteLine("Parafuso B");
            Console.WriteLine("Código " + codigoB);
            Console.WriteLine("Quantidade" + quantidadeB);
            Console.WriteLine("Valor $: " + valorB);
            Console.WriteLine("Porcentagem IPI " + porcentagemB + "%");
            Console.WriteLine("------------------");

        }
    }
}
