using System.Data;
using System.Windows.Forms;

namespace WF_AdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();

            //assim pode inserir sql injection
            //dt = bd.executaConsulta("select * from pessoas where nome ='"+textBox1.Text+"';");
            dt = bd.executaConsulta("select * from pessoas");

            dataGridView1.DataSource = dt;
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = textBox_Nome.Text;
            pessoa.idade = int.Parse(textBox_Idade.Text);


            if (pessoa.gravar())
            {
                MessageBox.Show("Cadastrado Com Sucesso!");
                button1_Click(null, null);
            }
            else
            {
                MessageBox.Show("Erro ao Cadastrar");
            }
        }
    }
}

