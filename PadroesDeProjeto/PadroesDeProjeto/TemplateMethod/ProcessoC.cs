using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class ProcessoC : Processo
    {
        public override void Finalizar()
        {
            Console.WriteLine("Finalizando o ProcessoC");
        }

        public override void Iniciar()
        {
            Console.WriteLine("Inciando o ProcessoC");
        }

        public override void Executar()
        {
            Console.WriteLine("Estou no método reimplementado do ProcessoC");
            Iniciar();
            Finalizar();
        }
    }
}
