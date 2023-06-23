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

namespace FlightReservation
{
    public partial class FlightLeg : Form
    {
        public int fid;
        public FlightLeg(int FID)
        {
            InitializeComponent();
            this.fid = FID;
            FLIGHTIDtxt.Text = fid.ToString();
        }


        //Connection String
        static string conString = "Data Source =DESKTOP-8NFTQ6J\\FATMA; Initial Catalog = FlightReservation ;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);
        public DataTable LoadTable()
        {

            DataTable FLIGHTLEG = new DataTable();
            string allQuery = "Select * from FLIGHTLEG";
            con.Open();
            SqlCommand cmd = new SqlCommand(allQuery, con);
            SqlDataAdapter DataAdapter = new SqlDataAdapter(cmd);
            DataAdapter.Fill(FLIGHTLEG);
            con.Close();
            return FLIGHTLEG;
        }
        int get_duration()
        {
            //fix duration
            int minutes = 0;
            int hour = 0;
            int day = 0;

            TimeSpan Dur = this.dateTimePicker2.Value - this.dateTimePicker1.Value;

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
        //Add Button

        //Add GUI
        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new(conString);
            con.Open();
            string query = "INSERT INTO FLIGHTLEG(FLIGHTID ,DEPDATE_TIME, ARRIVALDATE_TIME, COUNTRY, AIRPORT,DURATION) VALUES(@FLIGHTID,@DEPDATE_TIME, @ARRIVALDATE_TIME, @COUNTRY, @AIRPORT,@DURATION)";
            SqlCommand cmd = new SqlCommand(query, con);

            //FLIGHTIDtxt
            cmd.Parameters.AddWithValue("@FLIGHTID", fid);
            cmd.Parameters.AddWithValue("@DEPDATE_TIME", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@ARRIVALDATE_TIME", dateTimePicker2.Text);
            cmd.Parameters.AddWithValue("@DURATION", get_duration());
            cmd.Parameters.AddWithValue("@AIRPORT", AIRPORtxt.Text);
            cmd.Parameters.AddWithValue("@COUNTRY", COUNtxt.Text);

            cmd.ExecuteNonQuery();
            guna2DataGridView1.DataSource = LoadTable();
            con.Close();
            MessageBox.Show("Flight Leg Added Successfully");
        }
        //Close GUI
        private void button1_Click_1(object sender, EventArgs e)
        {
            AddFlights addFlights = new AddFlights();

            addFlights.Show();
            this.Close();
        }

    }
}
