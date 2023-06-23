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
    public partial class Admin_Sign_up : Form
    {
        static string sql = "Data Source = DESKTOP-8NFTQ6J\\FATMA; Initial Catalog = FlightReservation ;Integrated Security=True";

        SqlConnection con = new SqlConnection(sql);

        public Admin_Sign_up()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            con.Open();

            String query = "Insert into dbo.ADMIN (NAME, EMAIL , PASSWORD, PHONENUMBER) Values (@NAME, @EMAIL , @PASSWORD, @PHONENUMBER)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@NAME", txtName.Text);
            cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
            cmd.Parameters.AddWithValue("@PASSWORD", txtPassword.Text);
            cmd.Parameters.AddWithValue("@PHONENUMBER", txtPhone.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Admin is Signed up successfully!!!!");

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Admin_login aLogin = new Admin_login();
            aLogin.Show();
            this.Close();

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
