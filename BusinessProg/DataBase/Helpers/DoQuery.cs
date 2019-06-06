using BusinessProg.DataBase.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProg.DataBase.DataBaseOperations
{
    public class DoQuery
    {
        private CConnection connection;
        public DoQuery(CConnection _connection)
        {
            connection = _connection;
        }
        public CSqlReader Start(CQueryDef command)
        {
            var con = new SqlConnection(connection.connectionString);
            var _command = new SqlCommand(command._sqlCommand, con);
            con.Open();
            return new CSqlReader(con, _command, command._type);
        }

        internal IDisposable Start(Func<CQueryDef> sqlQueries)
        {
            throw new NotImplementedException();
        }
    }
}
