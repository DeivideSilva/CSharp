using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Modelo;


namespace Controle
{
    public class CtlCadastroUsuario : CtlConexao
    {
        public void CadastrarUsuario(MdlCadastroUsuario usuario)
        {
            try
            {
                AbrirConexao();
                cmd = new OleDbCommand("Insert Into CadastroUsuario(Nome,Senha) Values(@v1,@v2)", con);
                cmd.Parameters.AddWithValue("@v1",usuario.Nome);
                cmd.Parameters.AddWithValue("@v2", usuario.Senha);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar o novo usuario" + ex.Message);
            }

            finally
            {
                FecharConexao();
            }

        }

        public MdlCadastroUsuario ValidaUsuario(string Nome,string Senha)
        {
            try
            {
                AbrirConexao();
                cmd = new OleDbCommand("Select * from CadastroUsuario Where Nome = @v1 and Senha = @v2 ",con);
                cmd.Parameters.AddWithValue("@v1",Nome);
                cmd.Parameters.AddWithValue("@v2",Senha);

                Dr = cmd.ExecuteReader();
               MdlCadastroUsuario usuario = null;
                  if(Dr.Read())
                  {
                      usuario = new MdlCadastroUsuario();
                      usuario.Nome = Convert.ToString(Dr["Nome"]);
                      usuario.Senha = Convert.ToString(Dr["Senha"]);

                  }
                  return usuario;
    
            }
            catch (Exception ex)
            {

                throw new Exception ("Erro ao pesquisar o usuario" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

    }
}
