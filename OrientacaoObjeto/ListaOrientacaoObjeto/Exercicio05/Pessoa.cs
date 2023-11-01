using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class Pessoa
    {
        /*
         * Crie uma classe chamada Pessoa com seus atributos conforme sua 
         * preferência (nome, cpf, data de nascimento, rg)
         */
        public String nome;
        public int idade;
        public String genero;
        public string cpf;
        public string rg;
        public string dataNascimento;

        public Pessoa(string nome, int idade, string genero, string cpf,
            string rg, string dataNascimento)
        {
            this.nome = nome;
            this.idade = idade;
            this.genero = genero;
            this.cpf = cpf;
            this.rg = rg;
            this.dataNascimento = dataNascimento;
        }
    }
}
