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
    public partial class FrmCadastroProdutos : Form
    {
        public FrmCadastroProdutos()
        {
            InitializeComponent();
            txtproduto.Focus();
            
          
        }
        // Metodo para fechar a tela que estiver selecionada.
        public void Sair()
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
             if (txtproduto.Text == "" && txtpreco.Text == "" && txtquantidade.Text == "")
             {
                 MessageBox.Show("Os campos não podem ser nulos!");
                 return;
             }

            MdlCadastroProdutos produtos = new MdlCadastroProdutos();

            produtos.Produto = txtproduto.Text;
          
            produtos.Preco = Convert.ToDecimal(txtpreco.Text);
            txtpreco.Text = String.Format("{0:C}",produtos.Preco);
          
            produtos.QTD = Convert.ToInt32(txtquantidade.Text);

            CtlCadastroProdutos ctlprodutos = new CtlCadastroProdutos();
            ctlprodutos.Cadastrar(produtos);

            MessageBox.Show("Produto cadastrado com sucesso!");
          
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            txtproduto.Focus();
            txtproduto.Text = string.Empty;
            txtpreco.Text = string.Empty;
            txtquantidade.Text = string.Empty;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Chamando o metodo Sair
              Sair();
        }

        private void FrmCadastroProdutos_Load(object sender, EventArgs e)
        {
            
        }

        private void ck(object sender, EventArgs e){
    
        }
    }
}
