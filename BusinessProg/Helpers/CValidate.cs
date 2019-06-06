using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessProg.Helpers
{
    public static class CValidate
    {
        public static bool Validate(bool res)
        {
            if (!res)
                MessageBox.Show("The data is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return res;
        }
    }
}
