using System.Text;
using System.Xml.Linq;
using System.Text.RegularExpressions;

using System.Data.SqlClient;





namespace WinFormsTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email;
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            string contact;
        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string contact = txtContact.Text;

            string connectionString = @"Data Source=.;Initial Catalog=info;Integrated Security=True";

            string insertQuery = "INSERT INTO info_table (Name, Email, Contact) VALUES (@Name, @Email, @Contact)";
            string validationQuery = "SELECT COUNT(Email) AS EmailCount FROM info_table WHERE Email = @Email";

            // Email validation pattern
            string emailPattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
            if (validationQuery != "1")
            {
                MessageBox.Show("Dublicate email or null" );
            }
            else
            {
                try
                {
                    // Validate email format
                    if (!Regex.IsMatch(email, emailPattern))
                    {
                        MessageBox.Show("Invalid email format");
                        return;
                    }

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Check if email already exists
                        using (SqlCommand validationCommand = new SqlCommand(validationQuery, connection))
                        {
                            validationCommand.Parameters.AddWithValue("@Email", email);

                            int emailCount = (int)validationCommand.ExecuteScalar();

                            if (emailCount > 0)
                            {
                                MessageBox.Show("Duplicate email found");
                                return;
                            }
                        }

                        // Insert new record
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@Name", name);
                            insertCommand.Parameters.AddWithValue("@Email", email);
                            insertCommand.Parameters.AddWithValue("@Contact", contact);

                            int rowsAffected = insertCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Data could not be saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string email = textSearch.Text;
            string connectionString = @"Data Source=.;Initial Catalog=info;Integrated Security=True";


            string searchQuery = "SELECT Email FROM info_table WHERE Email=@email";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(searchQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Email Found", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Email not found");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}

