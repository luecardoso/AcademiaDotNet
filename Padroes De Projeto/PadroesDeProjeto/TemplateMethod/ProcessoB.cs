using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class ProcessoB : Processo
    {
        public override void Finalizar()
        {
            Console.WriteLine("Finalizando o ProcessoB");
        }

        public override void Iniciar()
        {
            Console.WriteLine("Inciando o ProcessoB");
        }
    }
}
