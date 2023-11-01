namespace Exercício21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14. Mostrar as potências de 2 variando de 0 a 10.
            int potencia = 1, basePotencia = 2;
            for (int i = 0; i <= 10; i++)
            {
                if (i == 0)
                {
                    potencia = basePotencia / 2;
                }
                else
                {
                    potencia *= basePotencia;
                }

                Console.WriteLine("2 ^ " + i + " = " + potencia);
            }
        }
    }
}