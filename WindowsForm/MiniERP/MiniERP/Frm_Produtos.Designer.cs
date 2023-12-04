namespace MiniERP
{
    partial class Frm_Produtos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox_Nome = new TextBox();
            label2 = new Label();
            numericUpDown_Quantidade = new NumericUpDown();
            textBox_Descricao = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox_Preco = new TextBox();
            comboBox_Fornecedor = new ComboBox();
            label5 = new Label();
            dataGridView_Produtos = new DataGridView();
            button_Salvar = new Button();
            textBox_Buscar = new TextBox();
            button_Buscar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Quantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Produtos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 53);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // textBox_Nome
            // 
            textBox_Nome.Location = new Point(133, 50);
            textBox_Nome.Multiline = true;
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.Size = new Size(408, 30);
            textBox_Nome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 96);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Quantidade";
            // 
            // numericUpDown_Quantidade
            // 
            numericUpDown_Quantidade.Location = new Point(133, 96);
            numericUpDown_Quantidade.Name = "numericUpDown_Quantidade";
            numericUpDown_Quantidade.Size = new Size(120, 23);
            numericUpDown_Quantidade.TabIndex = 4;
            numericUpDown_Quantidade.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // textBox_Descricao
            // 
            textBox_Descricao.Location = new Point(133, 161);
            textBox_Descricao.Multiline = true;
            textBox_Descricao.Name = "textBox_Descricao";
            textBox_Descricao.Size = new Size(640, 107);
            textBox_Descricao.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 99);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "Preço: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(474, 98);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 7;
            label4.Text = "Fornecedor";
            // 
            // textBox_Preco
            // 
            textBox_Preco.Location = new Point(345, 93);
            textBox_Preco.Name = "textBox_Preco";
            textBox_Preco.Size = new Size(100, 23);
            textBox_Preco.TabIndex = 8;
            // 
            // comboBox_Fornecedor
            // 
            comboBox_Fornecedor.FormattingEnabled = true;
            comboBox_Fornecedor.Location = new Point(575, 99);
            comboBox_Fornecedor.Name = "comboBox_Fornecedor";
            comboBox_Fornecedor.Size = new Size(198, 23);
            comboBox_Fornecedor.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 164);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 10;
            label5.Text = "Descrição:";
            // 
            // dataGridView_Produtos
            // 
            dataGridView_Produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Produtos.Location = new Point(51, 350);
            dataGridView_Produtos.Name = "dataGridView_Produtos";
            dataGridView_Produtos.Size = new Size(722, 242);
            dataGridView_Produtos.TabIndex = 11;
            // 
            // button_Salvar
            // 
            button_Salvar.Location = new Point(661, 630);
            button_Salvar.Name = "button_Salvar";
            button_Salvar.Size = new Size(112, 23);
            button_Salvar.TabIndex = 12;
            button_Salvar.Text = "Salvar";
            button_Salvar.UseVisualStyleBackColor = true;
            button_Salvar.Click += button_Salvar_Click;
            // 
            // textBox_Buscar
            // 
            textBox_Buscar.Location = new Point(51, 295);
            textBox_Buscar.Multiline = true;
            textBox_Buscar.Name = "textBox_Buscar";
            textBox_Buscar.Size = new Size(604, 33);
            textBox_Buscar.TabIndex = 13;
            // 
            // button_Buscar
            // 
            button_Buscar.Location = new Point(661, 295);
            button_Buscar.Name = "button_Buscar";
            button_Buscar.Size = new Size(112, 33);
            button_Buscar.TabIndex = 14;
            button_Buscar.Text = "Buscar";
            button_Buscar.UseVisualStyleBackColor = true;
            // 
            // Frm_Produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 665);
            Controls.Add(button_Buscar);
            Controls.Add(textBox_Buscar);
            Controls.Add(button_Salvar);
            Controls.Add(dataGridView_Produtos);
            Controls.Add(label5);
            Controls.Add(comboBox_Fornecedor);
            Controls.Add(textBox_Preco);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox_Descricao);
            Controls.Add(numericUpDown_Quantidade);
            Controls.Add(label2);
            Controls.Add(textBox_Nome);
            Controls.Add(label1);
            Name = "Frm_Produtos";
            Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Quantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Produtos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_Nome;
        private Label label2;
        private NumericUpDown numericUpDown_Quantidade;
        private TextBox textBox_Descricao;
        private Label label3;
        private Label label4;
        private TextBox textBox_Preco;
        private ComboBox comboBox_Fornecedor;
        private Label label5;
        private DataGridView dataGridView_Produtos;
        private Button button_Salvar;
        private TextBox textBox_Buscar;
        private Button button_Buscar;
    }
}