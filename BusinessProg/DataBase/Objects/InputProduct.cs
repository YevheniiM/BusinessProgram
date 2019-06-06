using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProg.DataBase.Objects
{
    public class InputProduct
    {
        public DateTime Date { get; set; }
        public string Provider { get; set; }
        public long ProviderId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public decimal Count { get; set; }
        public long Product_Key { get; set; }

        public InputProduct(
            DateTime date,
            string provider,
            long providerId,
            string code,
            string name,
            float price,
            decimal count,
            long product_Key)
        {
            Date = date;
            Provider = provider;
            ProviderId = providerId;
            Code = code;
            Name = name;
            Price = price;
            Count = count;
            Product_Key = product_Key;
        }
    }
}
