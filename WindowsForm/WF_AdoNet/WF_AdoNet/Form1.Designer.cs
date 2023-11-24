namespace WF_AdoNet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            textBox_Nome = new TextBox();
            textBox_Idade = new TextBox();
            button_Cadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(283, 53);
            button1.Name = "button1";
            button1.Size = new Size(89, 34);
            button1.TabIndex = 0;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 23);
            textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(335, 262);
            dataGridView1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button_Cadastrar);
            groupBox1.Controls.Add(textBox_Idade);
            groupBox1.Controls.Add(textBox_Nome);
            groupBox1.Location = new Point(437, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(326, 319);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textBox_Nome
            // 
            textBox_Nome.Location = new Point(54, 67);
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.Size = new Size(170, 23);
            textBox_Nome.TabIndex = 0;
            // 
            // textBox_Idade
            // 
            textBox_Idade.Location = new Point(54, 137);
            textBox_Idade.Name = "textBox_Idade";
            textBox_Idade.Size = new Size(170, 23);
            textBox_Idade.TabIndex = 1;
            // 
            // button_Cadastrar
            // 
            button_Cadastrar.Location = new Point(54, 197);
            button_Cadastrar.Name = "button_Cadastrar";
            button_Cadastrar.Size = new Size(75, 23);
            button_Cadastrar.TabIndex = 2;
            button_Cadastrar.Text = "Cadastrar";
            button_Cadastrar.UseVisualStyleBackColor = true;
            button_Cadastrar.Click += button_Cadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 38);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 110);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Idade";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button button_Cadastrar;
        private TextBox textBox_Idade;
        private TextBox textBox_Nome;
    }
}
