namespace AmigoSecreto
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
            textBox_Nome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button_Inserir = new Button();
            listView_Participantes = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            button_GerarAmigo = new Button();
            label3 = new Label();
            label_Participantes = new Label();
            panel1 = new Panel();
            button_Editar = new Button();
            button_Remover = new Button();
            button_EnviarEmail = new Button();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            textBox_Email = new TextBox();
            label_Mensagem = new Label();
            menuStrip1 = new MenuStrip();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            visualizarAmigoSecretoToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_Nome
            // 
            textBox_Nome.Cursor = Cursors.IBeam;
            textBox_Nome.Font = new Font("Segoe UI", 12F);
            textBox_Nome.Location = new Point(120, 100);
            textBox_Nome.Multiline = true;
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.Size = new Size(582, 30);
            textBox_Nome.TabIndex = 0;
            textBox_Nome.KeyPress += textBox_Nome_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(326, 34);
            label1.Name = "label1";
            label1.Size = new Size(207, 37);
            label1.TabIndex = 1;
            label1.Text = "Amigo Secreto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(35, 103);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // button_Inserir
            // 
            button_Inserir.BackColor = Color.GhostWhite;
            button_Inserir.Cursor = Cursors.Hand;
            button_Inserir.Font = new Font("Segoe UI", 12F);
            button_Inserir.Location = new Point(715, 173);
            button_Inserir.Name = "button_Inserir";
            button_Inserir.Size = new Size(123, 30);
            button_Inserir.TabIndex = 3;
            button_Inserir.Text = "Inserir";
            button_Inserir.UseVisualStyleBackColor = false;
            button_Inserir.Click += button_Inserir_Click;
            // 
            // listView_Participantes
            // 
            listView_Participantes.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView_Participantes.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView_Participantes.Location = new Point(32, 309);
            listView_Participantes.MultiSelect = false;
            listView_Participantes.Name = "listView_Participantes";
            listView_Participantes.Size = new Size(806, 350);
            listView_Participantes.TabIndex = 4;
            listView_Participantes.UseCompatibleStateImageBehavior = false;
            listView_Participantes.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nome";
            columnHeader1.Width = 400;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Email";
            columnHeader2.Width = 400;
            // 
            // button_GerarAmigo
            // 
            button_GerarAmigo.BackColor = Color.RoyalBlue;
            button_GerarAmigo.Cursor = Cursors.Hand;
            button_GerarAmigo.Font = new Font("Segoe UI", 12F);
            button_GerarAmigo.ForeColor = SystemColors.ControlLightLight;
            button_GerarAmigo.Location = new Point(653, 697);
            button_GerarAmigo.Name = "button_GerarAmigo";
            button_GerarAmigo.Size = new Size(181, 39);
            button_GerarAmigo.TabIndex = 5;
            button_GerarAmigo.Text = "Gerar amigo secreto";
            button_GerarAmigo.UseVisualStyleBackColor = false;
            button_GerarAmigo.Click += button_GerarAmigo_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(32, 270);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 7;
            label3.Text = "Participantes";
            // 
            // label_Participantes
            // 
            label_Participantes.AutoSize = true;
            label_Participantes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label_Participantes.ForeColor = Color.RoyalBlue;
            label_Participantes.Location = new Point(166, 270);
            label_Participantes.Name = "label_Participantes";
            label_Participantes.Size = new Size(23, 25);
            label_Participantes.TabIndex = 8;
            label_Participantes.Text = "0";
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(button_Editar);
            panel1.Controls.Add(button_Remover);
            panel1.Controls.Add(button_EnviarEmail);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label_Participantes);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(listView_Participantes);
            panel1.Controls.Add(button_GerarAmigo);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 778);
            panel1.TabIndex = 9;
            // 
            // button_Editar
            // 
            button_Editar.BackColor = Color.RoyalBlue;
            button_Editar.Cursor = Cursors.Hand;
            button_Editar.Font = new Font("Segoe UI", 12F);
            button_Editar.ForeColor = SystemColors.ControlLightLight;
            button_Editar.Location = new Point(446, 697);
            button_Editar.Name = "button_Editar";
            button_Editar.Size = new Size(181, 39);
            button_Editar.TabIndex = 12;
            button_Editar.Text = "Editar Informações";
            button_Editar.UseVisualStyleBackColor = false;
            button_Editar.Click += button_Editar_Click;
            // 
            // button_Remover
            // 
            button_Remover.BackColor = Color.RoyalBlue;
            button_Remover.Cursor = Cursors.Hand;
            button_Remover.Font = new Font("Segoe UI", 12F);
            button_Remover.ForeColor = SystemColors.ControlLightLight;
            button_Remover.Location = new Point(239, 697);
            button_Remover.Name = "button_Remover";
            button_Remover.Size = new Size(181, 39);
            button_Remover.TabIndex = 11;
            button_Remover.Text = "Remover Participante";
            button_Remover.UseVisualStyleBackColor = false;
            button_Remover.Click += button_Remover_Click;
            // 
            // button_EnviarEmail
            // 
            button_EnviarEmail.BackColor = Color.RoyalBlue;
            button_EnviarEmail.Cursor = Cursors.Hand;
            button_EnviarEmail.Font = new Font("Segoe UI", 12F);
            button_EnviarEmail.ForeColor = SystemColors.ControlLightLight;
            button_EnviarEmail.Location = new Point(32, 697);
            button_EnviarEmail.Name = "button_EnviarEmail";
            button_EnviarEmail.Size = new Size(181, 39);
            button_EnviarEmail.TabIndex = 10;
            button_EnviarEmail.Text = "Enviar Por Email";
            button_EnviarEmail.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox_Email);
            panel2.Controls.Add(label_Mensagem);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button_Inserir);
            panel2.Controls.Add(textBox_Nome);
            panel2.Controls.Add(menuStrip1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(884, 246);
            panel2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 74);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 8;
            label5.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(35, 175);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // textBox_Email
            // 
            textBox_Email.Cursor = Cursors.IBeam;
            textBox_Email.Font = new Font("Segoe UI", 12F);
            textBox_Email.Location = new Point(120, 173);
            textBox_Email.Multiline = true;
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(582, 30);
            textBox_Email.TabIndex = 5;
            // 
            // label_Mensagem
            // 
            label_Mensagem.AutoSize = true;
            label_Mensagem.Enabled = false;
            label_Mensagem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label_Mensagem.ForeColor = SystemColors.ControlLightLight;
            label_Mensagem.Location = new Point(120, 142);
            label_Mensagem.Name = "label_Mensagem";
            label_Mensagem.Size = new Size(68, 15);
            label_Mensagem.TabIndex = 4;
            label_Mensagem.Text = "mensagem";
            label_Mensagem.Visible = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.RoyalBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(884, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.BackColor = Color.RoyalBlue;
            sobreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visualizarAmigoSecretoToolStripMenuItem });
            sobreToolStripMenuItem.ForeColor = SystemColors.ControlText;
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(49, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // visualizarAmigoSecretoToolStripMenuItem
            // 
            visualizarAmigoSecretoToolStripMenuItem.BackColor = Color.GhostWhite;
            visualizarAmigoSecretoToolStripMenuItem.Name = "visualizarAmigoSecretoToolStripMenuItem";
            visualizarAmigoSecretoToolStripMenuItem.Size = new Size(201, 22);
            visualizarAmigoSecretoToolStripMenuItem.Text = "Visualizar amigo secreto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 775);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Sorteio";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox_Nome;
        private Label label1;
        private Label label2;
        private Button button_Inserir;
        private ListView listView_Participantes;
        private Button button_GerarAmigo;
        private Label label3;
        private Label label_Participantes;
        private Panel panel1;
        private Panel panel2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button button2;
        private Label label_Mensagem;
        private Button button1;
        private Button button_Editar;
        private Button button_Remover;
        private Button button_EnviarEmail;
        private Label label4;
        private TextBox textBox_Email;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem visualizarAmigoSecretoToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private Label label5;
    }
}