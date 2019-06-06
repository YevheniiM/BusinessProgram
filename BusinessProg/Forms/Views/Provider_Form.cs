using BusinessProg.DataBase;
using BusinessProg.DataBase.DataBaseOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessProg.Forms.Views
{
    public partial class Provider_Form : Form
    {
        InputInvoiceQueries _queries;

        public Provider_Form(CConnection connection)
        {
            InitializeComponent();
            _queries = new InputInvoiceQueries(connection);
        }

        private void Provider_Form_Load(object sender, EventArgs e)
        {
            var info = _queries.ProvidersInfo();
            var columnsNumber = info[0].Count;
            for (int i = 0; i < columnsNumber; ++i)
            {
                DGV_Providers.Rows.Add(info[0][i], info[1][i], info[2][i]);
            }
        }

        private void BUT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BUT_Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
