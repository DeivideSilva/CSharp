using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using System.Data.SqlClient;


namespace Controle
{
     public class CtlCliente:Conexao

    {
         public void Cadastrar(MdlCliente cliente)
         {
             try
             {
                 Conectar();
                 cmd = new SqlCommand("Insert into TblCliente (Nome,Endereco,Telefone) Values(@v1,@v2,@v3)", con);

                 cmd.Parameters.AddWithValue("@v1", cliente.Nome);
                 cmd.Parameters.AddWithValue("@v2", cliente.Endereco);
                 cmd.Parameters.AddWithValue("@v3", cliente.Telefone);
                 cmd.ExecuteNonQuery();
             }
             catch (Exception ex)
             {

                 throw new Exception(ex.Message);
             }

             finally
             {
                 FechaConexao();
             }
         }

         public void Excluir(int Codigo)
         {
             try
             {
                 Conectar();
                 cmd = new SqlCommand("Delete From TblCliente Where Codigo=@v1",con);
                 cmd.Parameters.AddWithValue("@v1", Codigo);
                 cmd.ExecuteNonQuery();
             }
             catch (Exception ex)
             {

                 throw new Exception(ex.Message);
             }
             finally
             {
                 FechaConexao();
             }
         }

         public void Atualizar(MdlCliente cliente)
         {
             try
             {
                 Conectar();
                 cmd = new SqlCommand("UPDATE TblCliente set Nome = @v1,Endereco = @v2,Telefone = @v3 Where Codigo = @v4", con);
                 cmd.Parameters.AddWithValue("@v1", cliente.Nome);
                 cmd.Parameters.AddWithValue("@v2", cliente.Endereco);
                 cmd.Parameters.AddWithValue("@v3", cliente.Telefone);
                 cmd.Parameters.AddWithValue("@v4", cliente.Codigo);

                 cmd.ExecuteNonQuery();

             }
             catch (Exception ex)
             {

                 throw new Exception(" Erro ao atualizar os dados" + ex.Message);
             }
             finally
             {
                 FechaConexao();
             }
         }

         public MdlCliente Pesquisar(string Telefone)
         {
             try
             {
                 Conectar();
                 cmd = new SqlCommand("Select * from TblCliente Where Telefone LIKE'%'+ @v1 +'%'",con);
                 cmd.Parameters.AddWithValue("@v1", Telefone);
                 Dr = cmd.ExecuteReader();

                 MdlCliente cliente = null;
                 if (Dr.Read())
                 {
                     cliente = new MdlCliente();
                     cliente.Codigo=Convert.ToInt32(Dr["Codigo"]);
                     cliente.Nome = Convert.ToString(Dr["Nome"]);
                     cliente.Endereco = Convert.ToString(Dr["Endereco"]);
                     cliente.Telefone = Convert.ToString(Dr["Telefone"]);

                 }
                 return cliente;
             }
             catch (Exception ex)
             {

                 throw new Exception(" Erro ao Pesquisar" + ex.Message);
             }
             finally
             {
                 FechaConexao();
             }
         }

         public List<MdlCliente>Listar()
         {
             try
             {
                 Conectar();
                 cmd = new SqlCommand("Select * from TblCliente",con);

                 Dr = cmd.ExecuteReader();
                 List<MdlCliente> Listar = new List<MdlCliente>();

                 while (Dr.Read())
                 {
                     MdlCliente cliente = new MdlCliente();
                     cliente.Codigo = Convert.ToInt32(Dr["Codigo"]);
                     cliente.Nome = Convert.ToString(Dr["Nome"]);
                     cliente.Endereco = Convert.ToString(Dr["Endereco"]);
                     cliente.Telefone = Convert.ToString(Dr["Telefone"]);
                     Listar.Add(cliente);    
                 }
                 return Listar;
             }
             catch (Exception ex)
             {

                 throw new Exception("Erro ao listar os dados" + ex.Message);
             }
             finally
             {
                 FechaConexao();
             }

         }


    }

}
