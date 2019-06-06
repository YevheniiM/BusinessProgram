using BusinessProg.DataBase.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProg.DataBase.DataBaseOperations
{
    class ProductQueries
    {
        CConnection connection { get; set; }
        DoQuery doQuery;

        public ProductQueries()
        {
            connection = new CConnection();
            doQuery = new DoQuery(connection);
        }
    }
}
