using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessProg.Forms.Information
{
    public partial class LoggedInformation_Form : Form
    {
        String pattern = "yyyy/MM/dd, HH:mm:ss";

        public LoggedInformation_Form()
        {
            InitializeComponent();
        }

        private void BUT_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoggedInformation_Form_Load(object sender, EventArgs e)
        {
            TotalClients.Text = String.Empty;
            TotalInput.Text = String.Empty;
            TotalOutput.Text = String.Empty;
            TotalProviders.Text = String.Empty;
            update();
        }

        private void update()
        {
            LB_InputInvoices.Items.Clear();
            LB_OutputInvoices.Items.Clear();
            LB_ClientsAdded.Items.Clear();
            LB_ProvidersAdded.Items.Clear();

            String contents = File.ReadAllText(@"user_data.txt");

            Regex runs = new Regex(@"Application run \[(.+)\]", RegexOptions.IgnoreCase);
            Regex input_invoices = new Regex(@"Input invoice added \[(.+)\]", RegexOptions.IgnoreCase);
            Regex output_invoices = new Regex(@"Output invoice added \[(.+)\]", RegexOptions.IgnoreCase);
            Regex info_window = new Regex(@"Information window opened \[(.+)\]", RegexOptions.IgnoreCase);
            Regex clients_info = new Regex(@"Clients info opened \[(.+)\]", RegexOptions.IgnoreCase);
            Regex products_info = new Regex(@"Products info opened \[(.+)\]", RegexOptions.IgnoreCase);
            Regex providers_info = new Regex(@"Providers info opened \[(.+)\]", RegexOptions.IgnoreCase);
            Regex clients_added = new Regex(@"Client added \[(.+)\]", RegexOptions.IgnoreCase);
            Regex providers_added = new Regex(@"Provider added \[(.+)\]", RegexOptions.IgnoreCase);

            MatchCollection matches_runs = runs.Matches(contents);
            MatchCollection matches_input_invoices = input_invoices.Matches(contents);
            MatchCollection matches_output_invoices = output_invoices.Matches(contents);
            MatchCollection matches_info_window = info_window.Matches(contents);
            MatchCollection matches_clients_info = clients_info.Matches(contents);
            MatchCollection matches_products_info = products_info.Matches(contents);
            MatchCollection matches_providers_info = providers_info.Matches(contents);
            MatchCollection matches_clients_added = clients_added.Matches(contents);
            MatchCollection matches_providers_added = providers_added.Matches(contents);

            List<DateTime> input_invoices_dates = add_dates(matches_input_invoices);
            List<DateTime> output_invoices_dates = add_dates(matches_output_invoices);
            List<DateTime> clients_added_dates = add_dates(matches_clients_added);
            List<DateTime> providers_added_dates = add_dates(matches_providers_added);

            add_info(LB_InputInvoices, input_invoices_dates);
            add_info(LB_OutputInvoices, output_invoices_dates);
            add_info(LB_ClientsAdded, clients_added_dates);
            add_info(LB_ProvidersAdded, providers_added_dates);

            TotalClients.Text = LB_ClientsAdded.Items.Count.ToString();
            TotalInput.Text = LB_InputInvoices.Items.Count.ToString();
            TotalOutput.Text = LB_OutputInvoices.Items.Count.ToString();
            TotalProviders.Text = LB_ProvidersAdded.Items.Count.ToString();

            add_average(TB_AverageClients, clients_added_dates, TotalClients);
            add_average(TB_AverageInput, input_invoices_dates, TotalInput);
            add_average(TB_AverageOutput, output_invoices_dates, TotalOutput);
            add_average(TB_AverageProviders, providers_added_dates, TotalProviders);
        }

        private void add_average(TextBox tb, List<DateTime> dates, TextBox total)
        {
            List<DateTime> actual = new List<DateTime>();
            foreach (var d in dates)
            {
                if (d >= From.Value && d <= To.Value)
                {
                    actual.Add(d);
                }
            }
            TimeSpan span = To.Value - From.Value;
            if (HourChecked.Checked)
            {
                double per_hour = (double)actual.Count / span.TotalHours;
                tb.Text = per_hour.ToString();
            }
            else
            {
                double per_day = (double)actual.Count / span.TotalDays;
                tb.Text = per_day.ToString();
            }
        }

        private void add_info(ListBox lb, List<DateTime> dates)
        {
            foreach (var d in dates)
            {
                if (d >= From.Value && d <= To.Value)
                {
                    if(!HourChecked.Checked)
                        lb.Items.Add(d);
                    else
                    {
                        if(d.Hour == Hour.Value)
                        {
                            lb.Items.Add(d);
                        }
                    }
                }
            }
        }

        private List<DateTime> add_dates(MatchCollection matches)
        {
            List<DateTime> res = new List<DateTime>();
            foreach (Match m in matches)
            {
                Regex date = new Regex(@"\[([^\[\]]+)\]", RegexOptions.IgnoreCase);
                MatchCollection match = date.Matches(m.Value);
                if (match.Count > 0)
                {
                    String d = match[0].Value.Replace("[", "").Replace("]", "");
                    DateTime current = DateTime.ParseExact(d, pattern, CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);
                    res.Add(current);
                }
            }
            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update();
        }

        private void HourChecked_CheckedChanged(object sender, EventArgs e)
        {
            update();
            if(HourChecked.Checked)
                label16.Text = "(average per hour is displayed)";
            else
                label16.Text = "(average per day is displayed)";
        }
    }
}
