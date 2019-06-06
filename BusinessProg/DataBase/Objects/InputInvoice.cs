using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProg.DataBase.Objects
{
    public class InputInvoice
    {
        public long _purchaseKey { get; set; }
        public DateTime _date { get; set; }
        public long _provider_Id { get; set; }

        public InputInvoice(long PurchaseKey, DateTime Date, long Provider_Id)
        {
            _purchaseKey = PurchaseKey;
            _date = Date;
            _provider_Id = Provider_Id;
        }
    }
}

