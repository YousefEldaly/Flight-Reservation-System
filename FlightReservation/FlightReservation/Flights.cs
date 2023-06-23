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

namespace FlightReservation
{

    public partial class Flights : Form
    {
        static String sql = "Data Source =DESKTOP-8NFTQ6J\\FATMA; Initial Catalog = FlightReservation ;Integrated Security=True";
        SqlConnection con = new SqlConnection(sql);
        int CustomerID;
        public Flights(int custID)
        {
            InitializeComponent();
            CustomerID = custID;
            dataGridView1.DataSource = LoadFlightTable();
            comboBoxFlightClass.Items.Add("Business");
            comboBoxFlightClass.Items.Add("Economy");
            comboBoxFlightClass.Items.Add("First");

        }

        /*load flights table*/

        public DataTable LoadFlightTable()
        {
            DataTable table = new DataTable();
            string query = "Select [FLIGHTID] as [Flight ID], [SOURCE] as [Source]," +
                "[DESTINATION] as [Destination],[DEPDATE_TIME] as [Departure Time]," +
                "[ARRIVALDATE_TIME] as [Arrival Time],[DURATION] as [Duration]" +
                ",[BUSINESSCPRICE] as [Business Class Price]" +
                ",[FIRSTCPRICE] as [First Class Price]" +
                ",[ECONOMYCPRICE] as [Economy Class Price]" +
                "from FLIGHT";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textFlightID.Text, out int flightID))
            {
                string validate_query = "SELECT * FROM TICKET WHERE FLIGHTID = @id AND CUSTOMERID = @custID";
                SqlCommand cmd_valid = new SqlCommand(validate_query, con);
                cmd_valid.Parameters.AddWithValue("@id", flightID);
                cmd_valid.Parameters.AddWithValue("@custID", CustomerID);
                SqlDataReader r2;
                con.Open();
                r2 = cmd_valid.ExecuteReader();

                if (r2.HasRows)
                {
                    MessageBox.Show("Flight is already reserved!");
                    con.Close();
                    r2.Close();
                    return;
                }
                r2.Close();

                string srch_query = "SELECT * FROM FLIGHT WHERE FLIGHTID = @id";
                SqlCommand cmd = new SqlCommand(srch_query, con);
                cmd.Parameters.AddWithValue("@id", flightID);
                SqlDataReader r;
                r = cmd.ExecuteReader();



                if (r.HasRows)
                {
                    r.Read();

                    int aircraftID = (int)r["AIRCRAFTID"];
                    r.Close();

                    int total_seatnum = get_seatnum(comboBoxFlightClass.SelectedItem.ToString(), aircraftID);
                    int reserved_seats = get_reserved_seats(comboBoxFlightClass.SelectedItem.ToString(), flightID);
                    int seat_num = total_seatnum - reserved_seats;

                    r = cmd.ExecuteReader();
                    r.Read();


                    string insert_query = "INSERT INTO TICKET ([CUSTOMERID],[FLIGHTID],[CLASSTYPE],[TOTALPRICE],[SEATNUM])" +
                        " VALUES(@custID, @flightID, @Class, @price, @seatnum)";
                    SqlCommand cmd_insert = new SqlCommand(insert_query, con);
                    cmd_insert.Parameters.AddWithValue("@flightID", flightID);
                    cmd_insert.Parameters.AddWithValue("@custID", CustomerID);
                    cmd_insert.Parameters.AddWithValue("@Class", comboBoxFlightClass.SelectedItem.ToString());




                    if (seat_num == 0)
                    {
                        MessageBox.Show("There are No Available seats for the choosen class in this flight! :(");
                        r.Close();
                        con.Close();
                        return;
                    }

                    cmd_insert.Parameters.AddWithValue("@seatnum", seat_num);

                    if (comboBoxFlightClass.SelectedItem.ToString() == "Business")
                    {
                        cmd_insert.Parameters.AddWithValue("@price", r["BUSINESSCPRICE"]);
                    }
                    else if (comboBoxFlightClass.SelectedItem.ToString() == "Economy")
                    {
                        cmd_insert.Parameters.AddWithValue("@price", r["ECONOMYCPRICE"]);
                    }
                    else
                    {
                        cmd_insert.Parameters.AddWithValue("@price", r["FIRSTCPRICE"]);
                    }



                    r.Close();
                    cmd_insert.ExecuteNonQuery();
                    con.Close();


                    TicketInfo ticket_info = new TicketInfo(CustomerID, flightID);
                    ticket_info.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Invalid ID");
                }

                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid Flight ID");
            }
        }

        private int get_seatnum(string class_type, int aircraftID)
        {
            int seat_number = 0;
            string seatnum_query = "SELECT [FIRSTCSEATS], " +
                                   "[ECONOMYCSEATS], " +
                                   "[BUSINESSCSEATS] " +
                                   " FROM [AIRCRAFT] " +
                                   "WHERE [AIRCRAFTID] = @acID";
            SqlCommand cmd = new SqlCommand(seatnum_query, con);
            cmd.Parameters.AddWithValue("@acID", aircraftID);
            SqlDataReader seatnum_reader;

            seatnum_reader = cmd.ExecuteReader();
            seatnum_reader.Read();

            if (class_type == "Business")
            {
                seat_number = (int)seatnum_reader["BUSINESSCSEATS"];
            }
            else if (class_type == "Economy")
            {
                seat_number = (int)seatnum_reader["ECONOMYCSEATS"];
            }
            else if (class_type == "First")
            {
                seat_number = (int)seatnum_reader["FIRSTCSEATS"];
            }

            seatnum_reader.Close();
            return seat_number;
        }

        private int get_reserved_seats(string class_type, int flightID)
        {
            int reserved_seats = 0;

            string query = "SELECT COUNT(*) as [Reserved Seats] FROM TICKET " +
                           "WHERE [CLASSTYPE] = @class AND [FLIGHTID] = @fID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@class", class_type);
            cmd.Parameters.AddWithValue("@fID", flightID);
            SqlDataReader r;
            r = cmd.ExecuteReader();
            r.Read();

            reserved_seats = (int)r["Reserved Seats"];
            r.Close();


            return reserved_seats;

        }

        private void btn_src_search_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable table = new DataTable();
            string srch_query = "SELECT [FLIGHTID] as [Flight ID], [SOURCE] as [Source]," +
                "[DESTINATION] as [Destination],[DEPDATE_TIME] as [Departure Time]," +
                "[ARRIVALDATE_TIME] as [Arrival Time],[DURATION] as [Duration]," +
                "[BUSINESSCPRICE] as [Business Class Price]," +
                "[FIRSTCPRICE] as [First Class Price]," +
                "[ECONOMYCPRICE] as [Economy Class Price]" +
                "from FLIGHT WHERE SOURCE = @src";
            SqlCommand cmd = new SqlCommand(srch_query, con);

            if (string.IsNullOrEmpty(txt_src_search.Text))
            {
                MessageBox.Show("No entered data, Please fill the search box");
                con.Close();
                return;
            }
            string firstLetter = txt_src_search.Text.Substring(0, 1).ToUpper();
            string restOfWord = txt_src_search.Text.Substring(1).ToLower();
            string srch = firstLetter + restOfWord;
            cmd.Parameters.AddWithValue("@src", srch);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                dataGridView1.DataSource = table;
            }
            else
            {
                MessageBox.Show("Invalid Flight Source City");
            }
            con.Close();
        }

        private void btn_show_profile_Click(object sender, EventArgs e)
        {
            CustomerProfile profile_Form = new CustomerProfile(CustomerID);
            profile_Form.Show();
            Visible = false;
        }

        private void get_legs_info_Click(object sender, EventArgs e)
        {
            int flightID = int.Parse(txt_flightID_leg.Text);

            string query = "SELECT [COUNTRY] as [Country]," +
                " [AIRPORT] as [Airport] ," +
                " [ARRIVALDATE_TIME] as [Airport Arrival Time]," +
                " [DURATION] as [Stay Duration]," +
                " [DEPDATE_TIME] as [Flight Departure Time] " +
                " FROM FLIGHTLEG WHERE FLIGHTID = @flightID" +
                " Order by [ARRIVALDATE_TIME] ";

            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.Parameters.AddWithValue("@flightID", flightID);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("There is no flight legs for this flight");
                con.Close();
                return;
            }
            dataGridView1.DataSource = table;
            con.Close();

        }

        private void btn_view_flights_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadFlightTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer_login cl = new Customer_login();
            cl.Show();
            Visible = false;
        }
    }
}
