using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using Controle.Properties;

namespace Controle
{
    public class CtlConexao
    {
        protected OleDbConnection con;
        protected OleDbCommand cmd;
        protected OleDbDataReader Dr;

        protected void AbrirConexao()
        {
            try 
	        {	        
		      con = new OleDbConnection(Settings.Default.StringConexao);
              con.Open();
	        }
	        catch (Exception ex )
	        {
		
		        throw new Exception("Erro ao se conectar com o banco de dados!"+ ex.Message);
	        }

        }

        protected void FecharConexao()
        {
            con.Close();
        }

    }
}
