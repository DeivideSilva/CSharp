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
    public partial class Controle_de_Entrada : Form
    {
        public Controle_de_Entrada()
        {
            InitializeComponent();
            txtdata.Text = DateTime.Now.ToShortDateString();
            txthora.Text = DateTime.Now.ToShortTimeString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Controle_de_Entrada_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            mdlEntrada mdlEntrada = new mdlEntrada();
            mdlEntrada.Placa = mskplaca.Text;
            mdlEntrada.DataEntrada = Convert.ToDateTime(txtdata.Text);
            mdlEntrada.HoraEntrada = Convert.ToDateTime(txthora.Text);

            Entrada ctlentrada = new Entrada();
            ctlentrada.Gravar(mdlEntrada);

            MessageBox.Show("Dados gravados com sucesso!");

            mskplaca.Focus();
            mskplaca.Text = string.Empty;
            txthora.Text  = string.Empty;
            txtdata.Text  = string.Empty;
        }

      
    }
}
