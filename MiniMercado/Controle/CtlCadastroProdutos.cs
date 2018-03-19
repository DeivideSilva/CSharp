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
    public class CtlCadastroProdutos:CtlConexao
    {
        public void Cadastrar(MdlCadastroProdutos produto)
        {
            try
            {
                AbrirConexao();
                cmd = new OleDbCommand("Insert Into CadastroProdutos(Produto,Preco,QTD) Values(@v1,@v2,@v3)", con);
                cmd.Parameters.AddWithValue("@v1", produto.Produto);
                cmd.Parameters.AddWithValue("@v2", produto.Preco);
                cmd.Parameters.AddWithValue("@v3", produto.QTD);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao salvar os dados do Produto..." + ex.Message);
            }

            finally
            {
                FecharConexao();
            }
        }

        public MdlCadastroProdutos Pesquisar(string Produto)
        {
            try
            {
                AbrirConexao();
                cmd = new OleDbCommand("Select * from CadastroProdutos WHERE Produto = @v1", con);
                cmd.Parameters.AddWithValue("@v1",Produto);
                Dr = cmd.ExecuteReader();

                MdlCadastroProdutos produto = null;
                if (Dr.Read())
                {
                    produto = new MdlCadastroProdutos();
                    produto.Produto = Convert.ToString(Dr["Produto"]);
                    produto.Preco = Convert.ToDecimal(Dr["Preco"]);
                    produto.QTD = Convert.ToInt32(Dr["QTD"]);

                }
                return produto;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao pesquisar o produto" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }

        }
    }
    

}
