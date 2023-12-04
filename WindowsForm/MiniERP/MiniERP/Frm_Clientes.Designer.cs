namespace MiniERP
{
    partial class Frm_Clientes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            textBox_Nome = new TextBox();
            maskedTextBox_Telefone = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            maskedTextBox_DataNascimento = new MaskedTextBox();
            panel_Geral = new Panel();
            panel2 = new Panel();
            button_Salvar = new Button();
            button_Editar = new Button();
            button4 = new Button();
            button_Voltar = new Button();
            panel1 = new Panel();
            dataGridView_Clientes = new DataGridView();
            label6 = new Label();
            button_Buscar = new Button();
            textBox_Buscar = new TextBox();
            panelCadastro = new Panel();
            button7 = new Button();
            comboBox_Sexo = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            panel_Geral.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).BeginInit();
            panelCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(35, 91);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome: ";
            // 
            // textBox_Nome
            // 
            textBox_Nome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Nome.Location = new Point(101, 86);
            textBox_Nome.Multiline = true;
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.Size = new Size(480, 31);
            textBox_Nome.TabIndex = 1;
            // 
            // maskedTextBox_Telefone
            // 
            maskedTextBox_Telefone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox_Telefone.Location = new Point(101, 139);
            maskedTextBox_Telefone.Mask = "(##) #####-####";
            maskedTextBox_Telefone.Name = "maskedTextBox_Telefone";
            maskedTextBox_Telefone.Size = new Size(135, 29);
            maskedTextBox_Telefone.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(28, 143);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 3;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(247, 143);
            label3.Name = "label3";
            label3.Size = new Size(150, 21);
            label3.TabIndex = 4;
            label3.Text = "Data de Nascimento";
            // 
            // maskedTextBox_DataNascimento
            // 
            maskedTextBox_DataNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox_DataNascimento.Location = new Point(403, 139);
            maskedTextBox_DataNascimento.Mask = "00/00/0000";
            maskedTextBox_DataNascimento.Name = "maskedTextBox_DataNascimento";
            maskedTextBox_DataNascimento.Size = new Size(100, 29);
            maskedTextBox_DataNascimento.TabIndex = 5;
            maskedTextBox_DataNascimento.ValidatingType = typeof(DateTime);
            // 
            // panel_Geral
            // 
            panel_Geral.BackColor = Color.GhostWhite;
            panel_Geral.Controls.Add(panel2);
            panel_Geral.Controls.Add(panel1);
            panel_Geral.Controls.Add(panelCadastro);
            panel_Geral.Location = new Point(-3, -2);
            panel_Geral.Name = "panel_Geral";
            panel_Geral.Size = new Size(749, 781);
            panel_Geral.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(button_Salvar);
            panel2.Controls.Add(button_Editar);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button_Voltar);
            panel2.Location = new Point(15, 679);
            panel2.Name = "panel2";
            panel2.Size = new Size(722, 91);
            panel2.TabIndex = 7;
            // 
            // button_Salvar
            // 
            button_Salvar.Location = new Point(611, 42);
            button_Salvar.Name = "button_Salvar";
            button_Salvar.Size = new Size(75, 23);
            button_Salvar.TabIndex = 4;
            button_Salvar.Text = "Salvar";
            button_Salvar.UseVisualStyleBackColor = true;
            button_Salvar.Click += button_Salvar_Click;
            // 
            // button_Editar
            // 
            button_Editar.Location = new Point(417, 42);
            button_Editar.Name = "button_Editar";
            button_Editar.Size = new Size(75, 23);
            button_Editar.TabIndex = 3;
            button_Editar.Text = "Editar";
            button_Editar.UseVisualStyleBackColor = true;
            button_Editar.Click += button_Editar_Click;
            // 
            // button4
            // 
            button4.Location = new Point(223, 42);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 2;
            button4.Text = "Remover";
            button4.UseVisualStyleBackColor = true;
            // 
            // button_Voltar
            // 
            button_Voltar.Location = new Point(29, 42);
            button_Voltar.Name = "button_Voltar";
            button_Voltar.Size = new Size(75, 23);
            button_Voltar.TabIndex = 0;
            button_Voltar.Text = "Voltar";
            button_Voltar.UseVisualStyleBackColor = true;
            button_Voltar.Click += button_Voltar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(dataGridView_Clientes);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button_Buscar);
            panel1.Controls.Add(textBox_Buscar);
            panel1.Location = new Point(15, 243);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 397);
            panel1.TabIndex = 7;
            // 
            // dataGridView_Clientes
            // 
            dataGridView_Clientes.AllowUserToAddRows = false;
            dataGridView_Clientes.AllowUserToDeleteRows = false;
            dataGridView_Clientes.BackgroundColor = Color.GhostWhite;
            dataGridView_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView_Clientes.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_Clientes.Location = new Point(36, 72);
            dataGridView_Clientes.Name = "dataGridView_Clientes";
            dataGridView_Clientes.ReadOnly = true;
            dataGridView_Clientes.Size = new Size(650, 312);
            dataGridView_Clientes.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(36, 29);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 9;
            label6.Text = "Nome: ";
            // 
            // button_Buscar
            // 
            button_Buscar.Location = new Point(600, 25);
            button_Buscar.Name = "button_Buscar";
            button_Buscar.Size = new Size(87, 32);
            button_Buscar.TabIndex = 1;
            button_Buscar.Text = "Buscar";
            button_Buscar.UseVisualStyleBackColor = true;
            button_Buscar.Click += button_Buscar_Click;
            // 
            // textBox_Buscar
            // 
            textBox_Buscar.Location = new Point(102, 25);
            textBox_Buscar.Multiline = true;
            textBox_Buscar.Name = "textBox_Buscar";
            textBox_Buscar.Size = new Size(480, 32);
            textBox_Buscar.TabIndex = 0;
            // 
            // panelCadastro
            // 
            panelCadastro.BackColor = Color.CornflowerBlue;
            panelCadastro.BorderStyle = BorderStyle.FixedSingle;
            panelCadastro.Controls.Add(button7);
            panelCadastro.Controls.Add(comboBox_Sexo);
            panelCadastro.Controls.Add(label5);
            panelCadastro.Controls.Add(label4);
            panelCadastro.Controls.Add(maskedTextBox_DataNascimento);
            panelCadastro.Controls.Add(label1);
            panelCadastro.Controls.Add(textBox_Nome);
            panelCadastro.Controls.Add(label3);
            panelCadastro.Controls.Add(label2);
            panelCadastro.Controls.Add(maskedTextBox_Telefone);
            panelCadastro.Location = new Point(15, 0);
            panelCadastro.Name = "panelCadastro";
            panelCadastro.Size = new Size(722, 222);
            panelCadastro.TabIndex = 6;
            // 
            // button7
            // 
            button7.Location = new Point(599, 86);
            button7.Name = "button7";
            button7.Size = new Size(87, 32);
            button7.TabIndex = 11;
            button7.Text = "Adicionar";
            button7.UseVisualStyleBackColor = true;
            // 
            // comboBox_Sexo
            // 
            comboBox_Sexo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_Sexo.FormattingEnabled = true;
            comboBox_Sexo.Items.AddRange(new object[] { "Feminino", "Masculino", "Outros" });
            comboBox_Sexo.Location = new Point(565, 139);
            comboBox_Sexo.Name = "comboBox_Sexo";
            comboBox_Sexo.Size = new Size(121, 29);
            comboBox_Sexo.TabIndex = 8;
            comboBox_Sexo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(516, 143);
            label5.Name = "label5";
            label5.Size = new Size(43, 21);
            label5.TabIndex = 7;
            label5.Text = "Sexo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(223, 27);
            label4.Name = "label4";
            label4.Size = new Size(261, 37);
            label4.TabIndex = 6;
            label4.Text = "Cadastro de Clientes";
            // 
            // Frm_Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 780);
            ControlBox = false;
            Controls.Add(panel_Geral);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Frm_Clientes";
            Text = "Gerencia";
            panel_Geral.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).EndInit();
            panelCadastro.ResumeLayout(false);
            panelCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox_Nome;
        private MaskedTextBox maskedTextBox_Telefone;
        private Label label2;
        private Label label3;
        private MaskedTextBox maskedTextBox_DataNascimento;
        private Panel panel_Geral;
        private Panel panelCadastro;
        private Label label4;
        private Label label5;
        private ComboBox comboBox_Sexo;
        private Panel panel1;
        private TextBox textBox_Buscar;
        private Panel panel2;
        private Label label6;
        private Button button_Buscar;
        private Button button_Salvar;
        private Button button_Editar;
        private Button button4;
        private Button button_Voltar;
        private Button button7;
        private DataGridView dataGridView_Clientes;
    }
}