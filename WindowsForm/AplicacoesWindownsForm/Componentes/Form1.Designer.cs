namespace Componentes
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
            label_frase = new Label();
            textBox_frase = new TextBox();
            textBox_relacaoNomes = new TextBox();
            listView_relacaoNomes = new ListView();
            Nome = new ColumnHeader();
            Email = new ColumnHeader();
            button_limpar = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            limparToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            button_cadastrar = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label_frase
            // 
            label_frase.AutoSize = true;
            label_frase.Location = new Point(22, 29);
            label_frase.Name = "label_frase";
            label_frase.Size = new Size(99, 15);
            label_frase.TabIndex = 0;
            label_frase.Text = "Digite uma frase: ";
            // 
            // textBox_frase
            // 
            textBox_frase.BorderStyle = BorderStyle.FixedSingle;
            textBox_frase.Location = new Point(144, 25);
            textBox_frase.Name = "textBox_frase";
            textBox_frase.Size = new Size(400, 23);
            textBox_frase.TabIndex = 1;
            textBox_frase.KeyPress += textBox_frase_KeyPress;
            // 
            // textBox_relacaoNomes
            // 
            textBox_relacaoNomes.Enabled = false;
            textBox_relacaoNomes.Location = new Point(425, 77);
            textBox_relacaoNomes.Multiline = true;
            textBox_relacaoNomes.Name = "textBox_relacaoNomes";
            textBox_relacaoNomes.Size = new Size(332, 301);
            textBox_relacaoNomes.TabIndex = 2;
            // 
            // listView_relacaoNomes
            // 
            listView_relacaoNomes.Columns.AddRange(new ColumnHeader[] { Nome, Email });
            listView_relacaoNomes.Location = new Point(22, 77);
            listView_relacaoNomes.Name = "listView_relacaoNomes";
            listView_relacaoNomes.Size = new Size(348, 301);
            listView_relacaoNomes.TabIndex = 3;
            listView_relacaoNomes.UseCompatibleStateImageBehavior = false;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            // 
            // Email
            // 
            Email.Text = "Email";
            // 
            // button_limpar
            // 
            button_limpar.Location = new Point(579, 25);
            button_limpar.Name = "button_limpar";
            button_limpar.Size = new Size(75, 23);
            button_limpar.TabIndex = 4;
            button_limpar.Text = "Limpar";
            button_limpar.UseVisualStyleBackColor = true;
            button_limpar.Click += button_limpar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { limparToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // limparToolStripMenuItem
            // 
            limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            limparToolStripMenuItem.Size = new Size(111, 22);
            limparToolStripMenuItem.Text = "Limpar";
            limparToolStripMenuItem.Click += limparToolStripMenuItem_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(49, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // button_cadastrar
            // 
            button_cadastrar.Location = new Point(682, 25);
            button_cadastrar.Name = "button_cadastrar";
            button_cadastrar.Size = new Size(75, 23);
            button_cadastrar.TabIndex = 6;
            button_cadastrar.Text = "Cadastrar";
            button_cadastrar.UseVisualStyleBackColor = true;
            button_cadastrar.Click += button_cadastrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_cadastrar);
            Controls.Add(button_limpar);
            Controls.Add(listView_relacaoNomes);
            Controls.Add(textBox_relacaoNomes);
            Controls.Add(textBox_frase);
            Controls.Add(label_frase);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_frase;
        private TextBox textBox_frase;
        private TextBox textBox_relacaoNomes;
        private ListView listView_relacaoNomes;
        private Button button_limpar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem limparToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private Button button_cadastrar;
        private ColumnHeader Nome;
        private ColumnHeader Email;
    }
}