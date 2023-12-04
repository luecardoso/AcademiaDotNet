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
            produto.Quantidade = (int)numericUpDown_Quantidade.Value;
            produto.Descricao = textBox_Descricao.Text;
            produto.Preco = float.Parse(textBox_Preco.Text);
            produto.IdFornecedor = comboBox_Fornecedor.SelectedIndex;



            

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
