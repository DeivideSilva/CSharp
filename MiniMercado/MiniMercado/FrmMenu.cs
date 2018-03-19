using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MiniMercado
{
    public partial class FrmMenu : Form
    {
        public object UsuarioLogado { get; private set; }

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroProdutos produtos = new FrmCadastroProdutos();
            produtos.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedor fornecedor = new FrmFornecedor();
            fornecedor.ShowDialog();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendas vendas = new FrmVendas();
            vendas.ShowDialog();
        }

        private void FrmMenu_KeyDown(object sender, KeyEventArgs e)
        {  
             //Evento para chamar tecla de atalho.
            if (e.KeyCode == Keys.F1)
            {
                produtosToolStripMenuItem.PerformClick();
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            //Estes métodos pegam o nome do usuario do computador
            //label1.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Substring(4);
            //label1.Text = "Usuario " + System.Windows.Forms.SystemInformation.UserName;
            //label1.Text = System.Environment.UserName;

            // Mostra o nome do usuario que esta logado o sistema
            toolStLabel.Text = "Usuário: " + FrmLogin.UsuarioLogado.NomeUsuario;

        }

        private void toolStLabel_Click(object sender, EventArgs e)
        {
           
        }
    }
}
