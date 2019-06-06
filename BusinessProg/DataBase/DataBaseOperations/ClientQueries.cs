using BusinessProg.DataBase.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProg.DataBase.DataBaseOperations
{
    class ClientQueries
    {
        CConnection connection { get; set; }
        DoQuery doQuery;
        public ClientQueries(CConnection _connection)
        {
            connection = _connection;
            doQuery = new DoQuery(connection);
        }
        public ClientQueries()
        {
            connection = new CConnection();
            doQuery = new DoQuery(connection);
        }
        public void AddClient(string Name, string PhoneNumber, decimal Discount, string ExtraData)
        {
            doQuery.Start(SqlQueries.AddProduct(Name, PhoneNumber, Discount, ExtraData));
        }
        public void AddProvider(string Name, string PhoneNumber, string ExtraData)
        {
            doQuery.Start(SqlQueries.SaveProvider(Name, PhoneNumber, ExtraData));
        }
        public void DelClient(long clientId)
        {
            doQuery.Start(SqlQueries.DelClient(clientId));
        }
    }
}
