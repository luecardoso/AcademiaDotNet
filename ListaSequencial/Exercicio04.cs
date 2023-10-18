using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios.ListaSequencial
{
    internal class Exercicio04
    {
        public static void calculoSalario()
        {
            //4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido
            //por cada um deles.  Mostrar na tela qual dos professores tem o maior salário total.
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Professor 1: ");
            Console.Write("Quantidade de Horas Aula Dadas: ");
            int horaProfessor1 = int.Parse(Console.ReadLine());

            Console.Write("Valor por Hora Aula: ");
            double valorProfessor1 = double.Parse(Console.ReadLine());
            double salarioProfessor1 = horaProfessor1 * valorProfessor1;

            Console.WriteLine("Professor 2: ");
            Console.Write("Quantidade de Horas Aula Dadas: ");
            int horaProfessor2 = int.Parse(Console.ReadLine());

            Console.Write("Valor por Hora Aula: ");
            double valorProfessor2 = double.Parse(Console.ReadLine());

            double salarioProfessor2 = horaProfessor2 * valorProfessor2;

            if (salarioProfessor1 == salarioProfessor2)
            {
                Console.WriteLine("Os Professores possuem o mesmo salário = " + salarioProfessor1);
            }
            else if (salarioProfessor1 > salarioProfessor2)
            {
                Console.WriteLine("Professor 1 possue o maior salário = " + salarioProfessor1);
            }
            else
            {
                Console.WriteLine("Professor 2 possue o maior salário = " + salarioProfessor2);
            }
            Console.WriteLine("-------------------------------------------");
        }
    }
}
