namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fazer uma calculadora das 4 operações 
             * (soma, subtração, multiplicação e divisão) 
             * Para isso, precisaremos aceitar números com vírgula.
             */
            string escolha = "";
            escolhas(menu(escolha));

        }

        static double digiteNumero()
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());
            return numero;
        }

        static string menu(string opcao)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("------Calculadora-------");
            Console.WriteLine("1 - Adição(+)");
            Console.WriteLine("2 - Subtração(-)");
            Console.WriteLine("3 - Multiplicação(*)");
            Console.WriteLine("4 - Divisão(/)");
            Console.WriteLine("------------------------");
            Console.Write("Selecione uma operação: ");
            opcao = Console.ReadLine();
            return opcao;
        }

        static void escolhas(string opcao)
        {
            double valor1, valor2;
            switch (opcao)
            {

                case "1":
                    valor1 = digiteNumero();
                    valor2 = digiteNumero();
                    adicao(valor1, valor2);
                    break;
                case "2":
                    valor1 = digiteNumero();
                    valor2 = digiteNumero();
                    subtracao(valor1, valor2);
                    break;
                case "3":
                    valor1 = digiteNumero();
                    valor2 = digiteNumero();
                    multiplicacao(valor1, valor2);
                    break;
                case "4":
                    valor1 = digiteNumero();
                    valor2 = digiteNumero();
                    divisao(valor1, valor2);
                    break;
                default:
                    Console.WriteLine("Nenhuma operação escolhida!");
                    break;
            }
        }

        static double adicao(double a, double b)
        {
            double resultado = a + b;
            Console.WriteLine("O resultado de " + a + " + " + b + " = " + resultado);
            return resultado;
        }
        static double subtracao(double a, double b)
        {
            double resultado = a - b;
            Console.WriteLine("O resultado de " + a + " - " + b + " = " + resultado);
            return resultado;
        }
        static double multiplicacao(double a, double b)
        {
            double resultado = a * b;
            Console.WriteLine("O resultado de " + a + " * " + b + " = " + resultado);
            return resultado;
        }
        static double divisao(double a, double b)
        {
            double resultado;
            if (b == 0)
            {
                resultado = 0;
                Console.WriteLine("Impossível dividir por 0!");
            }
            else
            {
                resultado = a / b;
                Console.WriteLine("O resultado de " + a + " / " + b + " = " + resultado);
            }
            return resultado;
        }
    }
}