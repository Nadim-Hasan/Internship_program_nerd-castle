using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            string name = CatNameTxt.Text;
            string description = CatDescriptionTxt.Text;
            bool isDeleted = IsDeletedchek.Checked;
            string createdBy = CatCreatedByTxt.Text;
            DateTime createdDate = CatCreatedDate.Value;
            string updatedBy = CatUpdatedByTxt.Text;
            DateTime updatedDate = CatUpdatedDate.Value;
            string connectionString = @"Data Source=.;Initial Catalog=POSDB;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO Category (Name, Description, IsDeleted, CreatedBy, CreatedDate, UpdatedBy, UpdatedDate) " +
                        "VALUES (@Name, @Description, @IsDeleted, @CreatedBy, @CreatedDate, @UpdatedBy, @UpdatedDate)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@IsDeleted", isDeleted);
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
        private void button2_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StockForm stockForm = new StockForm();
            stockForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SalesSummaryForm salesSummaryForm = new SalesSummaryForm();
            salesSummaryForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SalesDetailsForm salesDetailsForm = new SalesDetailsForm();
            salesDetailsForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.;Initial Catalog=POSDB;Integrated Security=True";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();


                string query = "SELECT * FROM Category";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();

                    // Fill the DataSet with the data from the query
                    adapter.Fill(dataSet, "Category");

                    // Bind the DataSet to the DataGridView
                    CategoryDatatbl.DataSource = dataSet.Tables["Category"];
                }
            }

        }
    }
}
