namespace MiniERP
{
    partial class Frm_Principal
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
            button_Produto = new Button();
            panel1 = new Panel();
            button_Cliente = new Button();
            button_Fornecedor = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button_Produto
            // 
            button_Produto.Location = new Point(166, 219);
            button_Produto.Name = "button_Produto";
            button_Produto.Size = new Size(97, 41);
            button_Produto.TabIndex = 0;
            button_Produto.Text = "Produtos";
            button_Produto.UseVisualStyleBackColor = true;
            button_Produto.Click += button_Produto_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button_Fornecedor);
            panel1.Controls.Add(button_Cliente);
            panel1.Controls.Add(button_Produto);
            panel1.Location = new Point(-4, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 458);
            panel1.TabIndex = 1;
            // 
            // button_Cliente
            // 
            button_Cliente.Location = new Point(339, 219);
            button_Cliente.Name = "button_Cliente";
            button_Cliente.Size = new Size(97, 41);
            button_Cliente.TabIndex = 1;
            button_Cliente.Text = "Clientes";
            button_Cliente.UseVisualStyleBackColor = true;
            button_Cliente.Click += button_Cliente_Click;
            // 
            // button_Fornecedor
            // 
            button_Fornecedor.Location = new Point(512, 219);
            button_Fornecedor.Name = "button_Fornecedor";
            button_Fornecedor.Size = new Size(97, 41);
            button_Fornecedor.TabIndex = 2;
            button_Fornecedor.Text = "Fornecedores";
            button_Fornecedor.UseVisualStyleBackColor = true;
            button_Fornecedor.Click += this.button_Fornecedor_Click;
            // 
            // Frm_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Frm_Principal";
            Text = "Mini ERP";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button_Produto;
        private Panel panel1;
        private Button button_Cliente;
        private Button button_Fornecedor;
    }
}
