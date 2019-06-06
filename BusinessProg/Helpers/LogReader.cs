using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessProg.Helpers
{
    class LogReader
    {
        private void read()
        {
            String pattern = "yyyy/MM/dd, hh:mm:ss";
            DateTime current = DateTime.ParseExact("2019/06/01, 08:30:33", pattern, CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);

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
        }
    }
}
