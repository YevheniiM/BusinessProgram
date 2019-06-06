using BusinessProg.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessProg.Forms.Views;
using System.IO;

namespace BusinessProg.Forms.Information
{
    public partial class MainInformation_Form : Form
    {
        private CConnection _connection;
        public MainInformation_Form(CConnection connection)
        {
            InitializeComponent();
            _connection = connection;
        }

        private void MainInformation_Form_Load(object sender, EventArgs e)
        {
            using (var tw = new StreamWriter("user_data.txt", true))
            {
                tw.WriteLine("Main information form opened [" + DateTime.Now.ToString("yyyy/MM/dd, HH:mm:ss") + "]");
            }
        }

        private void BUT_AddClient_Click(object sender, EventArgs e)
        {
            AddClient_Form form = new AddClient_Form(_connection);
            form.ShowDialog();
        }

        private void BUT_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BUT_ClientsInfo_Click(object sender, EventArgs e)
        {
            Clients_Form form = new Clients_Form(_connection);
            using (var tw = new StreamWriter("user_data.txt", true))
            {
                tw.WriteLine("Clients info opened [" + DateTime.Now.ToString("yyyy/MM/dd, HH:mm:ss") + "]");
            }
            form.ShowDialog();
        }

        private void BUT_Products_Click(object sender, EventArgs e)
        {
            Products_Form form = new Products_Form(_connection);
            using (var tw = new StreamWriter("user_data.txt", true))
            {
                tw.WriteLine("Products info opened [" + DateTime.Now.ToString("yyyy/MM/dd, HH:mm:ss") + "]");
            }
            form.ShowDialog();
        }

        private void BUT_ProvidersInfo_Click(object sender, EventArgs e)
        {
            Provider_Form form = new Provider_Form(_connection);
            using (var tw = new StreamWriter("user_data.txt", true))
            {
                tw.WriteLine("Providers info opened [" + DateTime.Now.ToString("yyyy/MM/dd, HH:mm:ss") + "]");
            }
            form.ShowDialog();
        }

        private void AddProvider_BUT_Click(object sender, EventArgs e)
        {
            AddProvider_Form form = new AddProvider_Form(_connection);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoggedInformation_Form form = new LoggedInformation_Form();
            form.ShowDialog();
        }
    }
}
