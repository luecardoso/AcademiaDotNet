namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 Faça um programa no VS que receba o código, nome, salário base e o 
                total de vendas de um funcionário. Caso o total de vendas seja acima 
                de R$ 500,00, adicionar ao seu salário final 5% do total de vendas. 
                Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu 
                salário final 7% do total de vendas. E por fim, se o total de vendas 
                seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
                total de vendas. 
             */
            Console.WriteLine("--------------------------------------");
            Console.Write("Código: ");
            string codigo = Console.ReadLine();
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Salário Base R$: ");
            double salarioBase = double.Parse(Console.ReadLine());

            Console.Write("Total de Vendas R$: ");
            double totalVendas = double.Parse(Console.ReadLine());

            double salarioFinal = 0;

            if (totalVendas >= 5000)
            {
                salarioFinal = 0.10 * totalVendas + salarioBase;
            }
            else
            if (totalVendas >= 1000)
            {
                salarioFinal = 0.07 * totalVendas + salarioBase;
            }
            else
            if (totalVendas >= 500)
            {
                salarioFinal = 0.05 * totalVendas + salarioBase;
            }
            Console.WriteLine("Salário Final R$: " + salarioFinal.ToString("F2"));
            Console.WriteLine("--------------------------------------");
        }
    }
}