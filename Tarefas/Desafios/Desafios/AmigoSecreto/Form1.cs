namespace AmigoSecreto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Exibir();
        }

        List<Pessoa> lista = new List<Pessoa>();
        int pessoas;
        private void Inserir()
        {
            if (textBox_Nome.Text.Trim().Equals(""))
            {
                MessageBox.Show("Adicione um participante", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string[] nomes = textBox_Nome.Text.Split(" ");

                if (nomes.Length >= 2)
                {
                    string nome = textBox_Nome.Text.ToUpper();
                    string email;
                    bool status = false;
                    Pessoa pessoa = new Pessoa();
                    do
                    {
                        email = textBox_Email.Text.ToLower();
                        status = Utilidades.EmailIsValid(email);
                    } while (!status);

                    if (textBox_Email.Text.Trim().Equals(""))
                    {
                        pessoa = new Pessoa(nome);
                    }
                    else
                    {
                        pessoa = new Pessoa(nome, email);
                    }

                    if (!lista.Contains(pessoa))
                    {
                        label_Mensagem.Visible = false;
                        lista.Add(pessoa);
                        lista.Sort((a, b) => a.Nome.CompareTo(b.Nome));

                        string[] itens = { pessoa.Nome, pessoa.Email };
                        listView_Participantes.Items.Add(new ListViewItem(itens));
                        Persistencia.gravarSimples(pessoa, "amigos.csv");
                        //Persistencia.gravarListaArquivo(lista, "amigos.csv");
                        textBox_Nome.Text = string.Empty;
                        textBox_Email.Text = string.Empty;
                        pessoas++;
                        label_Participantes.Text = pessoas.ToString();
                        textBox_Nome.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Pessoa já cadastrada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    label_Mensagem.Visible = true;
                    label_Mensagem.Text = "Insira nome e sobrenome";
                    textBox_Nome.Text = String.Empty;
                    textBox_Nome.Focus();
                }
            }
        }

        private void Exibir()
        {
            textBox_Nome.Focus();
            pessoas = Persistencia.QuantidadeParticipantes("amigos.csv");
            label_Participantes.Text = pessoas.ToString();
            Persistencia.lerArquivo("amigos.csv", listView_Participantes);
            if (lista.Count > 0)
            {
                Persistencia.popularArquivoLista("amigos.csv", lista);

            }
            MessageBox.Show("lista = " + lista.Count);
        }

        private void GerarAmigoSecreto()
        {
            if (pessoas >= 2)
            {
                List<Pessoa> listaTmp = new List<Pessoa>();
                listaTmp.AddRange(lista);

                bool deuCerto;
                do
                {
                    deuCerto = true;
                    listaTmp = listaTmp.OrderBy(x => Random.Shared.Next()).ToList();

                    for (int i = 0; i < lista.Count; i++)
                    {
                        if (lista[i] == listaTmp[i])
                        {
                            deuCerto = false;
                            listaTmp.Clear();
                            listaTmp.AddRange(lista);
                            break;
                        }
                    }
                } while (!deuCerto);

                Persistencia.gerarArquivoAmigoSecreto(lista, listaTmp);
                MessageBox.Show("Amigo secreto sorteado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Adicione mais pessoas para gerar o sorteio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_Inserir_Click(object sender, EventArgs e)
        {
            Inserir();
        }

        private void button_GerarAmigo_Click(object sender, EventArgs e)
        {
            GerarAmigoSecreto();
        }

        private void buttonEnviarEmail_Click(object sender, EventArgs e)
        {

        }

        private void button_Editar_Click(object sender, EventArgs e)
        {
            if (listView_Participantes.Items.Count > 0)
            {
                if (listView_Participantes.SelectedItems.Count != 1)
                {
                    MessageBox.Show("Selecione um participante para editar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ListViewItem item = listView_Participantes.Items[listView_Participantes.SelectedIndices[0]];
                    string nome = item.SubItems[0].Text;
                    string email = item.SubItems[1].Text;

                    textBox_Nome.Text = nome;
                    textBox_Email.Text = email;
                }

            }
            else
            {
                MessageBox.Show("Não há participantes ainda!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Remover_Click(object sender, EventArgs e)
        {
            //if (listView_Participantes.Items.Count > 0)
            //{
            //    if (listView_Participantes.SelectedItems.Count != 1)
            //    {
            //        MessageBox.Show("Selecione um participante para remover!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else
            //    {
            //        //ListViewItem item = listView_Participantes.Items[listView_Participantes.SelectedIndices[0]];
            //        ListViewItem item = listView_Participantes.SelectedItems[0];
            //        string nome = item.SubItems[0].Text;
            //        string email = item.SubItems[1].Text;

            //        ////ListViewItem item = listView_Participantes.Items[0];
            //        //ListViewItem item = listView_Participantes.SelectedItems[0];
            //        ////string nome = listView_Participantes.SelectedItems[0].Text;
            //        //string nome = item.SubItems[0].Text;
            //        //string email = item.SubItems[1].Text;
            //        //if (item.Index != -1)
            //        //{
            //        //    //lista.RemoveAt(item.Index);

            //        //}
            //        Persistencia.remover("amigos.csv", email, lista);
            //        listView_Participantes.Items.Remove(listView_Participantes.SelectedItems[0]);
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Não há participantes ainda!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void textBox_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                Inserir();
            }
        }

    }
}