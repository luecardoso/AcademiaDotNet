using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class Animal
    {
        public string Nome { get; set; }
        public string Especie { get; set; }

        public int Idade { get; set; }
        public Animal() { }

        public Animal(string nome, string especie, int idade)
        {
            Nome = nome;
            Especie = especie;
            Idade = idade;
        }

        public void EmitirSom(string som)
        {
            Console.WriteLine("O animal "+this.Nome+" está emitindo "+som);
        }
    }
}
