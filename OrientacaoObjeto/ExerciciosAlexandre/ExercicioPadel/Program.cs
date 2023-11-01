﻿namespace ExercicioPadel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Atleta> listaAtletas = new List<Atleta>();
            string opcao = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Menu Padel");
                Console.WriteLine("1 - Cadastrar atleta");
                Console.WriteLine("2 - Listar atletas");
                Console.WriteLine("3 - Remover atleta");
                Console.WriteLine("7 - Sair");
                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Cadastro de atleta");
                        Comunicacao.cadastrarAtleta(listaAtletas);
                        //Persistencia.gravarAtleta(listaAtletas);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Listagem de atletas");
                        Comunicacao.listarAtletas(listaAtletas);

                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Remoção de atleta");
                        Comunicacao.removerAtleta(listaAtletas);
                        //Persistencia.gravarAtleta(listaAtletas);
                        break;
                    case "7":
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.Write("Tecle ENTER para continuar.....");
                Console.ReadKey(true);
            } while (opcao != "7");



        }
    }
}