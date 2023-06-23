using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FlightReservation
{
    public partial class CustomerProfile : Form
    {
        static string sql = "Data Source = DESKTOP-8NFTQ6J\\FATMA; Initial Catalog = FlightReservation ;Integrated Security=True";
        SqlConnection con = new SqlConnection(sql);
        int customerID;
        public CustomerProfile(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
            ShowData();
        }

        private void ShowData()
        {
            string query = "SELECT * FROM CUSTOMER " +
                "WHERE CUSTOMERID = @customerID";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@customerID", customerID);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    // Retrieve data from the reader and assign it to the text boxes
                    txt_cust_name.Text = r["NAME"].ToString();
                    txt_cust_age.Text = r["AGE"].ToString();
                    txt_cust_phone.Text = r["PHONENUMBER"].ToString();
                    txt_cust_id.Text = r["CUSTOMERID"].ToString();
                    txt_cust_email.Text = r["EMAIL"].ToString();
                    txt_cust_password.Text = r["PASSWORD"].ToString();
                    txt_cust_gender.Text = r["GENDER"].ToString();
                }
            }
            r.Close();
            con.Close();
        }
        private void back_view_Click(object sender, EventArgs e)
        {
            Flights f1 = new Flights(customerID);
            f1.Show();
            Visible = false;
        }

        private void btn_update_profile_Click(object sender, EventArgs e)
        {
            string new_name = txt_cust_name.Text;
            string new_email = txt_cust_email.Text;
            string new_pass = txt_cust_password.Text;
            string new_phone = txt_cust_phone.Text;

            string retrieve_query = "SELECT * FROM CUSTOMER " +
                                    "WHERE CUSTOMERID = @customerID";
            con.Open();
            SqlCommand cmd = new SqlCommand(retrieve_query, con);
            cmd.Parameters.AddWithValue("@customerID", customerID);
            SqlDataReader r = cmd.ExecuteReader();
            r.Read();
            if (r["NAME"].ToString() == new_name &&
                r["EMAIL"].ToString() == new_email &&
                r["PHONENUMBER"].ToString() == new_phone &&
                r["PASSWORD"].ToString() == new_pass)
            {
                MessageBox.Show("No info has been added. Please fill in new data.");
                con.Close();
                r.Close();
                return;
            }

            if (IsValidEmail(new_email))
            {
                string query = "UPDATE CUSTOMER " +
                               "SET [NAME] = @name, " +
                               "    [EMAIL] = @email, " +
                               "    [PASSWORD] = @pass, " +
                               "    [PHONENUMBER] = @phone " +
                               "WHERE CUSTOMERID = @customerID";

                SqlCommand cmd2 = new SqlCommand(query, con);
                cmd2.Parameters.AddWithValue("@name", new_name);
                cmd2.Parameters.AddWithValue("@email", new_email);
                cmd2.Parameters.AddWithValue("@pass", new_pass);
                cmd2.Parameters.AddWithValue("@phone", new_phone);
                cmd2.Parameters.AddWithValue("@customerID", customerID);

                r.Close();
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Profile has been updated successfully!");
                ShowData();
            }
            else
            {
                MessageBox.Show("Invalid Email");
                con.Close();
            }
        }


        public bool IsValidEmail(string email)
        {
            // Regular expression pattern for email validation
            string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";

            // Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            // Use the Matches method to check if the email matches the pattern
            Match match = regex.Match(email);

            // Return true if the email matches the pattern, false otherwise
            return match.Success;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tickets t = new Tickets(customerID);
            t.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer_login cl = new Customer_login();
            cl.Show();
            Visible = false;
        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
