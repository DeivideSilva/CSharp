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
    public partial class CadastroPizzas : Form
    {
        public CadastroPizzas()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MdlPizza pizza = new MdlPizza();
                pizza.NomePizza = txtNomePizza.Text;
                pizza.Valor = Convert.ToDouble(txtValor.Text);

                CtlPizza ctPizza = new CtlPizza();
                ctPizza.Cadastrar(pizza);
                MessageBox.Show("Pizza cadastrada com sucesso...");
            }
            catch ( Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
