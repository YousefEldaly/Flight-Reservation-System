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

namespace FlightReservation
{
    public partial class Customer_login : Form
    {

        static string sql = "Data Source = DESKTOP-8NFTQ6J\\FATMA; Initial Catalog = FlightReservation ;Integrated Security=True";

        public Customer_login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            int cust_id;

            string id_query = "SELECT CUSTOMERID FROM CUSTOMER " +
                "WHERE [EMAIL] = @email AND [PASSWORD] = @pass ";
            SqlConnection sqlConnection = new SqlConnection(sql);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(id_query, sqlConnection);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pass", password);

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            sqlDataReader.Read();
            if (!sqlDataReader.HasRows)
            {
                MessageBox.Show("Invalid Email or Password");
                sqlDataReader.Close();
                sqlConnection.Close();
                return;
            }
            cust_id = sqlDataReader.GetInt32(0);

            sqlDataReader.Close();
            sqlConnection.Close();


            if (IsValidCredentials(email, password))
            {
                /* MessageBox.Show("Customer Login successful!"); */
                Flights flights = new Flights(cust_id);
                flights.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.");
            }
        }

        private bool IsValidCredentials(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(sql))
            {
                string query = "SELECT COUNT(*) FROM dbo.CUSTOMER WHERE EMAIL = @Email AND PASSWORD = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return (count > 0);
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Customer_Sign_up Csignup = new Customer_Sign_up();
            Csignup.Show();
            Visible = false;

        }


    }
}

