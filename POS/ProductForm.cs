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
using System.Data.SqlClient;

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

            int ID = Convert.ToInt32(ProductIDtxt.Text);
            string name = ProductNameTxt.Text;
            int price = Convert.ToInt32(ProductPriceTxt.Text);
            double vat = Convert.ToDouble(ProduxtVat.Text);
            bool discountAllow = ProductDiscount.Checked;
            int categoryID = Convert.ToInt32(ProductCetegoryIDTxt.Text);
            string createdBy = ProductCreatedByTxt.Text;
            DateTime createdDate = ProductCreatedDateTxt.Value;
            string updatedBy = ProductUpdatedByTxt.Text;
            DateTime updatedDate = ProductUpdatedDateTxt.Value;
            string connectionString = @"Data Source=.;Initial Catalog=POSDB;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO Product (ID, Name, Price, VATPercent, CategoryID,isDiscountAllow, CreatedBy, CreatedDate, UpdatedBy, UpdatedDate) " +
                        "VALUES (@ID, @Name, @Price, @VAT,@categoryID, @DiscountAllow, @CreatedBy, @CreatedDate, @UpdatedBy, @UpdatedDate)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Price", price);
                        command.Parameters.AddWithValue("@VAT", vat);
                        command.Parameters.AddWithValue("@categoryID", categoryID);
                        command.Parameters.AddWithValue("@DiscountAllow", discountAllow);
                        command.Parameters.AddWithValue("@CreatedBy", createdBy);
                        command.Parameters.AddWithValue("@CreatedDate", createdDate);
                        command.Parameters.AddWithValue("@UpdatedBy", updatedBy);
                        command.Parameters.AddWithValue("@UpdatedDate", updatedDate);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProductPriceTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductIDtxt_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(ProductIDtxt.Text, out int ID))
            {
                // The input is a valid integer
                // Use the 'ID' variable as needed
            }
            else
            {
                // The input is not a valid integer
                // You can display an error message or perform appropriate error handling
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerForm cus = new CustomerForm();
            cus.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StockForm stck = new StockForm();
            stck.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SalesSummaryForm salesSummary = new SalesSummaryForm();
            salesSummary.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SalesDetailsForm salesDetails = new SalesDetailsForm();
            salesDetails.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             int ID;
    if (!int.TryParse(ProductIDtxt.Text, out ID))
    {
        MessageBox.Show("Invalid product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    string name = ProductNameTxt.Text;
    int price = Convert.ToInt32(ProductPriceTxt.Text);
    double vat = Convert.ToDouble(ProduxtVat.Text);
    bool discountAllow = ProductDiscount.Checked;
    int categoryID = Convert.ToInt32(ProductCetegoryIDTxt.Text);
    string createdBy = ProductCreatedByTxt.Text;
    DateTime createdDate = ProductCreatedDateTxt.Value;
    string updatedBy = ProductUpdatedByTxt.Text;
    DateTime updatedDate = ProductUpdatedDateTxt.Value;

    string connectionString = @"Data Source=.;Initial Catalog=POSDB;Integrated Security=True";

    try
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string selectQuery = "SELECT COUNT(*) FROM Product WHERE ID = @ID";

            using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
            {
                selectCommand.Parameters.AddWithValue("@ID", ID);

                int count = (int)selectCommand.ExecuteScalar();

                if (count == 0)
                {
                    MessageBox.Show("Product ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string updateQuery = "UPDATE Product SET Name = @Name, Price = @Price, VATPercent = @VAT, " +
                                 "CategoryID = @CategoryID, isDiscountAllow = @DiscountAllow, CreatedBy = @CreatedBy, " +
                                 "CreatedDate = @CreatedDate, UpdatedBy = @UpdatedBy, UpdatedDate = @UpdatedDate " +
                                 "WHERE ID = @ID";

            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
            {
                updateCommand.Parameters.AddWithValue("@Name", name);
                updateCommand.Parameters.AddWithValue("@Price", price);
                updateCommand.Parameters.AddWithValue("@VAT", vat);
                updateCommand.Parameters.AddWithValue("@CategoryID", categoryID);
                updateCommand.Parameters.AddWithValue("@DiscountAllow", discountAllow);
                updateCommand.Parameters.AddWithValue("@CreatedBy", createdBy);
                updateCommand.Parameters.AddWithValue("@CreatedDate", createdDate);
                updateCommand.Parameters.AddWithValue("@UpdatedBy", updatedBy);
                updateCommand.Parameters.AddWithValue("@UpdatedDate", updatedDate);
                updateCommand.Parameters.AddWithValue("@ID", ID);

                int rowsAffected = updateCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error updating product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productshwBtn_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.;Initial Catalog=POSDB;Integrated Security=True";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();


                string query = "SELECT * FROM Product";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();

                    // Fill the DataSet with the data from the query
                    adapter.Fill(dataSet, "Product");

                    // Bind the DataSet to the DataGridView
                    ProductDataTable.DataSource = dataSet.Tables["Product"];
                }
            }


        }
    }
}
