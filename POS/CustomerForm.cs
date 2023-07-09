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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.;Initial Catalog=POSDB;Integrated Security=True";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();


                string query = "SELECT * FROM Customer";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();

                    // Fill the DataSet with the data from the query
                    adapter.Fill(dataSet, "Customer");

                    // Bind the DataSet to the DataGridView
                    customertable.DataSource = dataSet.Tables["Customer"];
                }
            }

        }
    }
}
