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
    public class OutputInvoiceQueries
    {
        CConnection connection { get; set; }
        DoQuery doQuery;
        public OutputInvoiceQueries(CConnection _connection)
        {
            connection = _connection;
            doQuery = new DoQuery(connection);
        }
        public OutputInvoiceQueries()
        {
            connection = new CConnection();
            doQuery = new DoQuery(connection);
        }

        public long NewOutputInvoiceNumber()
        {
            using (var reader = doQuery.Start(SqlQueries.OutputInvoiceNumber()))
                return reader.GetLong(0);
        }
        public List<string> Products()
        {
            using (var reader = doQuery.Start(SqlQueries.Products()))
                return reader.GetListOfString(0);
        }
        public List<string> ClientsNames()
        {
            using (var reader = doQuery.Start(SqlQueries.ClientsNames()))
                return reader.GetListOfString(0);
        }
        public long ClientsIdByName(string clientName)
        {
            using (var reader = doQuery.Start(SqlQueries.ClientsIdByName(clientName)))
                return reader.GetLong(0);
        }
        public decimal PriceByProductName(string productName)
        {
            using (var reader = doQuery.Start(SqlQueries.GetPriceByProductName(productName)))
                return reader.GetDecimal(0);
        }
        public string ProductNameByCode(string productCode)
        {
            try
            {
                using (var reader = doQuery.Start(SqlQueries.ProductNameByCode(productCode)))
                    return reader.GetString(0);
            }
            catch (Exception)
            {
                return String.Empty;
            }
        }

        internal string ClientPhoneById(string clientId)
        {
            using (var reader = doQuery.Start(SqlQueries.ClientPhoneById(long.Parse(clientId))))
                return reader.GetString(0);
        }

        public string ProductCodeByName(string productName)
        {
            using (var reader = doQuery.Start(SqlQueries.ProductCodeByName(productName)))
                return reader.GetString(0);
        }
        public long ProductKeyByName(string productName)
        {
            using (var reader = doQuery.Start(SqlQueries.ProductKeyByProductName(productName)))
                return reader.GetLong(0);
        }
        public List<long> ClientsIdies()
        {
            using (var reader = doQuery.Start(SqlQueries.ClientsIdies()))
                return reader.GetListOfLong(0);
        }
        public decimal Discount(string clientId)
        {
            using (var reader = doQuery.Start(SqlQueries.Discount(clientId)))
                return reader.GetDecimal(0);
        }
        public string ClientsNameByID(string id)
        {
            using (var reader = doQuery.Start(SqlQueries.ClientsNameByID(id)))
                return reader.GetString(0);
        }
        public List<string> Codes()
        {
            using (var reader = doQuery.Start(SqlQueries.Codes()))
                return reader.GetListOfString(0);
        }
        public void SaveProductsSoldCount(List<OutputProduct> products)
        {
            foreach (var p in products)
                doQuery.Start(SqlQueries.SaveProductsSoldCount(p));
        }
        public void SaveOutputInvoice(OutputInvoice invoice, List<OutputProduct> products)
        {
            doQuery.Start(SqlQueries.SaveIntoSales(invoice));
            foreach (var p in products)
                doQuery.Start(SqlQueries.SaveIntoSaleProducts(invoice, p));
        }
    }
}
