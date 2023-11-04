namespace Arquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string nome, email;
            List<Pessoa> lista = new List<Pessoa>();
            Persistencia.popularArquivoLista("alunos.csv", lista); //conexao com a base

            Persistencia.exibirLista(lista);

            Pessoa tmp;
            do
            {
                Console.Write("Digite nome ou sair para finalizar: ");
                nome = Console.ReadLine().ToUpper();
                if (nome == "SAIR")
                {
                    break;
                }
                Console.Write("Digite email: ");
                email = Console.ReadLine().ToLower();
                tmp = new Pessoa(nome, email);

                if (lista.Contains(tmp))
                {
                    Console.WriteLine("Email já em uso!!");
                }
                else
                {
                    lista.Add(tmp);
                    Persistencia.gravarSimples(tmp, "alunos.csv");
                }
            } while (true);

        }
    }
}