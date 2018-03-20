using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Controle.Properties;

namespace Controle
{
    public class CtlConexao
    {
        protected OleDbConnection con;
        protected OleDbCommand cmd;
        protected OleDbDataReader dr;

        protected void AbrirConexao()
        {
            try
            {
                con = new OleDbConnection(Settings.Default.stringConexao);
                con.Open();
            }
            catch (Exception ex)
            {
                
                throw new Exception("Erro ao conectar-se" + ex.Message);
            }


        }

        protected void FecharConexao()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

    }
}
