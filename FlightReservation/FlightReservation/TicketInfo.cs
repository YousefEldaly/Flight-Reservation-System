using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FlightReservation
{
    public partial class TicketInfo : Form
    {
        static String sql = "Data Source = DESKTOP-8NFTQ6J\\FATMA; Initial Catalog = FlightReservation ;Integrated Security=True";
        SqlConnection con = new SqlConnection(sql);
        int CustomerID;
        /* call when we get info about specific ticket*/
        public TicketInfo(int ticketID)
        {
            InitializeComponent();
            CustomerID = getCustID(ticketID);
            ShowData(ticketID);
        }

        /* call when reserve new ticket*/
        public TicketInfo(int customerID, int flightID)
        {
            InitializeComponent();
            CustomerID = customerID;
            ShowData(getTicketID(customerID, flightID));
        }

        private int getTicketID(int custID, int flightID)
        {
            string query = "SELECT TICKETID FROM TICKET " +
                           "WHERE CUSTOMERID = @CustomerID " +
                           "AND FLIGHTID = @FlightID";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@CustomerID", custID);
            cmd.Parameters.AddWithValue("@FlightID", flightID);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int ticketID = reader.GetInt32(0);
            reader.Close();
            con.Close();
            return ticketID;
        }

        private void ShowData(int ticketID)
        {
            string query = "SELECT * FROM TICKET " +
                           "FULL JOIN FLIGHT ON FLIGHT.FLIGHTID = TICKET.FLIGHTID " +
                           "Where TICKET.TICKETID = @ticketID";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ticketID", ticketID);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    txt_ticket_id.Text = r["TICKETID"].ToString();
                    txt_flight_id.Text = r["FLIGHTID"].ToString();
                    txt_source.Text = r["SOURCE"].ToString();
                    txt_destination.Text = r["DESTINATION"].ToString();
                    txt_dep_date.Text = r["DEPDATE_TIME"].ToString();
                    txt_arrival_date.Text = r["ARRIVALDATE_TIME"].ToString();
                    comboBox_ClassType.Text = r["CLASSTYPE"].ToString();
                    txt_total_price.Text = r["TOTALPRICE"].ToString() + "$";
                    seatnumBox.Text = r["SEATNUM"].ToString();
                }
            }
            con.Close();

        }
        private void btn_update_class_Click(object sender, EventArgs e)
        {
            string new_class = comboBox_ClassType.SelectedItem.ToString();

            string getOldClass_query = "SELECT CLASSTYPE FROM TICKET " +
                " WHERE TICKETID = @ticketID";
            SqlCommand cmd = new SqlCommand(getOldClass_query, con);
            con.Open();
            cmd.Parameters.AddWithValue("@ticketID", int.Parse(txt_ticket_id.Text));
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string old_classType = reader["CLASSTYPE"].ToString();
            reader.Close();
            con.Close();

            if (old_classType == new_class)
            {
                MessageBox.Show("You have to change the class type!");
                return;
            }

            int ticket_id = int.Parse(txt_ticket_id.Text);
            string query = "UPDATE TICKET " +
                               "SET [CLASSTYPE] = @class ," +
                               "[TOTALPRICE] = @price " +
                               "WHERE TICKETID = @ticketID";
            con.Open();
            SqlCommand cmd2 = new SqlCommand(query, con);
            cmd2.Parameters.AddWithValue("@class", new_class);
            cmd2.Parameters.AddWithValue("@ticketID", ticket_id);
            cmd2.Parameters.AddWithValue("@price", getClassPrice(int.Parse(txt_flight_id.Text), new_class));
            cmd2.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Class has been updated successfully!");
            ShowData(ticket_id);
        }

        private int getClassPrice(int flightID, string classType)
        {
            string query;
            if (classType == "Economy")
            {
                query = "SELECT ECONOMYCPRICE FROM FLIGHT " +
                              "WHERE FLIGHTID = @FlightID";
            }
            else if (classType == "Business")
            {
                query = "SELECT BUSINESSCPRICE FROM FLIGHT " +
                              "WHERE FLIGHTID = @FlightID";
            }
            else
            {
                query = "SELECT FIRSTCPRICE FROM FLIGHT " +
                              "WHERE FLIGHTID = @FlightID";
            }
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@FlightID", flightID);

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int classPrice = reader.GetInt32(0);
            reader.Close();
            return classPrice;
        }



        private void btn_cancel_reserve_Click(object sender, EventArgs e)
        {
            int ticketID = int.Parse(txt_ticket_id.Text);

            string query = "DELETE FROM TICKET " +
                "WHERE TICKETID = @ticketID";
            con.Open();
            SqlCommand cmd2 = new SqlCommand(query, con);
            cmd2.Parameters.AddWithValue("@ticketID", ticketID);
            cmd2.ExecuteNonQuery();

            MessageBox.Show("Reservation has been cancelled :(");


            con.Close();
            Flights f1 = new Flights(CustomerID);
            f1.Show();
            Visible = false;

            /*Tickets tickets = new Tickets(CustomerID);
            tickets.Show();
            Visible = false;*/
        }

        private int getCustID(int ticketID)
        {
            string getCustID_query = "SELECT CUSTOMERID FROM TICKET " +
                " WHERE TICKETID = @ticketID";
            SqlCommand cmd = new SqlCommand(getCustID_query, con);
            con.Open();
            cmd.Parameters.AddWithValue("@ticketID", ticketID);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int cust_id = reader.GetInt32(0);
            reader.Close();
            con.Close();
            return cust_id;
        }

        private void btn_back_flights_Click(object sender, EventArgs e)
        {
            Flights f1 = new Flights(CustomerID);
            f1.Show();
            Visible = false;
        }

        private void btn_show_profile_Click(object sender, EventArgs e)
        {
            CustomerProfile f1 = new CustomerProfile(CustomerID);
            f1.Show();
            Visible = false;
        }

        private void btn_viewTickets_Click(object sender, EventArgs e)
        {
            Tickets f1 = new Tickets(CustomerID);
            f1.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer_login cl = new Customer_login();
            cl.Show();
            Visible = false;
        }
    }
}
