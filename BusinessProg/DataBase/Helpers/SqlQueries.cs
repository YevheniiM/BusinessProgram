using BusinessProg.DataBase.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProg.DataBase.Helpers
{
    public static class SqlQueries
    {
        public static CQueryDef InputInvoiceNumber() {
            var sql = "SELECT MAX(Purchase_Key) FROM [ProviderOffers]";
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader); 
        }

        public static CQueryDef ProductKeyByProductName(string Name) {
            var sql = string.Format("SELECT Product_Key FROM [Products] WHERE Product_Name = N'{0}'", Name);
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef Providers() {
            var sql = "SELECT Name FROM[Providers]";
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef ClientsPhones()
        {
            var sql = "SELECT PhoneNumber FROM[Clients]";
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef ClientsDiscount()
        {
            var sql = "SELECT Discount FROM[Clients]";
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }
        //----
        public static CQueryDef ProductsCodes()
        {
            var sql = "SELECT Code FROM[Products]";
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef ProductsNames()
        {
            var sql = "SELECT Product_Name FROM[Products]";
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef ProductsBought()
        {
            var sql = "SELECT Products_Bought FROM[Products]";
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef ProductsSold()
        {
            var sql = "SELECT Products_Sold FROM[Products]";
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef ProductsCategory()
        {
            var sql = "SELECT Category_ID FROM[Products]";
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef ProductsProvider()
        {
            var sql = "SELECT Provider_ID FROM[Products]";
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef ProductsPrice()
        {
            var sql = "SELECT Price FROM[Products]";
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        //----

        public static CQueryDef ClientsExtraData()
        {
            var sql = "SELECT ExtraData FROM[Clients]";
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef Products() {
            var sql = "SELECT Product_Name FROM [Products]";
             return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader); 
        }

        public static CQueryDef Codes() {
            var sql = "SELECT Code FROM [Products]";
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef ProviderIdByName(string Name) {
            var sql = string.Format("SELECT Id FROM [Providers] WHERE Name = N'{0}'", Name);
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef PasswordByLogin(string Login)
        {
            var sql = string.Format("SELECT Password FROM [Users] WHERE Login = N'{0}'", Login);
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef ProductsByProviderId(long Id)
        {
            var sql = string.Format("SELECT Product_Name FROM [Products] WHERE Provider_ID = {0}", Id);
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        internal static CQueryDef ClientPhoneById(long clientId)
        {
            var sql = string.Format("SELECT PhoneNumber FROM [Clients] WHERE Id = '{0}'", clientId);
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef CodesByProvider(long Id)
        {
            var sql = string.Format("SELECT Code FROM [Products] WHERE Provider_ID = {0}", Id);
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef ProductNameByCode(string Code)
        {
            var sql = string.Format("SELECT Product_Name FROM [Products] WHERE Code = N'{0}'", Code);
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef ProductCodeByName(string Name)
        {
            var sql = string.Format("SELECT Code FROM [Products] WHERE Product_Name = N'{0}'", Name);
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef GetPriceByProductName(string Name)
        {
            var sql = string.Format("SELECT Price FROM [Products] WHERE Product_Name = N'{0}'", Name);
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef SaveIntoProviderOffers(InputInvoice Invoice)
        {
            var sql = string.Format( @"INSERT INTO [ProviderOffers](Date, Provider_Id) VALUES ('{0}', '{1}')", Invoice._date, Invoice._provider_Id);
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteNonQuery);
        }

        public static CQueryDef SaveProductsBoughtCount(InputProduct Product)
        {
            var sql = string.Format(@"UPDATE [Products] SET Products_Bought = Products_Bought + {0} WHERE Product_Key = {1}", 
                Product.Count, Product.Product_Key);
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteNonQuery);
        }

        public static CQueryDef SaveIntoProviderOffersProducts(InputInvoice Invoice, InputProduct Product)
        {
            var sql = string.Format(@"INSERT INTO [ProviderOffers_Products](Product_Key, Count, Price, Purchase_Key) VALUES('{0}', '{1}', '{2}', '{3}')",
                        Product.Product_Key, Product.Count, Product.Price, Invoice._purchaseKey);
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteNonQuery);
        }

        public static CQueryDef OutputInvoiceNumber()
        {
            var sql = "SELECT MAX(Sale_Key) FROM [Sales]";
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef ClientsNames()
        {
            var sql = "SELECT Name FROM [Clients]";
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        //----
        public static CQueryDef ProvidersNames()
        {
            var sql = "SELECT Name FROM [Providers]";
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }
        public static CQueryDef ProvidersPhones()
        {
            var sql = "SELECT Phone FROM [Providers]";
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }
        public static CQueryDef ProvidersExtraData()
        {
            var sql = "SELECT ExtraData FROM [Providers]";
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef ClientsIdByName(string Name)
        {
            var sql = string.Format("SELECT Id FROM [Clients] WHERE Name = N'{0}'", Name);
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef ClientsIdies()
        {
            var sql = "SELECT Id FROM [Clients]";
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef Discount(string Id)
        {
            var sql = string.Format("SELECT Discount FROM [Clients] WHERE Id = N'{0}'", Id);
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef ClientsNameByID(string Id)
        {
            var sql = string.Format("SELECT Name FROM [Clients] WHERE Id = {0}", Id);
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }


        public static CQueryDef SaveIntoSales(OutputInvoice Invoice)
        {
            var sql = string.Format(@"INSERT INTO Sales(Date_of_Sale, Client_Id) VALUES ('{0}', '{1}')", Invoice.Date, Invoice.Client_Id);
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteNonQuery);
        }

        public static CQueryDef SaveProductsSoldCount(OutputProduct Product)
        {
            var sql = string.Format(@"UPDATE [Products] SET Products_Sold = Products_Sold + {0} WHERE Product_Key = {1}",
                Product.Count, Product.Product_Key);
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteNonQuery);
        }

        public static CQueryDef SaveIntoSaleProducts(OutputInvoice Invoice, OutputProduct Product)
        {
            var sql = string.Format(@"INSERT INTO Sale_Products(Product_Key, Count, Price, Sale_Key) VALUES('{0}', '{1}', '{2}', '{3}')",
                        Product.Product_Key, Product.Count, Product.Price, Invoice.SaleKey);
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteNonQuery);
        }

        public static CQueryDef AddProduct(string Name, string PhoneNumber, decimal Discount, string ExtraData)
        {
            var sql = string.Format(@"INSERT INTO Clients(Name, PhoneNumber, Discount, ExtraData) VALUES(N'{0}', '{1}', '{2}', N'{3}')",
                Name, PhoneNumber, Discount, ExtraData);
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteNonQuery);
        }

        public static CQueryDef DelClient(long Id)
        {
            var sql = string.Format(@"DELETE FROM [Clients] WHERE Id = {0}", Id);
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteNonQuery);
        }

        //---------
        public static CQueryDef Clients()
        {
            var sql = "SELECT * FROM [Clients]";
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteReader);
        }

        public static CQueryDef SaveProvider(string Name, string PhoneNumber, string ExtraData)
        {
            var sql = string.Format(@"INSERT INTO Providers(Name, Phone, ExtraData) VALUES(N'{0}', '{1}', '{2}')",
                Name, PhoneNumber, ExtraData);
            return new CQueryDef(sql, CSqlReader.SqlStorage.ExecuteNonQuery);
        }
    }
}