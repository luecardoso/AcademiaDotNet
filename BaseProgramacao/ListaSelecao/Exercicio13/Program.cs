namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de 
                custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma 
                comissão de 15% sobre o preço de custo de cada bicicleta vendida. 
                Desenvolva um algoritmo que leia o valor do salário mínimo, o preço 
                de custo de cada bicicleta e o número de bicicletas vendidas pelo 
                vendedor, calcule e mostre: o salário do empregado
             */
            Console.WriteLine("------------------------------------");
            Console.Write("Salário Mínimo: ");
            double salarioMinimo = double.Parse(Console.ReadLine());

            Console.Write("Valor da Bicicleta R$: ");
            double valorBicicleta = double.Parse(Console.ReadLine());

            Console.Write("Qtd de Bicicletas Vendidas: ");
            double qtdVendida = double.Parse(Console.ReadLine());

            double valorAcrescimo = valorBicicleta + valorBicicleta * 50 / 100;
            double valorVendido = 0.15 * qtdVendida * valorAcrescimo;
            double salarioFuncionario = 2 * salarioMinimo + valorVendido;

            Console.WriteLine("Salário do Funcionário " + salarioFuncionario);
            Console.WriteLine("------------------------------------");
        }
    }
}