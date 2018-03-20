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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxPizza.SelectedIndex)
            {
                case 0:
                    txtvalor.Text = "R$ 15,00";
                    break;

                default:
                    break;
            }


            //Pode usar o if ou o switch case para fazer a verificação dos dados.
           /*f (cbxPizza.SelectedItem == "Mussarela")
            {
                txtvalor.Text = "R$ 15,00";
            }

            if (cbxPizza.SelectedItem == "Calabresa")
            {
                txtvalor.Text = "R$ 12,00";
            }

            if (cbxPizza.SelectedItem == "Portuguesa")
            {
                txtvalor.Text = "R$ 18,00";
            }
            if (cbxPizza.SelectedItem == "Frango com Catupiry")
            {
                txtvalor.Text = "R$ 20,00";
            }
*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Telefone = mskTelefone.Text;
                CtlCliente cliente = new CtlCliente();

                MdlCliente mdCliente = cliente.Pesquisar(Telefone);

                if (mdCliente != null)
                {
                   

                    txtNome.Text = mdCliente.Nome;
                    txtEndereco.Text = mdCliente.Endereco;
                    txtTelefone.Text = mdCliente.Telefone;
                   
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!");
                    txtNome.Text = string.Empty;
                    txtEndereco.Text = string.Empty;
                    txtTelefone.Text = string.Empty;
                    txtNome.Focus();
                }
            }
            catch (Exception )
            {
                
                throw;
            }
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
          
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblClienteTableAdapter.FillBy(this.pizzariaDataSet.TblCliente);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dtcliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNome.Text     = String.Empty;
            txtEndereco.Text = String.Empty;
            txtTelefone.Text = String.Empty;
            cbxPizza.Text    = String.Empty;
            txtvalor.Text    = String.Empty;
            mskTelefone.Text = String.Empty;
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            CtlCliente cliente = new CtlCliente();

            ClienteColecao colecaoCliente = new ClienteColecao();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MdlCliente cliente = new MdlCliente();
            cliente.Nome = txtNome.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Telefone = mskTelefone.Text;

            CtlCliente Ctlcliente = new CtlCliente();
            Ctlcliente.Atualizar(cliente);
            MessageBox.Show("Dados atualizados com sucesso");

        }

    }
}
