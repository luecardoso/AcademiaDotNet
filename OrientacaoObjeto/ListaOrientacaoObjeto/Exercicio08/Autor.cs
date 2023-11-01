using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    internal class Autor
    {
        public string nome;
        public string nacionalidade;

        public Autor(string nome, string nacionalidade)
        {
            this.nome = nome;
            this.nacionalidade = nacionalidade;
        }

        public string ToString()
        {
            return "Autor: " + this.nome + " Nacionalidade: " + this.nacionalidade;
        }
    }
}
