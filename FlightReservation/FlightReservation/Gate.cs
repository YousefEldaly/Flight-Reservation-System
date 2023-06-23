using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightReservation
{
    public partial class Gate : Form
    {
        public Gate()
        {
            InitializeComponent();
        }

        private void btnAdmin_click(object sender, EventArgs e)
        {
            Admin_login adlogin = new Admin_login();
            adlogin.Show();
            Visible = false;

        }

        private void btnCustomer_click(object sender, EventArgs e)
        {
            Customer_login clogin = new Customer_login();
            clogin.Show();
            Visible = false;
        }


    }
}

