namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crie uma classe CorretoraDeImóveis com atributos para armazenar 
             * informações sobre imóveis (endereço, preço, tipo). Implemente um 
             * construtor e métodos para listar imóveis disponíveis e calcular o 
             * valor médio. Crie um menu que contenha as opções de inserir 
             * imoveis, alterar preço do imovel e apresentar todos os imoveis. 
             * Insira os imoveis numa lista para facilitar o trabalho. 
             */

            List<CorretoraDeImoveis> lista = new List<CorretoraDeImoveis>();
            Menu(lista);
        }

        public static void Menu(List<CorretoraDeImoveis> lista)
        {
            string opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Bem vindo a Corretora de Imóveis Ltda");
                Console.WriteLine("1 - Inserir imóvel ");
                Console.WriteLine("2 - Alterar Preço de imóvel  ");
                Console.WriteLine("3 - Mostrar todos imóveis ");
                Console.WriteLine("4 - Sair ");
                Console.Write("Escolha : ");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Controle.CadastrarImovel(lista);
                        break;
                    case "2":
                        Controle.AlterarPreco(lista);
                        break;
                    case "3":
                        Controle.ListarImoveis(lista);
                        break;
                    default:
                        Console.WriteLine("Nenhuma opção escolhida!");
                        break;
                }
                Console.Write("Tecle ENTER para continuar.....");
                Console.ReadKey(true);
            } while (opcao != "4");

        }

    }
}