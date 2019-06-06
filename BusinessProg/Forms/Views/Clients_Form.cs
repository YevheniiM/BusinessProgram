using BusinessProg.DataBase;
using BusinessProg.DataBase.DataBaseOperations;
using BusinessProg.DataBase.Helpers;
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
    public partial class Clients_Form : Form
    {
        InputInvoiceQueries _queries;

        public Clients_Form(CConnection connection)
        {
            InitializeComponent();
            _queries = new InputInvoiceQueries(connection);
        }

        private void Clients_Form_Load(object sender, EventArgs e)
        {
            var info = _queries.ClientsInfo();
            var columnsNumber = info[0].Count;
            for(int i = 0; i < columnsNumber; ++i)
            {
                DGV_Clients.Rows.Add(info[0][i], info[1][i], info[2][i], info[3][i]);
            }
        }

        private void BUT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
