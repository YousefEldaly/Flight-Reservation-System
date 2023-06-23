using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//using WinFormsApp1;
using FlightReservation;

namespace FlightReservation
{


    public partial class WelcomeAdmin : Form
    {

        int adminID;
        public WelcomeAdmin(int adminID)
        {
            InitializeComponent();
            this.adminID = adminID;
        }

        static string conString = "Data Source =DESKTOP-8NFTQ6J\\FATMA; Initial Catalog = FlightReservation ;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);

        private void WelcomeAdmin_Load(object sender, EventArgs e)
        {

            con.Open();

            //counting customers
            string query1 = "Select Count(*) From CUSTOMER";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            var count1 = cmd1.ExecuteScalar();
            numCustomers.Text = count1.ToString();

            //counting tickets
            string query2 = "Select Count(*) From TICKET";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            var count2 = cmd2.ExecuteScalar();
            numTickets.Text = count2.ToString();

            //counting flights
            string query3 = "Select Count(*) From FLIGHT";
            SqlCommand cmd3 = new SqlCommand(query3, con);
            var count3 = cmd3.ExecuteScalar();
            numFlights.Text = count3.ToString();

            //counting aircrafts
            string query4 = "Select Count(*) From AIRCRAFT";
            SqlCommand cmd4 = new SqlCommand(query4, con);
            var count4 = cmd4.ExecuteScalar();
            numAircrafts.Text = count4.ToString();

            con.Close();

        }




        //GUI
        private void button1_Click_1(object sender, EventArgs e)
        {
            AddFlights addFlights = new AddFlights(adminID);

            this.Close();
            addFlights.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddAircrafts addAircraft = new AddAircrafts(adminID);
            this.Close();
            addAircraft.Show();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Gate page = new Gate();
            this.Close();
            page.Show();
            //return to the signup page
        }
    }
}