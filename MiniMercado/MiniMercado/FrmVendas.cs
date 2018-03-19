using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controle;

namespace MiniMercado
{
    public partial class FrmVendas : Form
    {
        decimal somatotal = 0;
        

        public FrmVendas()
        {
            InitializeComponent();
            
        }

        private void txtTroco_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtTroco_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltroco_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            txtpesquisar.Focus();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            listProd.Text= string.Empty;
            txtTotal.Text = string.Empty;
            txttroco.Text = string.Empty;
            txtDinheiro.Text = string.Empty;
            txtpesquisar.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttroco_Click(object sender, EventArgs e)
        {
            
        }

        private void txttroco_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lbltroco_Click_1(object sender, EventArgs e)
        {
           
        }

        private void lbltroco_Enter(object sender, EventArgs e)
        {

        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
           
           
        }

        private void txtitens_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTotal_TextChanged_1()
        {
        
        }

        private void txtDinheiro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpreco_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void txtpesquisar_TextChanged(object sender, EventArgs e)
        {
            string Produto = txtpesquisar.Text;
            CtlCadastroProdutos ctlprodutos = new CtlCadastroProdutos();

            MdlCadastroProdutos mdlprodutos = ctlprodutos.Pesquisar(Produto);

            if (mdlprodutos != null)
            {
                listProd.Items.Add(string.Format("# {0}  - {1}", mdlprodutos.Produto, mdlprodutos.Preco + " Reais " + "    " +  txtQtd.Text + " unidade "));


                decimal valorPro = Convert.ToDecimal(mdlprodutos.Preco);

                if (txtQtd.Text == "") 
                {
                    somatotal += valorPro;
                }
                else
                {
                    somatotal += (valorPro * Convert.ToInt32(txtQtd.Text));
                }

                    txtTotal.Text = Convert.ToString(somatotal);
                    txtTotal.Text = String.Format("{0:N}", somatotal);
                    txtpesquisar.Text = string.Empty;
                    txtQtd.Text = string.Empty;
                
            }

        }

        private void txttroco_MouseClick_1(object sender, MouseEventArgs e)
        {
            double total;
            double dinheiro;
            double troco;

            total = Convert.ToDouble(txtTotal.Text);
            txtTotal.Text = String.Format("{0:N}", total);

            dinheiro = Convert.ToDouble(txtDinheiro.Text);
            txtDinheiro.Text = String.Format("{0:N}", dinheiro);

            if (dinheiro < total)
            {
                MessageBox.Show("Valor insuficiente para efetuar o pagamento!");
                txtDinheiro.Focus();
            }
            else
            {
                troco = Convert.ToDouble(Convert.ToString(dinheiro - total));
                txttroco.Text = String.Format("{0:N}", troco);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void listProd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
