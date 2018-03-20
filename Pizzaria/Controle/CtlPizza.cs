using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Modelo;

namespace Controle
{
     public class CtlPizza:Conexao
    {
        public void Cadastrar (MdlPizza pizza)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("Insert into TblPizza (NomePizza,Valor) Values(@v1,@v2)", con);
                cmd.Parameters.AddWithValue("@v1", pizza.NomePizza);
                cmd.Parameters.AddWithValue("@v2", pizza.Valor);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao salvar os dados!" + ex.Message);
            }
            finally
            {
                FechaConexao();
            }
        }

        public void Alterar(MdlPizza pizza)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE TblPizza set NomePizza = @v1,Valor = @v2 Where Codigo = @v3",con);
                cmd.Parameters.AddWithValue("@v1",pizza.NomePizza);
                cmd.Parameters.AddWithValue("@v2",pizza.Valor);
                cmd.Parameters.AddWithValue("@v3",pizza.Codigo);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Alterar os dados"+ ex.Message);
            }
            finally
            {
                FechaConexao();
            }
        }

        public MdlPizza Pesquisar(int Codigo)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("Select * from TblPizza Where Codigo =@v1",con);
                cmd.Parameters.AddWithValue("@v1",Codigo);
                Dr = cmd.ExecuteReader();

                MdlPizza pizza = null;
                if (Dr.Read())
                {
                    pizza = new MdlPizza();
                    pizza.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    pizza.NomePizza = Convert.ToString(Dr["NomePizza"]);
                    pizza.Valor = Convert.ToDouble(Dr["Valor"]);
                }
                return pizza;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Pesquisar os dados" + ex.Message);
            }
            finally
            {
                FechaConexao();
            }
        }
        
    }
}
