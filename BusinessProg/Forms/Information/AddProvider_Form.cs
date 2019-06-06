using BusinessProg.DataBase;
using BusinessProg.DataBase.DataBaseOperations;
using BusinessProg.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessProg.Forms.Information
{
    public partial class AddProvider_Form : Form
    {
        private CConnection _connection;
        private ClientQueries _queries;

        public AddProvider_Form(CConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            _queries = new ClientQueries(_connection);
        }

        private void AddProvider_Form_Load(object sender, EventArgs e)
        {

        }

        private void BUT_Save_Click(object sender, EventArgs e)
        {
            if (CValidate.Validate(TB_Name.Text != String.Empty &&
               TB_PhoneNumber.Text != String.Empty &&
               TB_ExtraData.Text != String.Empty))
            {
                _queries.AddProvider(TB_Name.Text, TB_PhoneNumber.Text, TB_ExtraData.Text);
                this.Close();
            }
            using (var tw = new StreamWriter("user_data.txt", true))
            {
                tw.WriteLine("Provider added [" + DateTime.Now.ToString("yyyy/MM/dd, HH:mm:ss") + "]");
            }
        }
    }
}
