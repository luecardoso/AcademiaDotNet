using CA_Entity.DataModels;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace CA_Entity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite: \n" +
                "1 para criar uma pessoa \n" +
                "2 para alterar o nome da pessoa \n" +
                "3 para inserir um email \n" +
                "4 para excluir a pessoa \n" +
                "5 para consultar tudo \n" +
                "6 para consultar pelo ID da pessoa \n");

            Console.Write("Escolha: ");
            int opcao = int.Parse(Console.ReadLine());

            Contexto contexto = new Contexto();

            switch (opcao)
            {
                case 1:
                    try
                    {
                        Pessoa pessoa = new Pessoa();
                        Console.Write("Insira o nome da Pessoa: ");
                        pessoa.nome = Console.ReadLine();

                        Console.Write("Email: ");
                        string emailTemp = Console.ReadLine();
                        pessoa.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                email = emailTemp
                            }
                        };
                        //Email e = new Email();
                        //e.email = emailTemp;
                        //pessoa.Emails.Add(e);
                        contexto.Pessoas.Add(pessoa);
                        contexto.SaveChanges();
                        Console.WriteLine("Pessoa inserida com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        Console.Write("Informe o Id da pessoa: ");
                        int id = int.Parse(Console.ReadLine());

                        Pessoa pessoaAlterada = contexto.Pessoas.Find(id);

                        Console.Write("Informe o nome correto: ");
                        pessoaAlterada.nome = Console.ReadLine();

                        contexto.Pessoas.Update(pessoaAlterada);
                        contexto.SaveChanges();

                        Console.WriteLine("Alteração efetuada com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 3:
                    try
                    {
                        Console.Write("Informe o Id da pessoa: ");
                        int id = int.Parse(Console.ReadLine());

                        Pessoa pessoa = contexto.Pessoas.Find(id);

                        Console.Write("Informe o novo email: ");
                        string emailNovo = Console.ReadLine();

                        pessoa.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                email = emailNovo
                            }
                        };

                        contexto.Pessoas.Update(pessoa);
                        contexto.SaveChanges();
                        Console.WriteLine("Email adicionado com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 4:
                    try
                    {
                        Console.Write("Informe o Id da pessoa: ");
                        int id = int.Parse(Console.ReadLine());
                        Pessoa pessoa = contexto.Pessoas.Find(id);

                        Console.WriteLine("Deseja realmente excluir " + pessoa.nome + " e seus emails?");
                        foreach (Email e in pessoa.Emails)
                        {
                            Console.WriteLine("\t" + e.email);
                        }
                        Console.Write("1 para SIM e 2 para NÃO: ");
                        if (int.Parse(Console.ReadLine()) == 1)
                        {
                            contexto.Pessoas.Remove(pessoa);
                            contexto.SaveChanges();
                            Console.WriteLine(pessoa.nome + " removido com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Operação cancelada!");
                        }



                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 5:
                    try
                    {
                        //LINQ
                        List<Pessoa> lista =
                            (from Pessoa pessoa in contexto.Pessoas select pessoa)
                            .Include(pes => pes.Emails)//para cada pessoa mostrar seus emails
                            .ToList<Pessoa>();

                        foreach (Pessoa p in lista)
                        {
                            Console.WriteLine(p.nome);

                            foreach (Email e in p.Emails)
                            {
                                Console.WriteLine("\t" + e.email);
                            }
                            Console.WriteLine();
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 6:
                    try
                    {
                        Console.Write("Informe o Id da pessoa: ");
                        int id = int.Parse(Console.ReadLine());
                        Pessoa pessoa = contexto.Pessoas.Include(p => p.Emails)
                            .FirstOrDefault(pe => pe.id ==id);//pegar a primeira pessoa 
                        Console.WriteLine(pessoa.nome);

                        foreach (Email e in pessoa.Emails)
                        {
                            Console.WriteLine("\t" + e.email);
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
