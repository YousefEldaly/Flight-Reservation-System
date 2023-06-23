//using Flight_Reservation_System;
using FlightReservation;
using Glimpse.Ado.Tab;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FlightReservation
{

    public partial class AddFlights : Form
    {
        int adminID;

        public AddFlights()
        {
            InitializeComponent();
            dataGridView1.DataSource = LoadTable();

        }
        public AddFlights(int adminID)
        {
            InitializeComponent();

            this.adminID = adminID;
            dataGridView1.DataSource = LoadTable();
        }

        //Connection String
        static string conString = "Data Source = DESKTOP-8NFTQ6J\\FATMA; Initial Catalog = FlightReservation ;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);


        public DataTable LoadTable()
        {
            DataTable FLIGHT = new DataTable();
            string allQuery = "Select [FLIGHTID] as [Flight ID], [AIRCRAFTID] as [Aircraft],[SOURCE] as [Source]," +
                "[DESTINATION] as [Destination],[DEPDATE_TIME] as [Departure Time]," +
                "[ARRIVALDATE_TIME] as [Arrival Time],[DURATION] as [Duration]" +
                ",[BUSINESSCPRICE] as [Business Class Price]" +
                ",[FIRSTCPRICE] as [First Class Price]" +
                ",[ECONOMYCPRICE] as [Economy Class Price]" +
                "from FLIGHT";
            con.Open();
            SqlCommand cmd = new SqlCommand(allQuery, con);
            SqlDataAdapter DataAdapter = new SqlDataAdapter(cmd);
            DataAdapter.Fill(FLIGHT);
            con.Close();
            return FLIGHT;
        }



        int get_duration()
        {
            //fix duration
            int minutes = 0;
            int hour = 0;
            int day = 0;

            TimeSpan Dur = this.arr_datetime.Value - this.Dep_dateTime.Value;

            string[] temp = Dur.ToString().Split('.');
            int n;
            bool isNum = int.TryParse(temp[0], out n);

            if (isNum == true)
            {
                day = int.Parse(temp[0]) * 24 * 60;
                string[] temp2 = temp[1].Split(':');

                hour = int.Parse(temp2[0]) * 60;
                minutes = int.Parse(temp2[1]) + hour + day;
            }
            else
            {
                string[] temp2 = temp[0].Split(':');
                hour = int.Parse(temp2[0]) * 60;
                minutes = int.Parse(temp2[1]) + hour + day;
            }

            return minutes;
        }


        //Logout GUI
        private void button2_Click_1(object sender, EventArgs e)
        {
            Admin_login page = new Admin_login();
            page.Show();
            this.Close();
            //return to the signup page
        }
        //Back GUI
        private void button3_Click_1(object sender, EventArgs e)

        {
            WelcomeAdmin page = new WelcomeAdmin(adminID);
            page.Show();
            this.Close();
        }
        //SEARCH GUI
        private void button5_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new(conString);
            con.Open();
            DataTable FLIGHT = new DataTable();


            if (textBox4.Text.Length > 0 && textBox7.Text.Length > 0)
            {
                string query1 = "Select * From FLIGHT Where SOURCE = @SOURCE and DESTINATION = @DESTINATION";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.Parameters.AddWithValue("SOURCE", textBox4.Text);
                cmd1.Parameters.AddWithValue("DESTINATION", textBox7.Text);
                SqlDataAdapter DataAdapter1 = new SqlDataAdapter(cmd1);
                DataAdapter1.Fill(FLIGHT);
                con.Close();
                dataGridView1.DataSource = FLIGHT;
            }
            else
            {
                var query = "Select * From FLIGHT Where SOURCE = @SOURCE and DESTINATION <> @DESTINATION";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("SOURCE", textBox4.Text);
                cmd.Parameters.AddWithValue("DESTINATION", textBox7.Text);
                SqlDataAdapter DataAdapter = new SqlDataAdapter(cmd);
                DataAdapter.Fill(FLIGHT);
                string query1 = "Select * From FLIGHT Where DESTINATION = @DESTINATION";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.Parameters.AddWithValue("DESTINATION", textBox7.Text);
                SqlDataAdapter DataAdapter1 = new SqlDataAdapter(cmd1);
                DataAdapter1.Fill(FLIGHT);
                con.Close();
                dataGridView1.DataSource = FLIGHT;
            }
        }

        public bool isvalidAircraft()
        {

            string query = "SELECT COUNT(*) FROM Aircraft where AIRCRAFTID=@AIRCRAFT";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@AIRCRAFT", text_air.Text);
            con.Open();
            int count = (int)command.ExecuteScalar();
            con.Close();
            return (count > 0);
        }
        //ADD GUII
        private void addB_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new(conString);
            con.Open();
            string addquery = "Insert into FLIGHT values(@AIRCRAFTID,@SOURCE,@DESTINATION,@DEPDATE_TIME,@ARRIVALDATE_TIME,@DURATION,@BUSINESSCPRICE,@FIRSTCPRICE,@ECONOMYCPRICE)";
            SqlCommand cmd = new SqlCommand(addquery, con);

            cmd.Parameters.AddWithValue("@AIRCRAFTID", int.Parse(text_air.Text));
            cmd.Parameters.AddWithValue("@SOURCE", text_Sour.Text);
            cmd.Parameters.AddWithValue("@DESTINATION", text_Des.Text);
            cmd.Parameters.AddWithValue("@DEPDATE_TIME", Dep_dateTime.Text);
            cmd.Parameters.AddWithValue("@ARRIVALDATE_TIME", arr_datetime.Text);
            cmd.Parameters.AddWithValue("@DURATION", get_duration());

            cmd.Parameters.AddWithValue("@BUSINESSCPRICE", int.Parse(text_bus.Text));
            cmd.Parameters.AddWithValue("@FIRSTCPRICE", int.Parse(text_fir.Text));
            cmd.Parameters.AddWithValue("@ECONOMYCPRICE", int.Parse(text_eco.Text));
            if (isvalidAircraft())
            {
                cmd.ExecuteNonQuery();
                con.Close();


                string queryy = "select FLIGHTID from FLIGHT " +
                        "where AIRCRAFTID =@AIR and  SOURCE =@SOU " +
                        "and DESTINATION =@DES and DEPDATE_TIME=@DEP  " +
                        "and ARRIVALDATE_TIME =@ARR and BUSINESSCPRICE=@BUSINESSCLASSPRICE " +
                        "and FIRSTCPRICE =@FIRSTCLASSPRICE and ECONOMYCPRICE=@ECONOMYCLASSPRICE ";

                con.Open();
                SqlCommand cmd7 = new SqlCommand(queryy, con);
                cmd7.Parameters.AddWithValue("@AIR", int.Parse(text_air.Text));
                cmd7.Parameters.AddWithValue("@SOU", text_Sour.Text);
                cmd7.Parameters.AddWithValue("@DES", text_Des.Text);
                cmd7.Parameters.AddWithValue("@DEP", Dep_dateTime.Text);
                cmd7.Parameters.AddWithValue("@ARR", arr_datetime.Text);
                cmd7.Parameters.AddWithValue("@BUSINESSCLASSPRICE", int.Parse(text_bus.Text));
                cmd7.Parameters.AddWithValue("@FIRSTCLASSPRICE", int.Parse(text_fir.Text));
                cmd7.Parameters.AddWithValue("@ECONOMYCLASSPRICE", int.Parse(text_eco.Text));
                SqlDataReader Reader = cmd7.ExecuteReader();
                Reader.Read();
                // get flight id
                int flight_id = Reader.GetInt32(0);
                Reader.Close();
                con.Close();

                //insert to flight manager

                string fmanagerQuery = "INSERT into FLIGHTMANAGER Values (@f, @id) ";
                SqlCommand cmdn = new SqlCommand(fmanagerQuery, con);
                cmdn.Parameters.AddWithValue("@f", flight_id);
                cmdn.Parameters.AddWithValue("@id", adminID);
                con.Open();
                cmdn.ExecuteNonQuery();
                con.Close();

                dataGridView1.DataSource = LoadTable();


                MessageBox.Show("Flight Added Successfully");
                if (MessageBox.Show("Do You Want to add a Flight Leg", "Add a Flight Leg", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    FlightLeg flightLeg = new FlightLeg(flight_id);


                    flightLeg.Show();
                }

            }

            else
            {
                MessageBox.Show("Aircraft is not Found\nPlease Enter a valid Aircraft ID");
            }

        }

        //UPDATE GUII
        private void button4_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new(conString);
            con.Open();
            string query4 = "UPDATE FLIGHT SET AIRCRAFTID = @AIRCRAFTID, SOURCE = @SOURCE, DESTINATION = @DESTINATION, DEPDATE_TIME = @DEPDATE_TIME,ARRIVALDATE_TIME=@ARRIVALDATE_TIME ,DURATION=@DURATION ,BUSINESSCPRICE = @BUSINESSCPRICE, FIRSTCPRICE=@FIRSTCPRICE, ECONOMYCPRICE = @ECONOMYCPRICE WHERE FLIGHTID =" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
            SqlCommand cmd4 = new SqlCommand(query4, con);

            cmd4.Parameters.AddWithValue("@AIRCRAFTID", int.Parse(text_air.Text));
            cmd4.Parameters.AddWithValue("@SOURCE", text_Sour.Text);
            cmd4.Parameters.AddWithValue("@DESTINATION", text_Des.Text);
            cmd4.Parameters.AddWithValue("@DEPDATE_TIME", Dep_dateTime.Text);

            cmd4.Parameters.AddWithValue("@ARRIVALDATE_TIME", arr_datetime.Text);
            cmd4.Parameters.AddWithValue("@BUSINESSCPRICE", int.Parse(text_bus.Text));
            cmd4.Parameters.AddWithValue("@FIRSTCPRICE", int.Parse(text_fir.Text));
            cmd4.Parameters.AddWithValue("@ECONOMYCPRICE", int.Parse(text_eco.Text));
            cmd4.Parameters.AddWithValue("@DURATION", get_duration());
            cmd4.ExecuteNonQuery();
            con.Close();
            dataGridView1.DataSource = LoadTable();
            MessageBox.Show("Flight has been updated successfully! :)");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            text_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            text_air.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            text_Sour.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            text_Des.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            DateTime dob;
            if (DateTime.TryParse(dataGridView1.CurrentRow.Cells[4].Value.ToString(), out dob))
            {
                Dep_dateTime.Text = dob.ToString("yyyy-MM-dd hh:mm");
            }
            else
            {
                Dep_dateTime.Text = ""; // clear the TextBox if the value is not a valid DateTime
            }

            DateTime dob2;
            if (DateTime.TryParse(dataGridView1.CurrentRow.Cells[5].Value.ToString(), out dob2))
            {
                arr_datetime.Text = dob2.ToString("yyyy-MM-dd hh:mm");
            }
            else
            {
                arr_datetime.Text = ""; // clear the TextBox if the value is not a valid DateTime
            }

            text_bus.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            text_fir.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            text_eco.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }


        private void btndelete_Click_1(object sender, EventArgs e)
        {
            int flightID = int.Parse(text_ID.Text);

            string delete_query = "DELETE FROM [FLIGHT] " +
                                  "WHERE [FLIGHTID] = @fID";
            con.Open();
            SqlCommand cmd = new SqlCommand(delete_query, con);
            cmd.Parameters.AddWithValue("@fID", flightID);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Flight Has been Deleted :(");
            con.Close();

            text_ID.Clear();
            text_air.Clear();
            text_Sour.Clear();
            text_Des.Clear();
            Dep_dateTime.Text = "";
            arr_datetime.Text = "";
            text_bus.Clear();
            text_fir.Clear();
            text_eco.Clear();

            dataGridView1.DataSource = LoadTable();
            return;
        }
    }
}

