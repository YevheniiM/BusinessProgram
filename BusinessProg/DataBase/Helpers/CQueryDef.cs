using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProg.DataBase.Helpers
{
    public class CQueryDef
    {
        public string _sqlCommand {
            get; private set;
        }
        public CSqlReader.SqlStorage _type {
            get; private set;
        }

        public CQueryDef(string command, CSqlReader.SqlStorage type)
        {
            _sqlCommand = command;
            _type = type;
        }
    }
}
