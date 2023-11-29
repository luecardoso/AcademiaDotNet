using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    internal class Livro
    {
        /*
      * Crie uma classe Livro que represente os dados básicos de um livro, além destes, 
      * criar um atributo do tipo boolean chamado emprestado.
       - Crie métodos emprestar e devolver que altera o atributo emprestado
       - Crie um método construtor que receba todos os valores por parâmetros, exceto o
             atributo emprestado que obrigatoriamente deve ser inicializado como false
       - Faça a leitura pelo teclado dos atributos para instanciar dois livros */

        public string titulo;
        public Autor autor;
        public string anoPub;
        public string editora;
        public bool emprestado;

        public Livro(string titulo, Autor? autor, string anoPub, string editora)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anoPub = anoPub;
            this.editora = editora;
            this.emprestado = false;
        }

        public void Emprestar()
        {
            if (emprestado)
            {
                Console.WriteLine("Ele já está emprestado!");
            }
            else
            {
                emprestado = true;
                Console.WriteLine("Livro emprestado com sucesso!");
            }
        }

        public void Devolver()
        {
            if (!emprestado)
            {
                Console.WriteLine("Livro não estava emprestado!");
            }
            else
            {
                emprestado = false;
                Console.WriteLine("Livro devolvido com sucesso!");
            }
        }
        internal void ExibirInformacoes()
        {
            Console.WriteLine("Titulo: " + this.titulo);
            Console.WriteLine(this.autor.ToString());
            //Console.WriteLine("Autor: "+this.autor.nome);
            //Console.WriteLine("Nacionalidade do autor: " + this.autor.nacionalidade);
            Console.WriteLine("Ano publicação: " + this.anoPub);
            Console.WriteLine("Editora: " + this.editora);
            //string mensagem = emprestado ? "O livro está emprestado" : "O livro não está emprestado";
            Console.WriteLine(emprestado ? "O livro está emprestado" : "O livro não está emprestado");

        }
    }
}
