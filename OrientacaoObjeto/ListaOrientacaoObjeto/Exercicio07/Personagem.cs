using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Personagem
    {
        /*
         * •Crie uma classe chamada Personagem. Defina seus atributos, mas dentre eles 
         * deve conter: Nome, posição e itens coletados, no mínimo.
         * 
         * •Crie construtor e faça a leitura dos atributos pelo teclado.
         * 
         * •Crie um método chamado “atacar” que recebe por parâmetro uma variável do 
         * tipo double que indica o dano do ataque numa escala de 0 a 10. O método deve
         * apresentar uma mensagem na tela com o dano.
         * 
         * •Crie um método chamado “movimentar” que deve receber por parâmetro uma 
         * variável do tipo int que indica a direção que o personagem vai se mover 
         * (1 – frente, 2 – trás, 3 – direita e 4 – esquerda). O método deve apresentar
         * uma mensagem na tela mostrando a direção que o personagem vai se mover.
         * 
         */
        public String nome;
        public int posicao;
        public int itensColetados;
        public String classe;


        public void Atacar(double dano)
        {

        }

        public void Movimentar(int posicao)
        {

        }
    }
}
