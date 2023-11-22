﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facede
{
    internal class Facade
    {
        private SistemaBancoDeDados _sistemaBD;
        private SistemaServidorWeb _servidorWeb;
        private SistemaAutenticacao _sistemaAutenticacao;

        public Facade(string user, string password)
        {
            _sistemaBD = new SistemaBancoDeDados();
            _servidorWeb = new SistemaServidorWeb();
            _sistemaAutenticacao = new SistemaAutenticacao(user, password);
        }

        public void InicializarSistema()
        {
            Console.WriteLine("Iniciando todos os componentes: ");
            _sistemaBD.IniciarBancoDeDados();
            _servidorWeb.IniciarServidor();
            _sistemaAutenticacao.IniciarSistema();
        }
    }
}
