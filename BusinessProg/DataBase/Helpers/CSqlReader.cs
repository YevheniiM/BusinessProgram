using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProg.DataBase
{
    public class CSqlReader : IDisposable
    {
        private readonly SqlConnection _con;
        private readonly SqlCommand _cmd;
        private readonly SqlDataReader rdr;
        public enum SqlStorage
        {
            ExecuteNonQuery,
            ExecuteReader
        }

        public CSqlReader(SqlConnection sql, SqlCommand command)
        {
            this._cmd = command;
            this._con = sql;
            rdr = command.ExecuteReader();
        }
        public CSqlReader(SqlConnection sql, SqlCommand command, SqlStorage storage)
        {
            this._cmd = command;
            this._con = sql;
            switch (storage)
            {
                case SqlStorage.ExecuteReader:
                    rdr = command.ExecuteReader();
                    break;
                case SqlStorage.ExecuteNonQuery:
                    command.ExecuteNonQuery();
                    break;
            }
        }

        public void Dispose()
        {
            if (rdr == null)
                return;
            rdr.Close();
            _cmd.Dispose();
            _con.Dispose();
        }
        public bool Read()
        {
            return rdr.Read();
        }
        internal string GetString(int v)
        {
            string str = String.Empty;
            try
            {
                if (rdr == null)
                    return str;
                while (rdr.Read())
                    str = rdr.GetString(v);
                return str;
            }
            catch (Exception)
            {
                return str;
            }
        }
        internal int GetInteger(int v)
        {
            if (rdr == null)
                return -1;
            while (rdr.Read())
                return rdr.GetInt32(v);
            return -1;
        }
        internal long GetLong(int v)
        {
            if (rdr == null)
                return -1;
            while (rdr.Read())
                return rdr.GetInt64(v);
            return -1;
        }
        internal decimal GetDecimal(int v)
        {
            if (rdr == null)
                return -1;
            while (rdr.Read())
                return rdr.GetDecimal(v);
            return -1;
        }
        internal List<string> GetListOfString(int v)
        {
            if (rdr == null)
                return null;

            List<string> list = new List<string>();
            while (rdr.Read())
            {
                try
                {
                    list.Add(rdr.GetString(v));
                }
                catch (Exception)
                {
                    list.Add(String.Empty);
                }
            }
            return list;
        }
        internal List<int> GetListOfInteger(int v)
        {
            if (rdr == null)
                return null;

            List<int> list = new List<int>();
            while (rdr.Read())
                list.Add(rdr.GetInt32(v));
            return list;
        }

        internal List<float> GetListOfFloat(int v)
        {
            if (rdr == null)
                return null;

            List<float> list = new List<float>();
            while (rdr.Read())
                list.Add(rdr.GetFloat(v));
            return list;
        }
        internal List<long> GetListOfLong(int v)
        {
            if (rdr == null)
                return null;

            List<long> list = new List<long>();
            while (rdr.Read())
                list.Add(rdr.GetInt64(v));
            return list;
        }
    }
}

