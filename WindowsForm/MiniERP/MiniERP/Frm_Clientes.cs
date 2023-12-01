using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniERP
{
    public partial class Frm_Clientes : Form
    {
        public Frm_Clientes()
        {
            InitializeComponent();
            listar();
            comboBox_Sexo.SelectedItem = comboBox_Sexo.Items[0];
        }
        List<Cliente> lista = new List<Cliente>();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Principal principal = new Frm_Principal();
            principal.Show();
            this.Close();
        }

        private void button_Salvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void salvar()
        {
            Cliente cliente = new Cliente();
            cliente.Nome = textBox_Nome.Text;
            cliente.Telefone = maskedTextBox_Telefone.Text;
            cliente.DataNascimento = maskedTextBox_DataNascimento.Text;
            cliente.Sexo = comboBox_Sexo.Text;

            if (cliente.gravar())
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
            Cliente cliente = new Cliente();

            if (String.IsNullOrEmpty(textBox_Buscar.Text))
            {
                dt = cliente.buscarPessoas();
            }
            else
            {
                cliente.Nome = textBox_Buscar.Text;
                dt = cliente.buscarClientesByNome();
            }
            dataGridView_Clientes.DataSource = dt;
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void atualizar()
        {
            DataTable dt = new DataTable();
            textBox_Nome.Text = dataGridView_Clientes.Rows[0].Cells[0].Value.ToString();

            //dataGridView_Clientes.SelectedRows[0].ToString();

            
        }

        private void button_Editar_Click(object sender, EventArgs e)
        {
            atualizar();
        }
    }
}
