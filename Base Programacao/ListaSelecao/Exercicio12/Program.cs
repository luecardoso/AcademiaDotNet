namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Um motorista de taxi deseja calcular o rendimento de seu carro na 
               praça. Sabendo-se que o preço do combustível é de 6,90R  escreva um 
               algoritmo para ler a marcação do odômetro (marcador de quilometragem)
               no início do dia, a marcação no final do dia, o número de litros de 
               combustível gasto e o valor total (R$) recebido dos passageiros. 
               Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.


               Fórmulas: Total quilometragem =  marcação odômetro final do dia - marcação odômetro inicio do dia 
               Média do consumo = Total quilometragem/ quantidade de combustível gasto
               Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)

            */
            Console.WriteLine("------------------------------------");
            Console.Write("Inicio do dia Km: ");
            double inicioKm = double.Parse(Console.ReadLine());

            Console.Write("Fim do dia Km: ");
            double fimoKm = double.Parse(Console.ReadLine());
            double combustivel = 6.90;

            Console.Write("Qtd. Litros utilizados: ");
            double litros = double.Parse(Console.ReadLine());

            Console.Write("Valor recebido em R$: ");
            double valor = double.Parse(Console.ReadLine());

            double totalKm = fimoKm - inicioKm;
            double media = totalKm / litros;
            double lucro = valor - litros * combustivel;
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Média Km/L " + media.ToString("F2"));
            Console.WriteLine("Lucro do dia: " + lucro.ToString("F2"));
            Console.WriteLine("------------------------------------");
        }
    }
}