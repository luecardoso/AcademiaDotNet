using System;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crie uma classe AgendaTelefônica com atributos para armazenar 
             * contatos (nome, telefone, e-mail). Implemente um construtor e 
             * métodos para adicionar numa lista, remover e buscar contatos.
             */
            List<AgendaTelefonica> lista = new List<AgendaTelefonica>();
            Menu(lista);
        }

        public static void Menu(List<AgendaTelefonica> lista)
        {
            string opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("* Agenda Telefonica *");
                Console.WriteLine("1 - Adicionar contato ");
                Console.WriteLine("2 - Remover contato ");
                Console.WriteLine("3 - Mostrar todos contatos ");
                Console.WriteLine("4 - Buscar contato ");
                Console.WriteLine("5 - Sair ");
                Console.Write("Escolha : ");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        AgendaTelefonica.Adicionar(lista);
                        break;
                    case "2":
                        AgendaTelefonica.Remover(lista);
                        break;
                    case "3":
                        AgendaTelefonica.ListarContatos(lista);
                        break;
                    case "4":
                        AgendaTelefonica.Buscar(lista);
                        break;
                    default:
                        Console.WriteLine("Nenhuma opção escolhida!");
                        break;
                }
                Console.Write("\nTecle ENTER para continuar.....");
                Console.ReadKey(true);
            } while (opcao != "5");

        }
    }
}