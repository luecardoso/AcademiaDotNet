namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, 
            representando a medição diária de um paciente diabético. Para cada valor 
            recebido analisar e informar ao paciente o seguinte:
            Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
            Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.
            Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. 
            E se a média for menor que 80, avisá-lo que é preciso diminuir 2 unidades de 
            insulina. Se a média for maior que 150, avisá-lo que será necessário adicionar 
            2 unidades de insulina.
             
             */

            Console.WriteLine("--------------------------------------");
            Console.Write("Digite o 1o valor da Glicemia: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2o valor da Glicemia: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 3o valor da Glicemia: ");
            int valor3 = int.Parse(Console.ReadLine());

            double media = (valor1 + valor2 + valor3) / 3;

            if (valor1 < 65 || valor2 < 65 || valor3 < 65)
            {
                Console.WriteLine("Risco de Hipoglicemia");
            }
            else
            if (valor1 > 250 || valor2 > 250 || valor3 > 250)
            {
                Console.WriteLine("Risco de Hiperglicemia");
            }

            if (media < 80)
            {
                Console.WriteLine("Precisa diminuir 2 unidades de insulina!");
            }
            else
            if (media > 150)
            {
                Console.WriteLine("Precisa adicionar 2 unidades de insulina!");
            }
            Console.WriteLine("--------------------------------------");
        }
    }
}