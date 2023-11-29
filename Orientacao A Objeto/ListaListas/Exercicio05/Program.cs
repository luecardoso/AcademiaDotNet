namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crie uma classe GerenciadorDeTarefas com atributos para armazenar
             * uma lista de tarefas (descrição, data de vencimento). Implemente 
             * um construtor e métodos para adicionar, remover e listar tarefas. 
             * Adicione um método para verificar se a tarefa deverá ser executada 
             * no dia de hoje. 
             */
            List<GerenciadorDeTarefas> tarefa = new List<GerenciadorDeTarefas> ();
            Menu(tarefa);
        }


        public static void Menu(List<GerenciadorDeTarefas> lista)
        {
            string opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("* Gerenciador de Tarefas *");
                Console.WriteLine("1 - Adicionar tarefa ");
                Console.WriteLine("2 - Remover tarefa ");
                Console.WriteLine("3 - Mostrar todas tarefas ");
                Console.WriteLine("4 - Sair ");
                Console.Write("Escolha : ");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        GerenciadorDeTarefas.Adicionar(lista);
                        break;
                    case "2":
                        GerenciadorDeTarefas.Remover(lista);
                        break;
                    case "3":
                        GerenciadorDeTarefas.Listar(lista);
                        break;
                    default:
                        Console.WriteLine("Nenhuma opção escolhida!");
                        break;
                }
                Console.Write("\nTecle ENTER para continuar.....");
                Console.ReadKey(true);
            } while (opcao != "4");

        }


    }
}