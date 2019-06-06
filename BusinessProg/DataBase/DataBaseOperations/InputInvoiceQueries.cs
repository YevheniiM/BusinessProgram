using BusinessProg.DataBase.Helpers;
using BusinessProg.DataBase.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProg.DataBase.DataBaseOperations
{
    public class InputInvoiceQueries
    {
        CConnection connection { get; set; }
        DoQuery doQuery;
        public InputInvoiceQueries(CConnection _connection)
        {
            connection = _connection;
            doQuery = new DoQuery(connection);
        }
        public InputInvoiceQueries()
        {
            connection = new CConnection();
            doQuery = new DoQuery(connection);
        }

        public long NewInputInvoiceNumber()
        {
            using (var reader = doQuery.Start(SqlQueries.InputInvoiceNumber()))
                return reader.GetLong(0);
        }
        public long ProductKeyByName(string productName)
        {
            using (var reader = doQuery.Start(SqlQueries.ProductKeyByProductName(productName)))
                return reader.GetLong(0);
        }
        public List<string> Providers()
        {
            using (var reader = doQuery.Start(SqlQueries.Providers()))
                return reader.GetListOfString(0);
        }

        public List<List<string>> ClientsInfo()
        {
            List<List<string>> res = new List<List<string>>();
            var reader_n = doQuery.Start(SqlQueries.ClientsNames());
            var reader_p = doQuery.Start(SqlQueries.ClientsPhones());
            var reader_i = doQuery.Start(SqlQueries.ClientsDiscount());
            var reader_e = doQuery.Start(SqlQueries.ClientsExtraData());
            res.Add(reader_n.GetListOfString(0));
            res.Add(reader_p.GetListOfString(0));
            res.Add(reader_i.GetListOfString(0));
            res.Add(reader_e.GetListOfString(0));
            return res;
        }

        public List<List<string>> ProvidersInfo()
        {
            List<List<string>> res = new List<List<string>>();
            var reader_n = doQuery.Start(SqlQueries.ProvidersNames());
            var reader_p = doQuery.Start(SqlQueries.ProvidersPhones());
            var reader_i = doQuery.Start(SqlQueries.ProvidersExtraData());
            res.Add(reader_n.GetListOfString(0));
            res.Add(reader_p.GetListOfString(0));
            res.Add(reader_i.GetListOfString(0));
            return res;
        }

        public List<List<string>> ProductsInfo()
        {
            List<List<string>> res = new List<List<string>>();
            var reader1 = doQuery.Start(SqlQueries.ProductsCodes());
            var reader2 = doQuery.Start(SqlQueries.ProductsNames());
            var reader3 = doQuery.Start(SqlQueries.ProductsCategory());
            var reader4 = doQuery.Start(SqlQueries.ProductsBought());
            var reader5 = doQuery.Start(SqlQueries.ProductsSold());
            var reader6 = doQuery.Start(SqlQueries.ProductsProvider());
            var reader7 = doQuery.Start(SqlQueries.ProductsProvider());
            res.Add(reader1.GetListOfString(0));
            res.Add(reader2.GetListOfString(0));
            res.Add(reader3.GetListOfString(0));
            res.Add(reader4.GetListOfString(0));
            res.Add(reader5.GetListOfString(0));
            res.Add(reader6.GetListOfString(0));
            res.Add(reader7.GetListOfString(0));
            return res;
        }

        private List<string> helper(List<float> arr)
        {
            var res = new List<string>();
            foreach (var r in arr)
            {
                res.Add(r.ToString());
            }
            return res;
        }

        //public List<List<string>> ClientsInfo()
        //{

        //}

        //public List<List<string>> InputInvoicesInfo()
        //{

        //}

        //public List<List<string>> OutputInvoicesInfo()
        //{

        //}

        public List<string> Products()
        {
            using (var reader = doQuery.Start(SqlQueries.Products()))
                return reader.GetListOfString(0);
        }
        public List<string> Codes()
        {
            using (var reader = doQuery.Start(SqlQueries.Codes()))
                return reader.GetListOfString(0);
        }
        public long ProviderIdByName(string providerName)
        {
            using (var reader = doQuery.Start(SqlQueries.ProviderIdByName(providerName)))
                return reader.GetLong(0);
        }
        public List<string> CodesByProvider(string providerName)
        {
            var providerId = ProviderIdByName(providerName);
            using (var reader = doQuery.Start(SqlQueries.CodesByProvider(providerId)))
                return reader.GetListOfString(0);
        }
        public List<string> ProductsNameByProvider(string providerName)
        {
            var providerId = ProviderIdByName(providerName);
            using (var reader = doQuery.Start(SqlQueries.ProductsByProviderId(providerId)))
                return reader.GetListOfString(0);
        }
        public string ProductNameByCode(string productCode)
        {
            using (var reader = doQuery.Start(SqlQueries.ProductNameByCode(productCode)))
                return reader.GetString(0);
        }
        public string ProductCodeByName(string productName)
        {
            using (var reader = doQuery.Start(SqlQueries.ProductCodeByName(productName)))
                return reader.GetString(0);
        }
        public decimal PriceByProductName(string productName)
        {
            using (var reader = doQuery.Start(SqlQueries.GetPriceByProductName(productName)))
                return reader.GetDecimal(0);
        }
        public void SaveProductsBoughtCount(List<InputProduct> products)
        {
            foreach (var p in products)
                doQuery.Start(SqlQueries.SaveProductsBoughtCount(p));
        }
        public void SaveInputInvoice(InputInvoice invoice, List<InputProduct> products)
        {
            doQuery.Start(SqlQueries.SaveIntoProviderOffers(invoice));
            foreach (var p in products)
                doQuery.Start(SqlQueries.SaveIntoProviderOffersProducts(invoice, p));
        }
    }
}

