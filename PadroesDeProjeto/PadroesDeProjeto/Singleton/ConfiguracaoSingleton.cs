using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class ConfiguracaoSingleton
    {
        //quero garantir que esta configuração seja única, não abrindo ambiguidade
        private static ConfiguracaoSingleton instancia;
        private string _url;
        private int _versao;
        private int _porta;

        public string Url { get { return _url; } }
        public int Versao { get { return _versao; } }
        public int Porta { get { return _porta; } }

        private ConfiguracaoSingleton()
        {
            _url = "localhost";
            _versao = 1;
            _porta = 8080;
        }

        public static ConfiguracaoSingleton getInstance()
        {
            if (instancia == null)
            {
                instancia = new ConfiguracaoSingleton();
            }
            return instancia;
        }

        public void ExibirDados()
        {
            Console.WriteLine("URL: " + _url);
            Console.WriteLine("Versão: " + _versao);
        }
    }
}
