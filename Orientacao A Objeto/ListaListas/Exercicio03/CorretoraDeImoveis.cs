using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class CorretoraDeImoveis
    {

        public string Endereco { get; set; }
        public double Preco { get; set; }
        public string Tipo { get; set; }

        public int Id { get; set; }
        public bool Disponibilidade { get; set; }
        public CorretoraDeImoveis(){}

        public CorretoraDeImoveis(string endereco, double preco, string tipo)
        {
            Endereco = endereco;
            Preco = preco;
            Tipo = tipo;
        }
        public override string? ToString()
        {
            string disp;
            if (this.Disponibilidade)
            {
                disp = "Disponível";
            }
            else
            {
                disp = "Indisponível";
            }

            return "ID: "+this.Id +
                "\nTipo: "+this.Tipo+
                "\nEndereco: "+this.Endereco +
                "\nPreço: "+this.Preco +
                "\nDisponivbilidade: "+disp;

        }

    }
}
