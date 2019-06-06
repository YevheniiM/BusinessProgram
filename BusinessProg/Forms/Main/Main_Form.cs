using BusinessProg.DataBase;
using BusinessProg.Forms.Information;
using BusinessProg.Forms.Invoices;
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

namespace BusinessProg.Forms.Main
{
    public partial class Main_Form : Form
    {
        private CConnection _connection;
        bool flag = true;
        int input_invoices = 0, output_invoices = 0, information = 0;

        public Main_Form(CConnection connection)
        {
            InitializeComponent();
            _connection = connection;
        }

        private void BUT_Posting_Product_Click(object sender, EventArgs e)
        {
            input_invoices++;
            InputInvoice_Form form = new InputInvoice_Form(_connection);
            form.ShowDialog();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            using (var tw = new StreamWriter("user_data.txt", true))
            {
                tw.WriteLine("Application run [" + DateTime.Now.ToString("yyyy/MM/dd, HH:mm:ss") + "]");
            }
        }

        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BUT_Selling_Click(object sender, EventArgs e)
        {
            output_invoices++;
            OutputInvoice_Form form = new OutputInvoice_Form(_connection);
            using (var tw = new StreamWriter("user_data.txt", true))
            {
                tw.WriteLine("Output invoice window opened [" + DateTime.Now.ToString("yyyy/MM/dd, HH:mm:ss") + "]");
            }
            form.ShowDialog();
        }

        private void BUT_AddInformation_Click(object sender, EventArgs e)
        {
            information++;
            MainInformation_Form form = new MainInformation_Form(_connection);
            using (var tw = new StreamWriter("user_data.txt", true))
            {
                tw.WriteLine("Information window opened [" + DateTime.Now.ToString("yyyy/MM/dd, HH:mm:ss") + "]");
            }
            form.ShowDialog();
        }

        private void BUT_Exit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tw = new StreamWriter("user_data.txt", true))
                {
                    tw.WriteLine("Application exited [" + DateTime.Now.ToString("yyyy/MM/dd, HH:mm:ss") + "]");
                }
                Application.Exit();
            }
            catch (Exception)
            {

            }
        }
    }
}
