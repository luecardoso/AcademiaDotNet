using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPadel
{
    internal class Atleta : Pessoa
    {
        public string PosicaoQuadra { set; get; }
        public string Categoria { set; get; }

        public Atleta(string nome, string email, DateOnly data, string posicao, string categoria) : base(nome, email, data)
        {
            this.PosicaoQuadra = posicao;
            this.Categoria = categoria;
        }
    }
}
