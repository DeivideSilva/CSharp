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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        //Classe para pegar e mostrar o usuario que esta logado no sistema.
        public static class UsuarioLogado
        {
            public static string NomeUsuario { get; set; }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {  
            FrmMenu menu = new FrmMenu();

            try
            {
                
                 if (txtUsuario.Text == "" && txtSenha.Text == "")
                {
                    MessageBox.Show("Por favor informe um Usuario e Senha");
                    return;
                }
              
                string Nome = txtUsuario.Text;
                string Senha = txtSenha.Text;
                CtlCadastroUsuario usuario = new CtlCadastroUsuario();
                MdlCadastroUsuario mdlusuario = usuario.ValidaUsuario(Nome, Senha);

                if (mdlusuario != null)
                {
                    txtUsuario.Text = mdlusuario.Nome;
                    txtSenha.Text = mdlusuario.Senha;

                    // setando o valor da propriedade Statica na classe UsuarioLogado
                    UsuarioLogado.NomeUsuario = txtUsuario.Text;
                  
                    menu.ShowDialog();
                   
                }
                else
                {
                    MessageBox.Show("Usuario não cadastrado no sistema");
                    txtUsuario.Text = string.Empty;
                    txtSenha.Text = string.Empty;
                    txtUsuario.Focus();
                }
               
            }
            catch (Exception )
            {

                throw; //MessageBox.Show(ex.Message) ;
            }
            
        }
    
        
        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuarios usuarios = new FrmCadastroUsuarios();
            usuarios.ShowDialog();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
