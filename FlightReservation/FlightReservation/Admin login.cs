//using Flight_Reservation_System;
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
using FlightReservation;
//using WinFormsApp1;

namespace FlightReservation
{
    public partial class Admin_login : Form
    {
        static string sql = "Data Source = DESKTOP-8NFTQ6J\\FATMA; Initial Catalog = FlightReservation ;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(sql);
        public Admin_login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            int admin_id;

            string id_query = "SELECT ADMINID FROM ADMIN " +
                "WHERE [EMAIL] = @email AND [PASSWORD] = @pass ";

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(id_query, sqlConnection);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pass", password);

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            sqlDataReader.Read();
            admin_id = sqlDataReader.GetInt32(0);

            sqlDataReader.Close();
            sqlConnection.Close();


            if (IsValidCredentials(email, password))
            {
                /*AddFlights passID=new AddFlights(admin_id);
                AddAircrafts passID2 = new AddAircrafts(admin_id);*/
                MessageBox.Show("Admin Login successful!");
                WelcomeAdmin page = new WelcomeAdmin(admin_id);
                page.Show();
                this.Close();
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
                string query = "SELECT COUNT(*) FROM dbo.ADMIN WHERE EMAIL = @Email AND PASSWORD = @Password";
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
            Admin_Sign_up adSignup = new Admin_Sign_up();
            adSignup.Show();
            this.Close();
        }

    }

}
