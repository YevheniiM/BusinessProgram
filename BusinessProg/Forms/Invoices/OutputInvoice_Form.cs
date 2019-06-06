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
    public partial class OutputInvoice_Form : Form
    {
        private CConnection _connection;
        private List<OutputProduct> outputProducts { get; set; }
        private OutputInvoiceQueries _queries;

        public OutputInvoice_Form(CConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            outputProducts = new List<OutputProduct>();
            _queries = new OutputInvoiceQueries(_connection);
        }

        private void OutputInvoice_Form_Load(object sender, EventArgs e)
        {
            FillClientsNames_CB();
            FillClientsIdies_CB();
            FillCodes_CB();
            FillProducts_CB();
        }
        private void FillClientsNames_CB()
        {
            if (_queries.ClientsNames() != null)
                foreach (var clientName in _queries.ClientsNames())
                    CB_Client.Items.Add(clientName);
        }

        private void FillClientsIdies_CB()
        {
            foreach (var clientId in _queries.ClientsIdies())
                CB_ClientKey.Items.Add(clientId);
        }

        private void FillClientsIDByName_CB()
        {
            string clientID = _queries.ClientsIdByName(CB_Client.SelectedItem.ToString()).ToString();
            CB_ClientKey.Text = clientID;
        }

        private void FillClientsNameByID_CB()
        {
            String phone = _queries.ClientPhoneById(CB_ClientKey.SelectedItem.ToString());
            if (phone.Length > 0)
                TB_PhoneNumber.Text = phone;
            else
                TB_PhoneNumber.Text = String.Empty;
            CB_Client.Text = _queries.ClientsNameByID(CB_ClientKey.SelectedItem.ToString());
        }

        private void FillCodes_CB()
        {
            foreach (var code in _queries.Codes())
                CB_ProductKey.Items.Add(code);
        }

        private void FillProducts_CB()
        {
            foreach (var name in _queries.Products())
                CB_ProductName.Items.Add(name);
        }
        private void FillPrice_TB()
        {
            if (CB_ProductName.Text != String.Empty)
                TB_Price.Text = _queries.PriceByProductName(CB_ProductName.Text).ToString();
        }
        private void FillCode_ByProductName_CB()
        {
            if (CB_ProductName.Text != String.Empty)
            {
                string code = _queries.ProductCodeByName(CB_ProductName.SelectedItem.ToString());
                CB_ProductKey.Text = code;
            }
        }
        private void FillProduct_ByCode_CB()
        {
            CB_ProductName.Text = _queries.ProductNameByCode(CB_ProductKey.Text);
        }
        private void FillDiscount()
        {
            TB_Discount.Text = _queries.Discount(CB_ClientKey.SelectedItem.ToString()).ToString();
        }
        private void FillPriceWithDiscount()
        {
            if (TB_Price.Text != String.Empty && TB_Discount.Text != String.Empty)
            {
                float price = float.Parse(TB_Price.Text);
                float discount = float.Parse(TB_Discount.Text);
                float _discount = discount / 100;
                float priceWithDiscount = price - price * _discount;
                TB_PriceWithDiscount.Text = priceWithDiscount.ToString();
            }
        }
        private void UpdateForm()
        {
            DTM_SaleProduct.Value = DateTime.Now;
            CB_Client.Text = String.Empty;
            TB_PhoneNumber.Text = String.Empty;
            CB_ClientKey.Text = String.Empty;
            CB_ProductName.Text = String.Empty;
            CB_ProductKey.Text = String.Empty;
            TB_Price.Text = String.Empty;
            TB_Discount.Text = String.Empty;
            TB_PriceWithDiscount.Text = String.Empty;
            NUD_Count.Value = 1;
            LB_Product_List.Items.Clear();
            LB_ProductCount.Items.Clear();
            outputProducts.Clear();
        }

        private void CB_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillClientsIDByName_CB();
            if (CB_ClientKey.Text != null)
                FillDiscount();
            if (CB_ProductKey.Text != String.Empty && CB_ProductName.Text != String.Empty)
                FillPriceWithDiscount();
        }
        private void CB_ClientKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillClientsNameByID_CB();
            if (CB_ClientKey.Text != null)
                FillDiscount();
            if (CB_ProductKey.Text != String.Empty && CB_ProductName.Text != String.Empty)
                FillPriceWithDiscount();
        }
        private void CB_ProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCode_ByProductName_CB();
            FillPrice_TB();
            FillPriceWithDiscount();
        }
        private void CB_ProductKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillProduct_ByCode_CB();
        }
        private void LB_Product_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            LB_ProductCount.SelectedIndex = LB_Product_List.SelectedIndex;
        }

        private void BUT_Save_Click(object sender, EventArgs e)
        {
            if (CValidate.Validate(CB_Client.Text != String.Empty &&
               CB_ClientKey.Text != String.Empty &&
               LB_Product_List.Items.Count > 0))
            {
                OutputInvoiceGeneral_Form form = new OutputInvoiceGeneral_Form(outputProducts, _queries);
                form.ShowDialog();
                UpdateForm();
            }
        }
        private void BUT_AddProduct_Click(object sender, EventArgs e)
        {
            if (CValidate.Validate(CB_Client.Text != String.Empty &&
               CB_ClientKey.Text != String.Empty &&
               CB_ProductName.Text != String.Empty &&
               CB_ProductKey.Text != String.Empty &&
               TB_Price.Text != String.Empty &&
               TB_Discount.Text != String.Empty &&
               TB_PriceWithDiscount.Text != String.Empty &&
               NUD_Count.Value >= 1))
            {
                var clientID = _queries.ClientsIdByName(CB_Client.Text);
                var productKey = _queries.ProductKeyByName(CB_ProductName.Text);

                OutputProduct outputProduct = new OutputProduct(
                    DTM_SaleProduct.Value,
                    CB_Client.Text,
                    clientID,
                    CB_ProductKey.Text,
                    CB_ProductName.Text,
                    decimal.Parse(TB_PriceWithDiscount.Text),
                    long.Parse(NUD_Count.Value.ToString()),
                    productKey);

                outputProducts.Add(outputProduct);
                LB_Product_List.Items.Add(outputProduct.Name);
                LB_ProductCount.Items.Add(outputProduct.Count);

                CB_ProductName.Text = String.Empty;
                CB_ProductKey.Text = String.Empty;
                TB_Price.Text = String.Empty;
                TB_PriceWithDiscount.Text = String.Empty;
                NUD_Count.Value = 1;
            }
        }

        private void BUT_Exit_Click(object sender, EventArgs e)
        {
            using (var tw = new StreamWriter("user_data.txt", true))
            {
                tw.WriteLine("Output invoice added [" + DateTime.Now.ToString("yyyy/MM/dd, HH:mm:ss") + "]");
            }
            this.Close();
        }

        private void update_products()
        {
            LB_Product_List.Items.Clear();
            LB_ProductCount.Items.Clear();
            foreach (var p in outputProducts)
            {
                LB_Product_List.Items.Add(p.Name);
                LB_ProductCount.Items.Add(p.Count);
            }
        }

        private void BUT_Remove_Click(object sender, EventArgs e)
        {
            outputProducts.Remove(outputProducts[LB_Product_List.SelectedIndex]);
            update_products();
        }
    }
}
