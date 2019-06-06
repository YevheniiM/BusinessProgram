using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProg.DataBase.Objects
{
    public class OutputProduct
    {
        public DateTime Date { get; set; }
        public string Client { get; set; }
        public long ClientId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public long Count { get; set; }
        public long Product_Key { get; set; }
        public OutputProduct(
            DateTime date,
            string client,
            long clientID,
            string code,
            string name,
            decimal price,
            long count,
            long product_Key)
            {
                Date = date;
                Client = client;
                ClientId = clientID;
                Code = code;
                Name = name;
                Price = price;
                Count = count;
                Product_Key = product_Key;
            }
    }
}
