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
    public partial class Customer_Sign_up : Form
    {

        static string sql = "Data Source = DESKTOP-8NFTQ6J\\FATMA; Initial Catalog = FlightReservation ;Integrated Security=True";

        SqlConnection con = new SqlConnection(sql);

        public Customer_Sign_up()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {

            DateTime dob = timeDOB.Value;
            int age = CalculateAge(dob);

            con.Open();

            string query = "INSERT INTO dbo.CUSTOMER (NAME, EMAIL, PASSWORD, PHONENUMBER, AGE, GENDER, DOB) VALUES (@NAME, @EMAIL, @PASSWORD, @PHONENUMBER, @AGE, @GENDER, @DOB)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@NAME", txtName.Text);
            cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
            cmd.Parameters.AddWithValue("@PASSWORD", txtPassword.Text);
            cmd.Parameters.AddWithValue("@PHONENUMBER", txtPhone.Text);
            cmd.Parameters.AddWithValue("@AGE", age);
            cmd.Parameters.AddWithValue("@GENDER", comboGender.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@DOB", dob.ToString("yyyy-MM-dd"));


            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Customer is Signed up successfully!!!!  :)");

            Customer_login Clogin = new Customer_login();
            Clogin.Show();
            this.Close();

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            Customer_login Clogin = new Customer_login();
            Clogin.Show();
            this.Close();

        }

        private void timeDOB_ValueChanged(object sender, EventArgs e)
        {

            DateTime dob = timeDOB.Value;
            int age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.DayOfYear < dob.DayOfYear)
            {
                age--;
            }
            if (age <= 18)
            {

                MessageBox.Show("pls Enter a valid legal DOB");

            }
            else
            {
                txtAge.Text = age.ToString();

            }



        }


        private int CalculateAge(DateTime dob)
        {
            int age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.DayOfYear < dob.DayOfYear)
            {
                age--;
            }

            return age;
        }


    }
}
