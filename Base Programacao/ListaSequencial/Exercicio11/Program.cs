namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis 
                (uma para hora e outra para minutos). O programa deve exibir se a hora 
                digitada está ou não válida. Lembre que usaremos o padrão de hora com 24h, 
                de 0 a 23.
             */
            Console.WriteLine("--------------------------------------");
            Console.Write("Hora: ");
            int hora = int.Parse(Console.ReadLine());

            Console.Write("Minutos: ");
            int minutos = int.Parse(Console.ReadLine());

            if (hora >= 0 && hora <= 23)
            {
                if (minutos >= 0 && minutos <= 59)
                {
                    Console.WriteLine("Hora Válida!");
                }
                else
                {
                    Console.WriteLine("Hora Inválida!");
                    Console.WriteLine(hora + "h" + minutos);
                }
            }
            else
            {
                Console.WriteLine("Hora Inválida!");
            }
            Console.WriteLine("--------------------------------------");
        }
    }
}