namespace Componentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Pessoa> lista = new List<Pessoa>();

        private void ColocarListaText(List<Pessoa> lista)
        {
            textBox_relacaoNomes.Text = "";

            foreach (var pessoa in lista)
            {
                textBox_relacaoNomes.AppendText(pessoa + Environment.NewLine);
                string[] itens = { pessoa.Nome, pessoa.Email };
                listView_relacaoNomes.Items.Add(new ListViewItem(itens));
            }
        }
        private void textBox_frase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                Cadastrar();
            }
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void limpar()
        {
            lista.Clear();
            textBox_relacaoNomes.Clear();
            listView_relacaoNomes.Items.Clear();
        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema elaborado pelo prof Alexandre Zamberlan - Academia .NET 2023", "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }
        private void Cadastrar()
        {
            //if (textBox_frase.Text.Length != 0 && textBox_frase.Text.Trim() != string.Empty)
            //{
            //}
            string[] vetor = textBox_frase.Text.Split(" ");
            if (vetor.Length >= 2)
            {
                //MessageBox.Show("Frase: " + textBox_frase.Text.ToUpper());


                string nome = textBox_frase.Text.ToUpper();
                Pessoa p = new Pessoa(nome);

                if (!lista.Contains(p))
                {
                    lista.Add(p);
                    lista.Sort((a, b) => a.Nome.CompareTo(b.Nome));

                    ColocarListaText(lista);
                    textBox_frase.Text = string.Empty;

                }

            }
        }

    }
}