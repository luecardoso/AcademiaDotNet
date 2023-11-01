namespace Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //21 - Crie um programa que permita que o usuário selecione uma unidade de medida de entrada
            //(metros, centímetros, polegadas ou pés) e uma unidade de medida de saída usando um menu com
            //o comando switch case. O programa deve, em seguida, pedir ao usuário um valor de entrada e
            //converter esse valor para a unidade de saída selecionada.

            Console.WriteLine("--------------------------------");
            Console.WriteLine("----- SISTEMA DE CONVERSÃO -----");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("SELECIONE UMA UNIDADE DE MEDIDA");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1 - METROS");
            Console.WriteLine("2 - CENTIMETROS");
            Console.WriteLine("3 - POLEGADAS");
            Console.WriteLine("4 - PES");
            Console.WriteLine("--------------------------------");
            Console.Write("Escolha: ");
            string unidadeEntrada = Console.ReadLine();
            string unidadeSaida;
            double valorEntrada, valorSaida;

            Console.Write("Digite o valor de entrada: ");
            valorEntrada = double.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------------");
            switch (unidadeEntrada)
            {
                case "1":
                    Console.WriteLine("SELECIONE A UNIDADE DE SAÍDA");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("1 - CENTIMETROS");
                    Console.WriteLine("2 - POLEGADAS");
                    Console.WriteLine("3 - PES");
                    Console.Write("Converter para: ");
                    unidadeSaida = Console.ReadLine();
                    if (unidadeSaida == "1")
                    {
                        valorSaida = valorEntrada * 100;
                        Console.WriteLine("O valor de " + valorEntrada + " METROS para CENTIMETROS é = " + valorSaida);
                    }
                    else
                    if (unidadeSaida == "2")
                    {
                        valorSaida = valorEntrada * 39.37;
                        Console.WriteLine("O valor de " + valorEntrada + " METROS para POLEGADAS é = " + valorSaida.ToString("F2"));
                    }
                    else
                    {
                        valorSaida = valorEntrada * 3.281;
                        Console.WriteLine("O valor de " + valorEntrada + " METROS para PES é = " + valorSaida.ToString("F2"));
                    }
                    break;
                case "2":
                    Console.WriteLine("SELECIONE A UNIDADE DE SAÍDA");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("1 - METROS");
                    Console.WriteLine("2 - POLEGADAS");
                    Console.WriteLine("3 - PES");
                    Console.Write("Converter para: ");
                    unidadeSaida = Console.ReadLine();
                    if (unidadeSaida == "1")
                    {
                        valorSaida = valorEntrada / 100;
                        Console.WriteLine("O valor de " + valorEntrada + " CENTIMETROS para METROS é = " + valorSaida);
                    }
                    else
                    if (unidadeSaida == "2")
                    {
                        valorSaida = valorEntrada / 2.54;
                        Console.WriteLine("O valor de " + valorEntrada + " CENTIMETROS para POLEGADAS é = " + valorSaida.ToString("F2"));
                    }
                    else
                    {
                        valorSaida = valorEntrada / 30.48;
                        Console.WriteLine("O valor de " + valorEntrada + " CENTIMETROS para PES é = " + valorSaida.ToString("F2"));
                    }
                    break;
                case "3":
                    Console.WriteLine("SELECIONE A UNIDADE DE SAÍDA");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("1 - METROS");
                    Console.WriteLine("2 - CENTIMETROS");
                    Console.WriteLine("3 - PES");
                    Console.Write("Converter para: ");
                    unidadeSaida = Console.ReadLine();
                    if (unidadeSaida == "1")
                    {
                        valorSaida = valorEntrada / 39.37;
                        Console.WriteLine("O valor de " + valorEntrada + " POLEGADAS para METROS é = " + valorSaida.ToString("F2"));
                    }
                    else
                    if (unidadeSaida == "2")
                    {
                        valorSaida = valorEntrada * 2.54;
                        Console.WriteLine("O valor de " + valorEntrada + " POLEGADAS para CENTIMETROS é = " + valorSaida);
                    }
                    else
                    {
                        valorSaida = valorEntrada / 12;
                        Console.WriteLine("O valor de " + valorEntrada + " POLEGADAS para PES é = " + valorSaida.ToString("F2"));
                    }
                    break;
                case "4":
                    Console.WriteLine("SELECIONE UMA UNIDADE DE MEDIDA");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("1 - METROS");
                    Console.WriteLine("2 - CENTIMETROS");
                    Console.WriteLine("3 - POLEGADAS");
                    Console.Write("Converter para: ");
                    unidadeSaida = Console.ReadLine();
                    if (unidadeSaida == "1")
                    {
                        valorSaida = valorEntrada / 3.281;
                        Console.WriteLine("O valor de " + valorEntrada + " PES para METROS é = " + valorSaida.ToString("F2"));
                    }
                    else
                    if (unidadeSaida == "2")
                    {
                        valorSaida = valorEntrada * 30.48;
                        Console.WriteLine("O valor de " + valorEntrada + " PES para CENTIMETROS é = " + valorSaida);
                    }
                    else
                    {
                        valorSaida = valorEntrada * 12;
                        Console.WriteLine("O valor de " + valorEntrada + " PES para POLEGADAS é = " + valorSaida.ToString("F2"));
                    }
                    break;

                default:
                    Console.WriteLine("Nenhuma unidade escolhida! Fim do Sistema");
                    break;
            }
            Console.WriteLine("--------------------------------");
        }
    }
}