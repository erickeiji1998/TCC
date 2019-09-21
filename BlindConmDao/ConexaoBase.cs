using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlindConmDao
{
    public class ConexaoBase
    {
        string conexao = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
        public SqlConnection Conexao()
        {
            SqlConnection conn = new SqlConnection(conexao);
            conn.Open();
            return conn;
        }
    }
}
