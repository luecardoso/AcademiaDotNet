namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Faça um programa em VS que solicite um numero inteiro. Se o 
             * numero não for inteiro, solicite-o até que seja. após, 
             * informe se ele é par ou impar. Finalmente, pergunte ao 
             * usuário se ele quer repetir o programa em VS.
             */
            bool deuCerto = true;
            string resposta = "";
            do
            {
                do
                {
                    Console.Write("Digite um número inteiro: ");
                    string numero = Console.ReadLine();
                    deuCerto = int.TryParse(numero, out var valor);

                    if (deuCerto)
                    {
                        if (int.Parse(numero) % 2 == 0)
                        {
                            Console.WriteLine(numero + " É PAR");
                        }
                        else
                        {
                            Console.WriteLine(numero + " É ÍMPAR");
                        }

                        Console.Write("Deseja repetir? S/N ");
                        resposta = Console.ReadLine();
                    }
                } while (deuCerto != true);
                //nsole.WriteLine(valor);
            } while (resposta.ToUpper() != "N");



        }
    }
}