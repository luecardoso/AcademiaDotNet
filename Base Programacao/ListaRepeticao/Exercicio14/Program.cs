namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
                A cada solicitação, teste se o usuário informou um valor válido. 
                Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em 
                branco ou se for um número), informe que ele está incorreto e saia do programa em VS. 
                Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor
                ou igual a zero), informe que está errada e saia. Se estiver correta, solicite
                o salário. 
                Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto 
                e saia. 
                Se estiver correto, mostre todos os valores lidos.
             */

            string nome;
            int idade = 0;
            double salario;
            bool ehNumero = true, deuCerto = true;
            do
            {
                Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();
                foreach (char caracter in nome)
                {
                    ehNumero = Char.IsNumber(caracter);
                    if (ehNumero)
                    {
                        Console.WriteLine("Não é um nome válido!");
                        break;
                    }
                }
            } while (ehNumero);

            do
            {
                Console.Write("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade <= 0)
                {
                    deuCerto = false;
                    Console.WriteLine("Idade incorreta!");
                }
                else
                {
                    deuCerto = true;
                }
            } while (!deuCerto);

            if (idade <= 0)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Write("Digite seu salário: ");
                salario = double.Parse(Console.ReadLine());
                if (salario <= 0)
                {
                    Console.WriteLine("Salário incorreto!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Nome: " + nome);
                    Console.WriteLine("idade: " + idade);
                    Console.WriteLine("Salário: " + salario);
                }
            }
        }
    }
}