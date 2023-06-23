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
    public partial class Tickets : Form
    {
        static String sql = "Data Source = DESKTOP-8NFTQ6J\\FATMA; Initial Catalog = FlightReservation ;Integrated Security=True";
        SqlConnection con = new SqlConnection(sql);
        static int customerID;
        public Tickets(int CustomerID)
        {
            InitializeComponent();
            customerID = CustomerID;
            dataGridView1.DataSource = LoadTicketsTable();
        }

        public DataTable LoadTicketsTable()
        {
            DataTable table = new DataTable();
            string query = "Select [TICKETID] as [Ticket ID], " +
                "[TOTALPRICE] as [Price]" +
                ",[FLIGHTID] as [Flight ID]" +
                ",[SEATNUM] as [Seat Number]" +
                ",[CLASSTYPE] as [Flight Class] " +
                "from TICKET WHERE CUSTOMERID = @cust_id";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@cust_id", customerID);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            con.Close();
            return table;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_get_ticket_info_Click(object sender, EventArgs e)
        {
            int ticketID = int.Parse(txt_ticketID_info.Text);

            string query = "SELECT * FROM TICKET " +
                           "WHERE CUSTOMERID = @CustomerID " +
                           "AND TICKETID = @ticketID";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@CustomerID", customerID);
            cmd.Parameters.AddWithValue("@ticketID", ticketID);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                reader.Close();
                con.Close();
                TicketInfo ticketInfo_form = new TicketInfo(ticketID);
                ticketInfo_form.Show();
                Visible = false;
            }
            else
            {
                reader.Close();
                con.Close();
                MessageBox.Show("Invalid Ticket ID");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Flights f = new Flights(customerID);
            f.Show();
            Visible = false;
        }

        private void btn_show_profile_Click(object sender, EventArgs e)
        {
            CustomerProfile cP = new CustomerProfile(customerID);
            cP.Show();
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
