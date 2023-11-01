namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Ler nome, sexo e idade de 50 pessoas e após imprimir:
                Número de pessoas do sexo masculino.
                Número de pessoas do sexo feminino.
                Número de pessoas com idade inferior a 30 anos.
                Número de pessoas com idade superior a 60 anos.
                Média de idade das mulheres.
             */
            int idadeMenor30 = 0, idadeMaior60 = 0, soma = 0, pessoasMulheres = 0, pessoasHomens = 0;
            double media = 0;

            for (int i = 0; i < 50; i++)
            {
                Console.Write("Digite seu nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite sua idade: ");
                int idade = int.Parse(Console.ReadLine());

                Console.Write("Digite seu sexo: ");
                string sexo = Console.ReadLine().ToUpper();

                if (idade < 30)
                {
                    idadeMenor30++;
                }
                if (idade > 60)
                {
                    idadeMaior60++;
                }
                if (sexo.Equals("FEMININO") || sexo.Equals("F"))
                {
                    pessoasMulheres++;
                    soma += idade;
                }
                if (sexo.Equals("MASCULINO") || sexo.Equals("M"))
                {
                    pessoasHomens++;
                }

                Console.WriteLine("-----------------------------------");
            }
            media = soma / pessoasMulheres;

            Console.WriteLine("Nº de Pessoas de sexo M: " + pessoasHomens);
            Console.WriteLine("Nº de Pessoas de sexo F: " + pessoasMulheres);
            Console.WriteLine("Qtd. de idades abaixo de 30 anos: " + idadeMenor30);
            Console.WriteLine("Qtd. de idades maior que 60 anos: " + idadeMaior60);
            Console.WriteLine("Média das idades de sexo F: " + media);
        }
    }
}