using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Controle
{
    public class Conexao
    {
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataReader Dr;

        protected void Conectar()
        {
            try
            {
                con = new SqlConnection("Data Source=JULIA-PC;Initial Catalog=Pizzaria;Integrated Security=True");
                con.Open();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        protected void FechaConexao()
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
