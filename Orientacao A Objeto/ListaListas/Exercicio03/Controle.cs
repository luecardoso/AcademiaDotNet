using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercicio03
{
    internal class Controle
    {

        
        public static void CadastrarImovel(List<CorretoraDeImoveis> imoveis)
        {
            
            CorretoraDeImoveis imovel = new CorretoraDeImoveis();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Tipo do imóvel ");
            Console.WriteLine("1 - Casa geminada ");
            Console.WriteLine("2 - Sobrado  ");
            Console.WriteLine("3 - Kitnet ");
            Console.WriteLine("4 - Apartamento  ");
            Console.WriteLine("5 - Studio  ");
            Console.Write("Escolha : ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    imovel.Tipo = "Casa geminada";
                    break;
                case "2":
                    imovel.Tipo = "Sobrado";
                    break;
                case "3":
                    imovel.Tipo = "Kitnet";
                    break;
                case "4":
                    imovel.Tipo = "Apartamento";
                    break;
                case "5":
                    imovel.Tipo = "Studio";
                    break;
                default:
                    Console.WriteLine("Nenhum imovel escolhido!");
                    break;
            }


            Console.Write("Endereço do imóvel: ");
            imovel.Endereco = Console.ReadLine();

            Console.Write("Preço do imóvel: R$");
            imovel.Preco = double.Parse(Console.ReadLine());

            imovel.Disponibilidade = true;
            imovel.Id = imoveis.Count + 1;
            imoveis.Add(imovel);

        }

        public static void ListarImoveis(List<CorretoraDeImoveis> imoveis)
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Lista de Imóveis Disponíveis");
            if (imoveis.Count == 0)
            {
                Console.WriteLine("Nenhum imóvel cadastrado");
            }
            else
            {
                Console.WriteLine(" ");
                foreach (CorretoraDeImoveis imovel in imoveis)
                {
                    if (imovel.Disponibilidade)
                    {
                        
                        Console.WriteLine(imovel);
                    }
                
                }
                CalculoValorMedio(imoveis);     
            }
        }

        public static void AlterarPreco(List<CorretoraDeImoveis> imoveis)
        {
            if (imoveis.Count == 0)
            {
                Console.WriteLine("Não há nenhum imóvel cadastrado");
                return;
            }
            ListarImoveis(imoveis);
            Console.WriteLine("\n\nSelecione o imóvel que deseja alterar o preço :");
            Console.Write("Escolha: ");
            int escolha = int.Parse(Console.ReadLine());
            Console.Write("Digite o novo valor para esse imóvel: R$");
            double valor = double.Parse(Console.ReadLine());
            for (int i = 0; i < imoveis.Count; i++)
            {
                if (escolha == imoveis[i].Id)
                {
                    imoveis[i].Preco = valor;
                }
            }
        }

        public static void CalculoValorMedio(List<CorretoraDeImoveis> imoveis)
        {
            Console.WriteLine("\n\n");
            double valor = 0;
            foreach (CorretoraDeImoveis imovel in imoveis)
            {
                valor += imovel.Preco;
            }
            valor = (valor / imoveis.Count);
            if (imoveis.Count == 0)
            {
                valor = 0;
            }
            Console.WriteLine("Valor médio dos imóveis = " + valor.ToString("F2"));
        }



    }
}
