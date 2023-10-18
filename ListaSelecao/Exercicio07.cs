using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaSelecao
{
    internal class Exercicio07
    {
        public static void calcularSalario()
        {
            //7)Escreva um programa em C# e no Visual Studio que leia o número de um vendedor,
            //o seu salário fixo, o total de vendas por ele efetuadas e o percentual que ganha
            //sobre o total de vendas. Calcule o salário total do vendedor.
            //Escreva o número do vendedor e o salário total do vendedor.

            Console.WriteLine("-------------------------------------");
            Console.Write("Insira o ID do funcionário: ");
            string id = Console.ReadLine();

            Console.Write("Salário: R$");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Total de vendas: R$");
            double vendas = double.Parse(Console.ReadLine());

            Console.Write("Percentual(%) de vendas: ");
            double perc = double.Parse(Console.ReadLine());

            double salarioTotal = (vendas * (perc / 100)) + salario;


            Console.WriteLine("Salário total: R$" + salarioTotal);
            Console.WriteLine("-------------------------------------");
        }
    }
}
