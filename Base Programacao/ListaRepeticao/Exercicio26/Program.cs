namespace Exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            19. A prefeitura de uma cidade fez uma pesquisa entre seus 
           habitantes, coletando dados sobre o salário e número de filhos.
           A prefeitura deseja saber: 

           a) média do salário da população;
           b) média do número de filhos;
           c) maior salário;
           d) percentual de pessoas com salário até R$ 100,00.
           O final da leitura de dados se dará com a entrada de um salário negativo.

            */

            int habitantes = 0, filhos = 0, pessoas100 = 0;
            double somaSalario = 0, somaFilhos = 0, salario = 0,
                mediaSalario = 0, mediaFilhos = 0, maiorSalario = 0,
                percentual = 0;
            do
            {
                Console.WriteLine("----------------------------------------");
                Console.Write("Digite o seu salario: ");
                salario = double.Parse(Console.ReadLine());
                if (salario < 0)
                {
                    break;
                }
                if (salario > maiorSalario)
                {
                    maiorSalario = salario;
                }
                if (salario >= 0 && salario <= 100)
                {
                    pessoas100++;
                }
                somaSalario += salario;
                habitantes++;
                Console.Write("Quantos filhos você tem: ");
                filhos = int.Parse(Console.ReadLine());
                somaFilhos += filhos;

            } while (salario > 0);

            if (habitantes > 0)
            {
                mediaSalario = somaSalario / habitantes;
                mediaFilhos = somaFilhos / habitantes;
                percentual = pessoas100 / habitantes * 100;
            }


            Console.WriteLine("Média de salário da população: " + mediaSalario.ToString("F2"));
            Console.WriteLine("Média do número de filhos: " + mediaFilhos);
            Console.WriteLine("Maior salário: " + maiorSalario.ToString("F2"));
            Console.WriteLine("Percentual de pessoas com salário até R$ 100,00: " + percentual + "%");
        }
    }
}