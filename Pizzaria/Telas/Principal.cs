using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CadastroClientes clientes = new CadastroClientes();
            clientes.Show(); 
            
        }

        private void pizzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroPizzas pizzas = new CadastroPizzas();
            pizzas.Show();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
        }
    }
}
 