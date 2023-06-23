using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Flight_Reservation_System;
using FlightReservation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FlightReservation
{
    public partial class AddAircrafts : Form
    {
        int adminID;
        public AddAircrafts(int adminID)
        {
            InitializeComponent();
            dataGridView11.DataSource = LoadTable();
            this.adminID = adminID;
        }

        //Connection String
        static string conString = "Data Source = DESKTOP-8NFTQ6J\\FATMA; Initial Catalog = FlightReservation ;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);


        public DataTable LoadTable()
        {

            DataTable AIRCRAFT = new DataTable();
            string allQuery = "Select * from AIRCRAFT";
            con.Open();
            SqlCommand cmd = new SqlCommand(allQuery, con);
            SqlDataAdapter DataAdapter = new SqlDataAdapter(cmd);
            DataAdapter.Fill(AIRCRAFT);
            con.Close();
            return AIRCRAFT;
        }



        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new(conString);
            con.Open();
            DataTable FLIGHT = new DataTable();
            if (textBox3.Text.Length > 0 && textBox2.Text.Length > 0 && textBox1.Text.Length > 0)
            {
                string query = "Select AIRCRAFTID,MODEL,FIRSTCSEATS,BUSINESSCSEATS,ECONOMYCSEATS From AIRCRAFT Where FIRSTCSEATS = @FIRSTCSEATS and BUSINESSCSEATS = @BUSINESSCSEATS and ECONOMYCSEATS = @ECONOMYCSEATS";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("FIRSTCSEATS", textBox3.Text);
                cmd.Parameters.AddWithValue("BUSINESSCSEATS", textBox2.Text);
                cmd.Parameters.AddWithValue("ECONOMYCSEATS", textBox1.Text);
                SqlDataAdapter DataAdapter = new SqlDataAdapter(cmd);
                DataAdapter.Fill(FLIGHT);
                con.Close();
                dataGridView11.DataSource = FLIGHT;
            }
            else
            {
                var query1 = "Select AIRCRAFTID,MODEL,FIRSTCSEATS,BUSINESSCSEATS,ECONOMYCSEATS From AIRCRAFT Where FIRSTCSEATS = @FIRSTCSEATS and BUSINESSCSEATS <> @BUSINESSCSEATS and ECONOMYCSEATS <> @ECONOMYCSEATS";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.Parameters.AddWithValue("FIRSTCSEATS", textBox3.Text);
                cmd1.Parameters.AddWithValue("BUSINESSCSEATS", textBox2.Text);
                cmd1.Parameters.AddWithValue("ECONOMYCSEATS", textBox1.Text);
                SqlDataAdapter DataAdapter1 = new SqlDataAdapter(cmd1);
                DataAdapter1.Fill(FLIGHT);
                con.Close();
                dataGridView11.DataSource = FLIGHT;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new(conString);
            con.Open();
            string query = "INSERT INTO AIRCRAFT(MODEL, FIRSTCSEATS, ECONOMYCSEATS, BUSINESSCSEATS) VALUES(@MODEL , @FIRSTCSEATS, @ECONOMYCSEATS, @BUSINESSCSEATS)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@MODEL", modelAircraft.Text);
            cmd.Parameters.AddWithValue("@FIRSTCSEATS", textBox8.Text);
            cmd.Parameters.AddWithValue("@ECONOMYCSEATS", textBox10.Text);
            cmd.Parameters.AddWithValue("@BUSINESSCSEATS", textBox9.Text);

            if (modelAircraft.Text.Length == 0 ||
                textBox8.Text.Length == 0 ||
                textBox10.Text.Length == 0 ||
                textBox9.Text.Length == 0)
            {
                MessageBox.Show("Please enter a valid data");
                con.Close();
                return;
            }
            else
            {

                string model_duplicate_query = "SELECT * from AIRCRAFT WHERE [MODEL] = @model";
                SqlCommand cmd_model = new SqlCommand(model_duplicate_query, con);
                cmd_model.Parameters.AddWithValue("@model", modelAircraft.Text);
                SqlDataReader r;
                r = cmd_model.ExecuteReader();
                r.Read();
                if (r.HasRows)
                {
                    MessageBox.Show("This model already exists!!");
                    r.Close();
                    con.Close();
                    return;
                }
                r.Close();

            }



            cmd.ExecuteNonQuery();
            con.Close();
            dataGridView11.DataSource = LoadTable();
            MessageBox.Show("Aircraft has been added successfully! :)");

            //fill AIRCRAFT MANAGER table
            string queryy = "select AIRCRAFTID from AIRCRAFT " +
                        "where MODEL=@MOD and BUSINESSCSEATS=@BUS " +
                        "and FIRSTCSEATS =@FIRST and ECONOMYCSEATS=@ECO ";
            con.Open();
            SqlCommand cmd7 = new SqlCommand(queryy, con);

            cmd7.Parameters.AddWithValue("@MOD", modelAircraft.Text);
            cmd7.Parameters.AddWithValue("@FIRST", textBox8.Text);
            cmd7.Parameters.AddWithValue("@ECO", textBox10.Text);
            cmd7.Parameters.AddWithValue("@BUS", textBox9.Text);
            SqlDataReader Reader = cmd7.ExecuteReader();
            Reader.Read();
            // get flight id
            int aircraft_id = Reader.GetInt32(0);


            string fmanagerQuery = "insert into AIRCRAFTMANAGER values(@air,@id) ";
            SqlCommand cmdn = new SqlCommand(fmanagerQuery, con);

            cmdn.Parameters.AddWithValue("@air", aircraft_id);
            cmdn.Parameters.AddWithValue("@id", adminID);
            Reader.Close();
            cmdn.ExecuteNonQuery();

            con.Close();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new(conString);
            con.Open();
            string query1 = "UPDATE AIRCRAFT SET MODEL=@MODEL, FIRSTCSEATS=@FIRSTCSEATS, ECONOMYCSEATS=@ECONOMYCSEATS, BUSINESSCSEATS=@BUSINESSCSEATS WHERE AIRCRAFTID=" + dataGridView11.CurrentRow.Cells[0].Value.ToString() + "";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.Parameters.AddWithValue("@MODEL", modelAircraft.Text);
            cmd1.Parameters.AddWithValue("@FIRSTCSEATS", textBox8.Text);
            cmd1.Parameters.AddWithValue("@ECONOMYCSEATS", textBox10.Text);
            cmd1.Parameters.AddWithValue("@BUSINESSCSEATS", textBox9.Text);

            if (modelAircraft.Text.Length == 0 ||
                textBox8.Text.Length == 0 ||
                textBox10.Text.Length == 0 ||
                textBox9.Text.Length == 0)
            {
                MessageBox.Show("Please enter a valid data");
                con.Close();
                return;
            }
            else
            {

                string model_duplicate_query = "SELECT * from AIRCRAFT WHERE [MODEL] = @model";
                SqlCommand cmd_model = new SqlCommand(model_duplicate_query, con);
                cmd_model.Parameters.AddWithValue("@model", modelAircraft.Text);
                SqlDataReader r;
                r = cmd_model.ExecuteReader();
                r.Read();
                if (r.HasRows)
                {
                    MessageBox.Show("This model already exists!!");
                    r.Close();
                    con.Close();
                    return;
                }
                r.Close();

            }

            cmd1.ExecuteNonQuery();
            con.Close();
            dataGridView11.DataSource = LoadTable();
            MessageBox.Show("Aircraft has been updated successfully! :)");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            WelcomeAdmin page = new WelcomeAdmin(adminID);
            this.Close();
            page.Show();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Admin_login page = new Admin_login();
            page.Show();
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new(conString);
            con.Open();
            DataTable FLIGHT = new DataTable();
            if (textBox3.Text.Length > 0 && textBox2.Text.Length > 0 && textBox1.Text.Length > 0)
            {
                string query = "Select AIRCRAFTID,MODEL,FIRSTCSEATS,BUSINESSCSEATS,ECONOMYCSEATS " +
                    "From AIRCRAFT " +
                    "Where FIRSTCSEATS = @FIRSTCSEATS AND BUSINESSCSEATS = @BUSINESSCSEATS AND ECONOMYCSEATS = @ECONOMYCSEATS";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("FIRSTCSEATS", textBox3.Text);
                cmd.Parameters.AddWithValue("BUSINESSCSEATS", textBox2.Text);
                cmd.Parameters.AddWithValue("ECONOMYCSEATS", textBox1.Text);
                SqlDataAdapter DataAdapter = new SqlDataAdapter(cmd);
                DataAdapter.Fill(FLIGHT);
                con.Close();
                dataGridView11.DataSource = FLIGHT;
            }
            else
            {
                var query1 = "Select AIRCRAFTID,MODEL,FIRSTCSEATS,BUSINESSCSEATS,ECONOMYCSEATS From AIRCRAFT Where FIRSTCSEATS = @FIRSTCSEATS and BUSINESSCSEATS <> @BUSINESSCSEATS and ECONOMYCSEATS <> @ECONOMYCSEATS";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.Parameters.AddWithValue("FIRSTCSEATS", textBox3.Text);
                cmd1.Parameters.AddWithValue("BUSINESSCSEATS", textBox2.Text);
                cmd1.Parameters.AddWithValue("ECONOMYCSEATS", textBox1.Text);
                SqlDataAdapter DataAdapter1 = new SqlDataAdapter(cmd1);
                DataAdapter1.Fill(FLIGHT);
                con.Close();
                dataGridView11.DataSource = FLIGHT;
            }


        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            aircraftID.Text = dataGridView11.CurrentRow.Cells[0].Value.ToString();
            modelAircraft.Text = dataGridView11.CurrentRow.Cells[1].Value.ToString();
            textBox8.Text = dataGridView11.CurrentRow.Cells[2].Value.ToString();
            textBox10.Text = dataGridView11.CurrentRow.Cells[3].Value.ToString();
            textBox9.Text = dataGridView11.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
