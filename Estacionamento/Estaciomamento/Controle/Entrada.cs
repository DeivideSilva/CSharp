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
    public class Entrada:CtlConexao
    {
        public void Gravar(mdlEntrada entrada)
        {
            try
            {
                AbrirConexao();
                cmd = new OleDbCommand("Insert into ControleEntrada(Placa,DataEntrada,HoraEntrada)Values(@v1,@v2,@v3)", con);
                cmd.Parameters.AddWithValue("@v1",entrada.Placa);
                cmd.Parameters.AddWithValue("@v2",entrada.DataEntrada);
                cmd.Parameters.AddWithValue("@v3",entrada.HoraEntrada);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar os dados..." + ex.Message);
            }
            finally
            {
                FecharConexao();
            }


        }

        public mdlEntrada Pesquisar(string placa)
        {
            try
            {
                AbrirConexao();
                cmd = new OleDbCommand("Select * From ControleEntrada Where placa = @v1",con);
                cmd.Parameters.AddWithValue("@v1",placa);
                dr = cmd.ExecuteReader();

                mdlEntrada _mdlEntrada = null;
                if (dr.Read())
                {
                    _mdlEntrada = new mdlEntrada();
                    _mdlEntrada.Placa =Convert.ToString(dr["Placa"]);
                    _mdlEntrada.DataEntrada = Convert.ToDateTime(dr["DataEntrada"]);
                    _mdlEntrada.HoraEntrada = Convert.ToDateTime(dr["HoraEntrada"]);

                }
                return _mdlEntrada;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Pesquisar o Veiculo..." + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
