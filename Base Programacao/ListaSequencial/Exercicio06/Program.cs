namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 Faça um programa em C# e no Visual Studio para receber o nome 
                (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma 
                pessoa. O programa deve calcular o Indice de Massa Corpórea (IMC), 
                exibi-lo ao usuário e informar sua situação conforme a tabela.

                O cálculo do imc = peso / (altura * altura)

                >menor que 18                -> baixo peso
                >maior que 18 e menor que 25 -> peso normal
                >maior que 25 e menor que 30 -> sobrepeso
                >maior que 30 e menor que 35 -> obesidade
                >maior que 35                -> obesidade grau sério
             */

            Console.WriteLine("-----------------------------");
            Console.WriteLine("------- *CALCULO IMC* --------");
            Console.WriteLine("-----------------------------");
            Console.Write("Nome: ");
            string nome = Console.ReadLine().ToUpper();
            Console.Write("Altura (metros): ");
            double altura = double.Parse(Console.ReadLine());
            Console.Write("Peso (kg): ");
            double peso = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine("IMC " + imc.ToString("F2"));

            if (imc > 35)
            {
                Console.WriteLine("OBESIDADE GRAU SÉRIO");
            }
            else if (imc > 30 && imc < 35)
            {
                Console.WriteLine("OBESIDADE");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("SOBREPESO");
            }
            else if (imc >= 18 && imc < 25)
            {
                Console.WriteLine("PESO NORMAL");
            }
            else
            {
                Console.WriteLine("BAIXO PESO");
            }
            Console.WriteLine("-----------------------------");

        }
    }
}