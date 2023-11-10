using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class AgendaTelefonica
    {
        public string Nome {  get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public AgendaTelefonica() { }

        public AgendaTelefonica(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }

        public static void Adicionar(List<AgendaTelefonica> lista)
        {
            Console.Write("Informe um email válido: ");
            string email = Console.ReadLine();
            string nome="", telefone="";

            if (AgendaTelefonica.estaContido(email, lista))
            {
                Console.WriteLine("Email já utilizado no sistema!!");
            }
            else
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine().ToUpper();
                Console.Write("telefone: ");
                telefone = Console.ReadLine();
            }

            AgendaTelefonica contato = new AgendaTelefonica(nome,email,telefone);
            contato.Id = lista.Count + 1;
            lista.Add(contato);
        }

        public static void Remover(List<AgendaTelefonica> lista)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("Lista vazia!!");
                return;
            }

            int posicao;
            ListarContatos(lista);
            Console.Write("Informe o ID do contato que deseja remover: ");
            posicao = int.Parse(Console.ReadLine());
            if (posicao != null)
            {
                Console.WriteLine("Removendo contato...");
                posicao--;
                lista.RemoveAt(posicao);
            }
            else
            {
                Console.WriteLine("Contato não encontrado!");
            }
            
        }

        public static void ListarContatos(List<AgendaTelefonica> lista)
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Lista de contatos");
            foreach (AgendaTelefonica contato in lista)
            {
                Console.WriteLine(contato);
            }
        }
        public static void Buscar(List<AgendaTelefonica> lista)
        {
            Console.WriteLine("Digite o email do contato: ");
            string pesquisa = Console.ReadLine();

            foreach (AgendaTelefonica contato in lista)
            {
                if (pesquisa == contato.Email)
                {
                    Console.WriteLine(contato);
                }
            }
        }

        public static int pesquisaEmail(string pesquisa, List<AgendaTelefonica> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (pesquisa == lista[i].Email)
                {
                    return i;
                }
            }
            return -1;
        }

        public static bool estaContido(string email, List<AgendaTelefonica> lista)
        {
            foreach (var atleta in lista)
            {
                if (email == atleta.Email)
                {
                    return true;
                }
            }
            return false;
        }

        public override string? ToString()
        {
            return "\nID: "+this.Id+"\nNome: "+this.Nome +"\nTelefone: "+this.Telefone+"\nEmail: "+this.Email;
        }


    }
}
