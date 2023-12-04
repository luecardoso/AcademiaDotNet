using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP
{
    public partial class Frm_Fornecedores : Form
    {
        public Frm_Fornecedores()
        {
            InitializeComponent();
        }

        private void button_Salvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void salvar()
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.Nome = textBox_Fornecedor.Text;

            if (fornecedor.gravar())
            {
                MessageBox.Show("Cadastrado Com Sucesso!");
                listar();
            }
            else
            {
                MessageBox.Show("Erro ao Cadastrar");
            }
        }


        private void listar()
        {
            DataTable dt = new DataTable();
            Fornecedor fornecedor = new Fornecedor();

            if (String.IsNullOrEmpty(textBox_Buscar.Text))
            {
                dt = fornecedor.buscarFornecedores();
            }
            else
            {
                fornecedor.Nome = textBox_Buscar.Text;
                dt = fornecedor.buscarFornecedoresByNome();
            }
            dataGridView_Fornecedores.DataSource = dt;
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            listar();
        }
    }
}
