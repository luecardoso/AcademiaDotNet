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
    public partial class Frm_Produtos : Form
    {
        public Frm_Produtos()
        {
            InitializeComponent();
            listar();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_Salvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void salvar()
        {
            Produto produto = new Produto();

            produto.Nome = textBox_Nome.Text;
            produto.Quantidade = int.Parse(textBox_Quantidade.Text) ;
            produto.Descricao = textBox_Descricao.Text;
            produto.Preco = float.Parse(textBox_Preco.Text);
            produto.IdFornecedor = int.Parse(textBox_Fornecedor.Text);

            MessageBox.Show("combobox  " + comboBox_Fornecedor.SelectedIndex);
            MessageBox.Show("Fornecedor "+produto.IdFornecedor);
            if (produto.gravar())
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
            comboBox_Fornecedor.Items.Add("Lalalala");
            Fornecedor.buscarFornecedoresCb(comboBox_Fornecedor);
        }
    }
}
