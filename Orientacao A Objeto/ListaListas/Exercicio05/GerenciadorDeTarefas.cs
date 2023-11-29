using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class GerenciadorDeTarefas
    {
        public string Descricao {  get; set; }  
        public string DataVencimento { get; set; }
        public bool Status {  get; set; }

        public int Id {  get; set; }

        public GerenciadorDeTarefas() { }

        public GerenciadorDeTarefas(string descricao, string dataVencimento)
        {
            Descricao = descricao;
            DataVencimento = dataVencimento;
        }

        public static void Adicionar(List<GerenciadorDeTarefas> lista)
        {
            Console.Clear();
            Console.WriteLine("--------- TAREFA ---------");
            Console.Write("Data de Vencimento: ");
            string dataVencimento = Console.ReadLine().ToUpper();
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();

            GerenciadorDeTarefas tarefa = new GerenciadorDeTarefas(descricao,dataVencimento);
            tarefa.Id = lista.Count + 1;
            lista.Add(tarefa);
        }

        public static void Remover(List<GerenciadorDeTarefas> lista)
        {
            Console.Clear();
            if (lista.Count == 0)
            {
                Console.WriteLine("Lista vazia!!");
                return;
            }

            int posicao;
            Listar(lista);
            Console.Write("Informe o ID da tarefa que deseja remover: ");
            posicao = int.Parse(Console.ReadLine());
            if (posicao != null)
            {
                Console.WriteLine("Removendo...");
                posicao--;
                lista.RemoveAt(posicao);
            }
            else
            {
                Console.WriteLine("Tarefa não existe!");
            }
        }

        public static void VerificarTarefa(GerenciadorDeTarefas dataLimite)
        {
            DateOnly data = DateOnly.FromDateTime(DateTime.Now);
            //Console.WriteLine(data);
            string dataDigitada = dataLimite.DataVencimento;
            int comp = data.CompareTo(DateOnly.Parse(dataDigitada));
            if (comp == 0)
            {
                Console.WriteLine("Hoje é a data limite dessa terefa!");
            }
            else if (comp < 0)
            {
                Console.WriteLine("Falta alguns dias para o prazo limite dessa tarefa!");
            }
            else
            {
                Console.WriteLine("A data limite já passou!");
            }
            Console.WriteLine();

        }
        public static void Listar(List<GerenciadorDeTarefas> lista)
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("      Lista de Tarefas      ");
            foreach (GerenciadorDeTarefas tarefa in lista)
            {
                Console.WriteLine(tarefa);
                VerificarTarefa(tarefa);
            }
        }

        public override string? ToString()
        {
            return "\nID: "+Id+
                "\nData de Vencimento: "+DataVencimento+
                "\nDescrição: "+Descricao;
        }
    }
}
