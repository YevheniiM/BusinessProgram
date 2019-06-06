using BusinessProg.DataBase.DataBaseOperations;
using BusinessProg.DataBase.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessProg.Forms.Invoices
{
    public partial class OutputInvoiceGeneral_Form : Form
    {
        private int _fullCount;
        private int _fullPrice;
        private OutputInvoice _invoice;
        private OutputInvoiceQueries _queries;
        private List<OutputProduct> _products { get; set; }
        public OutputInvoiceGeneral_Form(List<OutputProduct> products, OutputInvoiceQueries queries)
        {
            InitializeComponent();
            _queries = queries;
            _products = products;
        }

        private void OutputInvoiceGeneral_Form_Load(object sender, EventArgs e)
        {
            foreach (var p in _products)
                DGV_Products.Rows.Add(p.Name, p.Code, p.Price, p.Count);
            TB_InvoiceNumber.Text = (_queries.NewOutputInvoiceNumber()+1).ToString();
            FillFullCount_NB();
            FillFullPrice_NB();
        }
        private void FillFullCount_NB()
        {
            _fullCount = 0;
            for (int i = 0; i < DGV_Products.Rows.Count; i++)
            {
                int c = Convert.ToInt32(DGV_Products.Rows[i].Cells[3].Value);
                _fullCount = _fullCount + c;
            }
            TB_ProductsCount.Text = _fullCount.ToString();
        }
        private void FillFullPrice_NB()
        {
            _fullPrice = 0;
            for (int i = 0; i < DGV_Products.Rows.Count; i++)
            {
                int price = Convert.ToInt32(DGV_Products.Rows[i].Cells[2].Value);
                int count = Convert.ToInt32(DGV_Products.Rows[i].Cells[3].Value);
                _fullPrice = _fullPrice + price * count;
            }
            TB_FullSum.Text = _fullPrice.ToString();
        }

        private void BUT_Save_Click(object sender, EventArgs e)
        {
            _invoice = new OutputInvoice(Convert.ToInt32(TB_InvoiceNumber.Text), _products[0].Date, _products[0].ClientId);
            _queries.SaveOutputInvoice(_invoice, _products);
            _queries.SaveProductsSoldCount(_products);
            this.Close();
        }
    }
}
