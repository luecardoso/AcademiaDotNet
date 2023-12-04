namespace MiniERP
{
    partial class Frm_Fornecedores
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
            panel1 = new Panel();
            button_Salvar = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox_Fornecedor = new TextBox();
            dataGridView_Fornecedores = new DataGridView();
            button2 = new Button();
            textBox_Buscar = new TextBox();
            button_Buscar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Fornecedores).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button_Salvar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox_Fornecedor);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 188);
            panel1.TabIndex = 0;
            // 
            // button_Salvar
            // 
            button_Salvar.Location = new Point(348, 125);
            button_Salvar.Name = "button_Salvar";
            button_Salvar.Size = new Size(75, 23);
            button_Salvar.TabIndex = 3;
            button_Salvar.Text = "Salvar";
            button_Salvar.UseVisualStyleBackColor = true;
            button_Salvar.Click += button_Salvar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 12);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 2;
            label2.Text = "Fornecedores";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 59);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "Fornecedor";
            // 
            // textBox_Fornecedor
            // 
            textBox_Fornecedor.Location = new Point(105, 56);
            textBox_Fornecedor.Multiline = true;
            textBox_Fornecedor.Name = "textBox_Fornecedor";
            textBox_Fornecedor.Size = new Size(318, 31);
            textBox_Fornecedor.TabIndex = 0;
            // 
            // dataGridView_Fornecedores
            // 
            dataGridView_Fornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Fornecedores.Location = new Point(34, 279);
            dataGridView_Fornecedores.Name = "dataGridView_Fornecedores";
            dataGridView_Fornecedores.Size = new Size(391, 272);
            dataGridView_Fornecedores.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(34, 579);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox_Buscar
            // 
            textBox_Buscar.Location = new Point(34, 220);
            textBox_Buscar.Multiline = true;
            textBox_Buscar.Name = "textBox_Buscar";
            textBox_Buscar.Size = new Size(293, 30);
            textBox_Buscar.TabIndex = 3;
            // 
            // button_Buscar
            // 
            button_Buscar.Location = new Point(350, 220);
            button_Buscar.Name = "button_Buscar";
            button_Buscar.Size = new Size(75, 30);
            button_Buscar.TabIndex = 4;
            button_Buscar.Text = "Buscar";
            button_Buscar.UseVisualStyleBackColor = true;
            button_Buscar.Click += button_Buscar_Click;
            // 
            // Frm_Fornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 614);
            Controls.Add(button_Buscar);
            Controls.Add(textBox_Buscar);
            Controls.Add(button2);
            Controls.Add(dataGridView_Fornecedores);
            Controls.Add(panel1);
            Name = "Frm_Fornecedores";
            Text = "Frm_Fornecedores";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Fornecedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox textBox_Fornecedor;
        private Button button_Salvar;
        private DataGridView dataGridView_Fornecedores;
        private Button button2;
        private TextBox textBox_Buscar;
        private Button button_Buscar;
    }
}