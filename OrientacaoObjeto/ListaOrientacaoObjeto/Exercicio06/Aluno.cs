using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    internal class Aluno
    {
        /*
         * Escreva uma classe Aluno contendo todos os atributos de um aluno. 
         * Faça métodos para apresentar os dados.
         * Faça a leitura pelo teclado dos atributos e crie um construtor para 
         * fazer o instanciamento.
         */
        public String nome;
        public String rg;
        public int idade;
        public string dataNascimento;
        public string ra;
        public bool situacao;

        public Aluno(string nome, string rg, int idade, string dataNascimento, string ra, bool situacao)
        {
            this.nome = nome;
            this.rg = rg;
            this.idade = idade;
            this.dataNascimento = dataNascimento;
            this.ra = ra;
            this.situacao = situacao;
        }

        public String getNome() { return nome; }
        public String getRg() { return rg; }
        public int getIdade() { return idade; }
        public string getDataNascimento() { return dataNascimento; }
        public string getRa() { return ra; }
        public bool getSituacao() { return situacao; }
        public void setNome(String nome) { this.nome = nome; }
        public void setRg(String rg) { this.rg = rg; }
        public void setIdade(int idade) { this.idade = idade; }
        public void setR(string ra) { this.ra = ra; }
        public void setSituacao(bool situacao) { this.situacao = situacao; }
    }
}
