using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProg.DataBase.Objects
{
    public class OutputInvoice
    {
        public long SaleKey { get; set; }
        public DateTime Date { get; set; }
        public long Client_Id { get; set; }
        public OutputInvoice(long saleKey, DateTime date, long client_Id)
        {
            SaleKey = saleKey;
            Date = date;
            Client_Id = client_Id;
        }

    }
}

