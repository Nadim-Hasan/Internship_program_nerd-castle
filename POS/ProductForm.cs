using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            string name = ProductNameTxt.Text;
            string price = ProductPriceTxt.Text;
            double vat = Convert.ToDouble(ProductVatTxt.Text);
            bool discountAllow = ;
            int categoryID;
            string description;
            string createdBy;
            DateTime createdDate;
            string updatedBy;

            DateTime updatedDate;
            bool isdelete;

        }
    }
}
