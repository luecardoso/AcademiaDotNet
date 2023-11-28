namespace MiniERP
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void button_Produto_Click(object sender, EventArgs e)
        {
            Frm_Produtos produtos = new Frm_Produtos();
            produtos.Show();
            this.Hide();
        }

        private void button_Cliente_Click(object sender, EventArgs e)
        {
            Frm_Clientes clientes = new Frm_Clientes();
            clientes.Show();
            this.Hide();
        }

        private void button_Fornecedor_Click(object sender, EventArgs e)
        {
            Frm_Fornecedores fornecedores = new Frm_Fornecedores();
            fornecedores.Show();
            this.Hide();
        }
    }
}
