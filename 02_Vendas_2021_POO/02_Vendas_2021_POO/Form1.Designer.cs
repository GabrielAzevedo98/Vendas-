namespace _02_Vendas_2021_POO
{
    partial class Venda
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_nome_Produto = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.lbl_Preco = new System.Windows.Forms.Label();
            this.txt_NomedoProduto = new System.Windows.Forms.TextBox();
            this.txt_Preco = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_totaldacompra = new System.Windows.Forms.Label();
            this.lbl_desconto = new System.Windows.Forms.Label();
            this.txt_total_compra = new System.Windows.Forms.TextBox();
            this.txt_desconto = new System.Windows.Forms.TextBox();
            this.lbl_a_pagar = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_nome_Produto
            // 
            this.lbl_nome_Produto.AutoSize = true;
            this.lbl_nome_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_Produto.Location = new System.Drawing.Point(13, 9);
            this.lbl_nome_Produto.Name = "lbl_nome_Produto";
            this.lbl_nome_Produto.Size = new System.Drawing.Size(137, 20);
            this.lbl_nome_Produto.TabIndex = 0;
            this.lbl_nome_Produto.Text = "Nome do Produto:";
            this.lbl_nome_Produto.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantidade.Location = new System.Drawing.Point(255, 9);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(96, 20);
            this.lbl_quantidade.TabIndex = 1;
            this.lbl_quantidade.Text = "Quantidade:";
            // 
            // lbl_Preco
            // 
            this.lbl_Preco.AutoSize = true;
            this.lbl_Preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Preco.Location = new System.Drawing.Point(12, 99);
            this.lbl_Preco.Name = "lbl_Preco";
            this.lbl_Preco.Size = new System.Drawing.Size(142, 20);
            this.lbl_Preco.TabIndex = 2;
            this.lbl_Preco.Text = "Preço Unitário  R$:";
            // 
            // txt_NomedoProduto
            // 
            this.txt_NomedoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomedoProduto.Location = new System.Drawing.Point(12, 42);
            this.txt_NomedoProduto.Name = "txt_NomedoProduto";
            this.txt_NomedoProduto.Size = new System.Drawing.Size(177, 26);
            this.txt_NomedoProduto.TabIndex = 3;
            this.txt_NomedoProduto.Text = "Digite o nome do produto";
            this.txt_NomedoProduto.TextChanged += new System.EventHandler(this.txt_NomedoProduto_TextChanged);
            // 
            // txt_Preco
            // 
            this.txt_Preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Preco.Location = new System.Drawing.Point(12, 122);
            this.txt_Preco.Name = "txt_Preco";
            this.txt_Preco.Size = new System.Drawing.Size(139, 26);
            this.txt_Preco.TabIndex = 5;
            this.txt_Preco.Text = "0";
            this.txt_Preco.TextChanged += new System.EventHandler(this.txt_Preco_TextChanged);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(12, 165);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(420, 60);
            this.btn_Calcular.TabIndex = 6;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Comprar_Click);
            // 
            // lbl_totaldacompra
            // 
            this.lbl_totaldacompra.AutoSize = true;
            this.lbl_totaldacompra.Location = new System.Drawing.Point(26, 240);
            this.lbl_totaldacompra.Name = "lbl_totaldacompra";
            this.lbl_totaldacompra.Size = new System.Drawing.Size(84, 13);
            this.lbl_totaldacompra.TabIndex = 7;
            this.lbl_totaldacompra.Text = "Total da compra";
            // 
            // lbl_desconto
            // 
            this.lbl_desconto.AutoSize = true;
            this.lbl_desconto.Location = new System.Drawing.Point(242, 240);
            this.lbl_desconto.Name = "lbl_desconto";
            this.lbl_desconto.Size = new System.Drawing.Size(56, 13);
            this.lbl_desconto.TabIndex = 10;
            this.lbl_desconto.Text = "Desconto:";
            // 
            // txt_total_compra
            // 
            this.txt_total_compra.Enabled = false;
            this.txt_total_compra.Location = new System.Drawing.Point(29, 256);
            this.txt_total_compra.Name = "txt_total_compra";
            this.txt_total_compra.Size = new System.Drawing.Size(125, 20);
            this.txt_total_compra.TabIndex = 11;
            this.txt_total_compra.Text = "0";
            // 
            // txt_desconto
            // 
            this.txt_desconto.Enabled = false;
            this.txt_desconto.Location = new System.Drawing.Point(245, 256);
            this.txt_desconto.Name = "txt_desconto";
            this.txt_desconto.Size = new System.Drawing.Size(144, 20);
            this.txt_desconto.TabIndex = 12;
            this.txt_desconto.Text = "0";
            // 
            // lbl_a_pagar
            // 
            this.lbl_a_pagar.AutoSize = true;
            this.lbl_a_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_a_pagar.Location = new System.Drawing.Point(29, 327);
            this.lbl_a_pagar.Name = "lbl_a_pagar";
            this.lbl_a_pagar.Size = new System.Drawing.Size(93, 16);
            this.lbl_a_pagar.TabIndex = 13;
            this.lbl_a_pagar.Text = "Valor a pagar:";
            this.lbl_a_pagar.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.ForeColor = System.Drawing.Color.Green;
            this.lbl_valor.Location = new System.Drawing.Point(191, 327);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(51, 55);
            this.lbl_valor.TabIndex = 14;
            this.lbl_valor.Text = "0";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(24, 407);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(115, 32);
            this.btn_limpar.TabIndex = 15;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantidade.Location = new System.Drawing.Point(259, 42);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(164, 26);
            this.txt_quantidade.TabIndex = 16;
            this.txt_quantidade.Text = "0";
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 451);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_a_pagar);
            this.Controls.Add(this.txt_desconto);
            this.Controls.Add(this.txt_total_compra);
            this.Controls.Add(this.lbl_desconto);
            this.Controls.Add(this.lbl_totaldacompra);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Preco);
            this.Controls.Add(this.txt_NomedoProduto);
            this.Controls.Add(this.lbl_Preco);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.lbl_nome_Produto);
            this.Name = "Venda";
            this.Text = "Venda de Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome_Produto;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.Label lbl_Preco;
        private System.Windows.Forms.TextBox txt_NomedoProduto;
        private System.Windows.Forms.TextBox txt_Preco;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_totaldacompra;
        private System.Windows.Forms.Label lbl_desconto;
        private System.Windows.Forms.TextBox txt_total_compra;
        private System.Windows.Forms.TextBox txt_desconto;
        private System.Windows.Forms.Label lbl_a_pagar;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.TextBox txt_quantidade;
    }
}

