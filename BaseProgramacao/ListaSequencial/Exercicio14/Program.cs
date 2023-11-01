namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                14 - Faça um programa que peça o tamanho de um arquivo para download
                (em MB) e a velocidade de um link de Internet (em Mbps). Em seguida, 
                calcule e informe o tempo aproximado de download do arquivo usando 
                este link (em minutos).
             */

            Console.WriteLine("--------------------------------------");
            Console.Write("Digite o tamanho do arquivo em Mb: ");
            double arquivo = double.Parse(Console.ReadLine());

            Console.Write("Digite a velocidade de download em Mbps: ");
            double velocidade = double.Parse(Console.ReadLine());


            double download = velocidade / 8;
            double tempo = arquivo / download / 60;

            Console.WriteLine("O tempo de download será de " + tempo.ToString("F2") + " minuto(s)");
            Console.WriteLine("--------------------------------------");
        }
    }
}