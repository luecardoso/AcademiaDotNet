using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaSequencial
{
    internal class Exercicio12
    {
        public static void calculoSalario()
        {
            /*
             Elabore um programa em VS que leia as variáveis "codigo" e 
            "numeroHoras", respectivamente código e número de horas trabalhadas 
            de um operário. Na sequência, calcule o salário sabendo-se que ele 
            ganha R$ 10,00 por hora. Quando o número de horas exceder a 50 
            calcule o excesso de pagamento armazenando-o na variável "extra", 
            caso contrário zerar tal variável. A hora excedente de trabalho vale 
            R$ 20,00. No final do processamento, exibir o salário total e o salário 
            excedente do operário.
             */
            Console.WriteLine("--------------------------------------");
            Console.Write("Código: ");
            string codigo = Console.ReadLine();

            Console.Write("Horas trabalhadas: ");
            int numeroHoras = int.Parse(Console.ReadLine());

            double salario = 0, salarioExedente = 0;
            int extra = 0, mais50 = 0;

            if (numeroHoras > 50)
            {
                mais50 = numeroHoras / 50 - 1;
                extra = numeroHoras % 50;
                if (mais50 <= 0)
                {
                    salario += (numeroHoras - extra) * 10;
                }
                else
                {
                    salario += (numeroHoras - mais50 * 50 - extra) * 10;
                }
                salarioExedente += extra * 20;
                salarioExedente += mais50 * 50 * 20;
                salario += salarioExedente;
            }
            else
            {
                salario = numeroHoras * 10;
            }
            //Console.WriteLine("mais50: " + mais50);
            //Console.WriteLine("Horas extras: " + extra);
            Console.WriteLine("Ganho por hora execente R$: " + salarioExedente);
            Console.WriteLine("Salário total R$: " + salario);
            Console.WriteLine("--------------------------------------");

        }
    }
}
