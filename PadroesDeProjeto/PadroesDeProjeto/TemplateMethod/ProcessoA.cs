using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class ProcessoA : Processo
    {
        public override void Finalizar()
        {
            Console.WriteLine("Finalizando o ProcessoA");
        }

        public override void Iniciar()
        {
            Console.WriteLine("Iniciando o ProcessoA");
        }
    }
}
