using BusinessProg.DataBase;
using BusinessProg.DataBase.DataBaseOperations;
using BusinessProg.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessProg.Forms.Main
{
    public partial class Login_Form : Form
    {
        CheckData check;
        private CConnection conneciton;
        public Login_Form()
        {
            InitializeComponent();

        }
        private void Login_Form_Load(object sender, EventArgs e)
        {
            conneciton = new CConnection();
            check = new CheckData(conneciton);
        }

        private void BUT_Ok_Click(object sender, EventArgs e)
        {
            if (CValidate.Validate(TB_Login.Text != String.Empty && TB_Password.Text != String.Empty))
            {
                if (CValidate.Validate(check.isUserDataCorrect(TB_Login.Text, TB_Password.Text)))
                {
                    this.Hide();
                    Main_Form form = new Main_Form(conneciton);
                    form.ShowDialog();
                }
            }
        }
    }
}
