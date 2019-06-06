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
    public partial class Products_Form : Form
    {
        InputInvoiceQueries _queries;
        public Products_Form(CConnection connection)
        {
            InitializeComponent();
            _queries = new InputInvoiceQueries(connection);
        }

        private void BUT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGV_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InputeInvoice_Form_Load(object sender, EventArgs e)
        {
            var info = _queries.ProductsInfo();
            var columnsNumber = info[0].Count;
            for (int i = 0; i < columnsNumber; ++i)
            {
                DGV_Products.Rows.Add(info[0][i], info[1][i]);
            }
        }
    }
}
