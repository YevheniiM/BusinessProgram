using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProg.DataBase
{
    public class CConnection
    {
        public String connectionString { get; private set; }
        public SqlConnection SqlConnection { get; private set; }
        public CConnection()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringName"].ConnectionString; 
            this.SqlConnection = new SqlConnection(connectionString);
        }

        public bool ConnectionStatus()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    return (con.State == ConnectionState.Open);
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
