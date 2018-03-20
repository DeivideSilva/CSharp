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

namespace Estaciomamento
{
    public partial class Controle_Saida : Form
    {
        public Controle_Saida()
        {
            InitializeComponent();
            txthoraSaida.Text = DateTime.Now.ToShortTimeString();
            txtdatasaida.Text = DateTime.Now.ToShortDateString();
            mskplaca.Focus();
            mskplaca.Mask.ToUpper();
        }

        private void Controle_Saida_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
             mdlEntrada entrada = new mdlEntrada();
            entrada.Placa = mskplaca.Text;
            entrada.HoraEntrada = Convert.ToDateTime(txthoraEntrada.Text);
            entrada.DataEntrada =Convert.ToDateTime(txtdataEntrada.Text);

            Entrada ctlEntrada = new Entrada();
            ctlEntrada.Pesquisar(entrada.Placa);
        }

        private void txtdatasaida_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {

        }
    }
}
