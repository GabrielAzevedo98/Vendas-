using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Vendas_2021_POO
{
    public partial class Venda : Form
    {
        public Venda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_NomedoProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Preco_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            string nomeProduto = txt_NomedoProduto.Text;
            int quantidade = int.Parse(txt_quantidade.Text);
            double preco = double.Parse(txt_Preco.Text);
            
               
            double  totalCompra, desconto = 0, totalapagar = 0;

            totalCompra = preco * quantidade;
            
            if(quantidade > 0 && quantidade <= 5)
            {
               
                desconto = totalCompra * 0.02;
                totalapagar = totalCompra - desconto;
            }
            else if(quantidade >= 6 && quantidade <= 10)
            {
                
                desconto = totalCompra * 0.03;
                totalapagar = totalCompra - desconto;

            }
            else if(quantidade > 10)
            {
                
                desconto = totalCompra * 0.05;
                totalapagar = totalCompra - desconto;
                
            }
            else
            {
                MessageBox.Show("Quantidade inválida!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            txt_desconto.Text = desconto.ToString("C");
            lbl_valor.Text = totalapagar.ToString("C");
            txt_total_compra.Text = totalCompra.ToString("C");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lbl_valor.Text = "0";
            txt_total_compra.Text = "0";
            txt_desconto.Text = "0";
            txt_NomedoProduto.Text = "";
            txt_Preco.Text = "0";
            txt_quantidade.Text = "0";
        }
    }
}
