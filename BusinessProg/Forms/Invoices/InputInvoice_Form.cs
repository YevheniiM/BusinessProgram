using BusinessProg.DataBase;
using BusinessProg.DataBase.DataBaseOperations;
using BusinessProg.DataBase.Objects;
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

namespace BusinessProg.Forms.Invoices
{
    public partial class InputInvoice_Form : Form
    {
        public List<InputProduct> _inputProducts { get; private set; }
        InputInvoiceQueries _queries;

        public InputInvoice_Form(CConnection connection)
        {
            InitializeComponent();
            _inputProducts = new List<InputProduct>();
            _queries = new InputInvoiceQueries(connection);
        }

        private void InputInvoice_Form_Load(object sender, EventArgs e)
        {
            foreach(var provider in _queries.Providers())
                CB_Provider.Items.Add(provider);
            foreach (var code in _queries.Codes())
                CB_Product_Code.Items.Add(code);
        }
        private void BUT_Add_Product_Click(object sender, EventArgs e)
        {
            if (CValidate.Validate(CB_Provider.Text != String.Empty &&
                CB_Product_Name.Text != String.Empty &&
                CB_Product_Code.Text != String.Empty &&
                TB_Product_Price.Text != String.Empty &&
                NUD_Product_Count.Value >= 1))
            {
                var providerId = _queries.ProviderIdByName(CB_Provider.Text);
                var productKey = _queries.ProductKeyByName(CB_Product_Name.Text);

                InputProduct inputProduct = new InputProduct(
                    DTM_ArrivalProduct.Value,
                    CB_Provider.Text,
                    providerId,
                    CB_Product_Code.Text,
                    CB_Product_Name.Text,
                    float.Parse(TB_Product_Price.Text),
                    NUD_Product_Count.Value,
                    productKey);

                _inputProducts.Add(inputProduct);
                LB_Product_List.Items.Add(inputProduct.Name);
                LB_ProductCount.Items.Add(inputProduct.Count);

                CB_Product_Name.Text = String.Empty;
                CB_Product_Code.Text = String.Empty;
                TB_Product_Price.Text = String.Empty;
                NUD_Product_Count.Value = 1;
            }
        }
        private void BUT_Del_Product_Click(object sender, EventArgs e)
        {
            InputProduct p = _inputProducts.Find(x => x.Name == LB_Product_List.SelectedItem.ToString());
            _inputProducts.Remove(p);
            LB_Product_List.Items.Remove(LB_Product_List.SelectedItem.ToString());
            LB_ProductCount.SelectedIndex = LB_Product_List.SelectedIndex;
            LB_ProductCount.Items.RemoveAt(LB_Product_List.SelectedIndex + 1);
        }
        private void BUT_Save_Click(object sender, EventArgs e)
        {
            if (CValidate.Validate(CB_Provider.Text != String.Empty && LB_Product_List.Items.Count > 0))
            {
                InputInvoiceGeneral_Form form = new InputInvoiceGeneral_Form(_inputProducts, _queries);
                form.ShowDialog();
                UpdateForm();
            }
        }
        private void BUT_Close_Click(object sender, EventArgs e)
        {
            using (var tw = new StreamWriter("user_data.txt", true))
            {
                tw.WriteLine("Input invoice added [" + DateTime.Now.ToString("yyyy/MM/dd, HH:mm:ss") + "]");
            }
            this.Close();
        }
        private void CB_Provider_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_Product_Name.DropDownHeight = 200;
            CB_Product_Code.DropDownHeight = 200;
            CB_Provider.Text = String.Empty;
            CB_Product_Name.Text = String.Empty;
            CB_Product_Code.Text = String.Empty;
            CB_Product_Name.Items.Clear();
            CB_Product_Code.Items.Clear();

            foreach (var p in _queries.CodesByProvider(CB_Provider.SelectedItem.ToString()))
                CB_Product_Code.Items.Add(p);
            foreach (var p in _queries.ProductsNameByProvider(CB_Provider.SelectedItem.ToString()))
                CB_Product_Name.Items.Add(p);
        }
        private void CB_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CValidate.Validate(CB_Product_Name.Text != String.Empty))
                TB_Product_Price.Text = _queries.PriceByProductName(CB_Product_Name.Text).ToString();
            CB_Product_Code.Text = _queries.ProductCodeByName(CB_Product_Name.SelectedItem.ToString());
        }
        private void CB_Product_Code_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CValidate.Validate(CB_Product_Name.Text != String.Empty))
                TB_Product_Price.Text = _queries.PriceByProductName(CB_Product_Name.Text).ToString();
            CB_Product_Name.Text = _queries.ProductNameByCode(CB_Product_Code.SelectedItem.ToString());
        }
        private void LB_Product_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            LB_ProductCount.SelectedIndex = LB_Product_List.SelectedIndex;
        }
        private void UpdateForm()
        {
            DTM_ArrivalProduct.Value = DateTime.Now;
            CB_Provider.Text = String.Empty;
            CB_Product_Name.Text = String.Empty;
            CB_Product_Code.Text = String.Empty;
            TB_Product_Price.Text = String.Empty;
            NUD_Product_Count.Value = 1;
            LB_Product_List.Items.Clear();
            LB_ProductCount.Items.Clear();

            _inputProducts.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
