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

namespace Telas
{
    public partial class CadastroClientes : Form
    {
        public CadastroClientes()
        {
            InitializeComponent();
            txtNome.Focus();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MdlCliente Cliente = new MdlCliente();
                Cliente.Nome     = txtNome.Text;
                Cliente.Endereco = txtEndereco.Text;
                Cliente.Telefone = mskTelefone.Text;

                CtlCliente ctlCliente = new CtlCliente();
                ctlCliente.Cadastrar(Cliente);

                MessageBox.Show("Cliente Cadastrado com sucesso...");

                txtNome.Text     = String.Empty;
                txtEndereco.Text = String.Empty;
                mskTelefone.Text = String.Empty;
                txtNome.Focus();
            }
            catch (Exception ex  )
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void CadastroClientes_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
