using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estaciomamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    panel1.Visible = true;
                    break;

                case 1:
                    Controle_de_Entrada controle_Entrada = new Controle_de_Entrada();
                    controle_Entrada.Show();
                    break;

                case 2:
                    Controle_Saida controle_Saida = new Controle_Saida();
                    controle_Saida.Show();
                    break;



                default:
                    break;
            }
            
            

          

        }
    }
}
