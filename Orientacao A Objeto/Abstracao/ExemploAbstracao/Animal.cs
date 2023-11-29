using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAnimais
{
    internal abstract class Animal
    {
        public string Nome { get; set; }
        public string Especie { get; set; }
        public int Idade { get; set; }

        public Animal(string nome) 
        {
            Nome = nome;
        }
        public abstract void EmitirSom();

        public  void Movimentar()
        {
            Console.WriteLine(this.Nome + " está andando...");
        }
    }
}
