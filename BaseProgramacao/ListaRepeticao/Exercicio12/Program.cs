namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 5. Modifique o programa em VS anterior para aceitar
                votos nulos (qualquer nome diferente de FIM, JOAO, ZECA 
                e BRANCO). Ao final, informe o nome do candidato vencedor, 
                o número de votos nulos e o número de pessoas que votaram.
             */
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("----- *ELEIÇÃO PARA PREFEITO* -----");
            Console.WriteLine("-----------------------------------");
            string palavra;
            int joao = 0, zeca = 0, branco = 0, nulo = 0;
            do
            {

                Console.WriteLine("------------ *VOTOS* --------------");
                Console.WriteLine("JOAO");
                Console.WriteLine("ZECA");
                Console.WriteLine("BRANCO");
                Console.WriteLine("NULO");
                Console.WriteLine("-----------------------------------");
                Console.Write("Insira seu voto: ");
                palavra = Console.ReadLine();

                if (palavra.ToUpper().Equals("FIM"))
                {
                    break;
                }
                if (palavra.ToUpper().Equals("JOAO"))
                {
                    joao++;
                }
                if (palavra.ToUpper().Equals("ZECA"))
                {
                    zeca++;
                }
                if (palavra.ToUpper().Equals("BRANCO"))
                {
                    branco++;
                }
                if (!palavra.ToUpper().Equals("JOAO") && !palavra.ToUpper().Equals("ZECA") && !palavra.ToUpper().Equals("BRANCO"))
                {
                    nulo++;
                }

            } while (palavra.ToUpper() != "FIM");

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("------- *CONATEGM DE VOTOS* -------");
            Console.WriteLine("JOAO: " + joao + " voto(s)");
            Console.WriteLine("ZECA: " + zeca + " voto(s)");
            Console.WriteLine("BRANCO: " + branco + " voto(s)");
            Console.WriteLine("NULO: " + nulo + " voto(s)");
            Console.WriteLine("-----------------------------------");
        }
    }
}