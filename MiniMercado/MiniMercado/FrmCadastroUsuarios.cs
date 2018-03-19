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
    public partial class FrmCadastroUsuarios : Form
    {
        public FrmCadastroUsuarios()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
             if (txtUsuario.Text == "" && txtSenha.Text == "")
             {
               MessageBox.Show("Os campos não podem ser nulos!");
               return;
             }

            MdlCadastroUsuario mdlusuario = new MdlCadastroUsuario();
            mdlusuario.Nome = txtUsuario.Text;
            mdlusuario.Senha = txtSenha.Text;

            CtlCadastroUsuario ctlusuario = new CtlCadastroUsuario();
            ctlusuario.CadastrarUsuario(mdlusuario);
            MessageBox.Show("Usuario cadastrado com sucesso");
        }
    }
}
