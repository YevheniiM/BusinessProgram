using BusinessProg.DataBase.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProg.DataBase.DataBaseOperations
{
    public class CheckData
    {
        CConnection connection { get; set; }
        DoQuery doQuery;
        public CheckData(CConnection con)
        {
            connection = con;
            doQuery = new DoQuery(connection);
        }
        public CheckData()
        {
            connection = new CConnection();
            doQuery = new DoQuery(connection);
        }
        public bool isUserDataCorrect(string login, string password)
        {
            bool isDataCorrect = false;
            string _password = String.Empty;
            try
            {
                using (var reader = doQuery.Start(SqlQueries.PasswordByLogin(login)))
                    _password = reader.GetString(0);
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message);
                return isDataCorrect;
            }

            if (_password == password)
                isDataCorrect = true;

            return isDataCorrect;
        }
    }
}
