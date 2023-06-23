namespace FlightReservation
{
    partial class TicketInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_ticket_id = new TextBox();
            txt_flight_id = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_source = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txt_destination = new TextBox();
            txt_dep_date = new TextBox();
            txt_arrival_date = new TextBox();
            label7 = new Label();
            label8 = new Label();
            comboBox_ClassType = new ComboBox();
            label9 = new Label();
            txt_total_price = new TextBox();
            btn_update_class = new Button();
            btn_back_flights = new Button();
            btn_cancel_reserve = new Button();
            button2 = new Button();
            btn_show_profile = new Button();
            btn_viewTickets = new Button();
            seatnumBox = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // txt_ticket_id
            // 
            txt_ticket_id.Location = new Point(236, 132);
            txt_ticket_id.Margin = new Padding(4);
            txt_ticket_id.Name = "txt_ticket_id";
            txt_ticket_id.ReadOnly = true;
            txt_ticket_id.Size = new Size(262, 28);
            txt_ticket_id.TabIndex = 0;
            // 
            // txt_flight_id
            // 
            txt_flight_id.Location = new Point(687, 129);
            txt_flight_id.Margin = new Padding(4);
            txt_flight_id.Name = "txt_flight_id";
            txt_flight_id.ReadOnly = true;
            txt_flight_id.Size = new Size(228, 28);
            txt_flight_id.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(81, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(227, 43);
            label1.TabIndex = 2;
            label1.Text = "Ticket Info";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(100, 132);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 22);
            label2.TabIndex = 3;
            label2.Text = "Ticket ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(570, 129);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 22);
            label3.TabIndex = 4;
            label3.Text = "Flight ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(109, 199);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 22);
            label4.TabIndex = 5;
            label4.Text = "Source";
            // 
            // txt_source
            // 
            txt_source.Location = new Point(236, 199);
            txt_source.Margin = new Padding(4);
            txt_source.Name = "txt_source";
            txt_source.ReadOnly = true;
            txt_source.Size = new Size(262, 28);
            txt_source.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(557, 202);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(113, 22);
            label5.TabIndex = 7;
            label5.Text = "Destination";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(71, 271);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(151, 22);
            label6.TabIndex = 8;
            label6.Text = "Departure Date";
            // 
            // txt_destination
            // 
            txt_destination.Location = new Point(687, 201);
            txt_destination.Margin = new Padding(4);
            txt_destination.Name = "txt_destination";
            txt_destination.ReadOnly = true;
            txt_destination.Size = new Size(228, 28);
            txt_destination.TabIndex = 9;
            // 
            // txt_dep_date
            // 
            txt_dep_date.Location = new Point(236, 268);
            txt_dep_date.Margin = new Padding(4);
            txt_dep_date.Name = "txt_dep_date";
            txt_dep_date.ReadOnly = true;
            txt_dep_date.Size = new Size(262, 28);
            txt_dep_date.TabIndex = 10;
            // 
            // txt_arrival_date
            // 
            txt_arrival_date.Location = new Point(687, 273);
            txt_arrival_date.Margin = new Padding(4);
            txt_arrival_date.Name = "txt_arrival_date";
            txt_arrival_date.ReadOnly = true;
            txt_arrival_date.Size = new Size(228, 28);
            txt_arrival_date.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(554, 275);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(119, 22);
            label7.TabIndex = 12;
            label7.Text = "Arrival Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(91, 407);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(110, 22);
            label8.TabIndex = 13;
            label8.Text = "Class Type";
            // 
            // comboBox_ClassType
            // 
            comboBox_ClassType.FormattingEnabled = true;
            comboBox_ClassType.Items.AddRange(new object[] { "Business", "Economy", "First" });
            comboBox_ClassType.Location = new Point(236, 403);
            comboBox_ClassType.Margin = new Padding(4);
            comboBox_ClassType.Name = "comboBox_ClassType";
            comboBox_ClassType.Size = new Size(262, 29);
            comboBox_ClassType.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(559, 340);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(109, 22);
            label9.TabIndex = 16;
            label9.Text = "Total Price";
            // 
            // txt_total_price
            // 
            txt_total_price.Location = new Point(687, 336);
            txt_total_price.Margin = new Padding(4);
            txt_total_price.Name = "txt_total_price";
            txt_total_price.ReadOnly = true;
            txt_total_price.Size = new Size(228, 28);
            txt_total_price.TabIndex = 17;
            // 
            // btn_update_class
            // 
            btn_update_class.BackColor = Color.Indigo;
            btn_update_class.FlatStyle = FlatStyle.Flat;
            btn_update_class.ForeColor = SystemColors.ControlLightLight;
            btn_update_class.Location = new Point(687, 391);
            btn_update_class.Margin = new Padding(4);
            btn_update_class.Name = "btn_update_class";
            btn_update_class.Size = new Size(215, 51);
            btn_update_class.TabIndex = 18;
            btn_update_class.Text = "Update Class";
            btn_update_class.UseVisualStyleBackColor = false;
            btn_update_class.Click += btn_update_class_Click;
            // 
            // btn_back_flights
            // 
            btn_back_flights.BackColor = Color.LightSkyBlue;
            btn_back_flights.FlatAppearance.BorderSize = 0;
            btn_back_flights.FlatStyle = FlatStyle.Flat;
            btn_back_flights.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_back_flights.Location = new Point(1009, 99);
            btn_back_flights.Margin = new Padding(4);
            btn_back_flights.Name = "btn_back_flights";
            btn_back_flights.Size = new Size(111, 59);
            btn_back_flights.TabIndex = 19;
            btn_back_flights.Text = "Availiable Flights";
            btn_back_flights.UseVisualStyleBackColor = false;
            btn_back_flights.Click += btn_back_flights_Click;
            // 
            // btn_cancel_reserve
            // 
            btn_cancel_reserve.BackColor = Color.Indigo;
            btn_cancel_reserve.FlatStyle = FlatStyle.Flat;
            btn_cancel_reserve.ForeColor = SystemColors.ControlLightLight;
            btn_cancel_reserve.Location = new Point(441, 482);
            btn_cancel_reserve.Margin = new Padding(4);
            btn_cancel_reserve.Name = "btn_cancel_reserve";
            btn_cancel_reserve.Size = new Size(215, 51);
            btn_cancel_reserve.TabIndex = 20;
            btn_cancel_reserve.Text = "Cancel Reservation";
            btn_cancel_reserve.UseVisualStyleBackColor = false;
            btn_cancel_reserve.Click += btn_cancel_reserve_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(1009, 260);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(111, 46);
            button2.TabIndex = 22;
            button2.Text = "Log Out";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btn_show_profile
            // 
            btn_show_profile.BackColor = Color.LightSkyBlue;
            btn_show_profile.FlatAppearance.BorderSize = 0;
            btn_show_profile.FlatStyle = FlatStyle.Flat;
            btn_show_profile.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_show_profile.Location = new Point(1009, 35);
            btn_show_profile.Margin = new Padding(4);
            btn_show_profile.Name = "btn_show_profile";
            btn_show_profile.Size = new Size(111, 46);
            btn_show_profile.TabIndex = 21;
            btn_show_profile.Text = "Profile";
            btn_show_profile.UseVisualStyleBackColor = false;
            btn_show_profile.Click += btn_show_profile_Click;
            // 
            // btn_viewTickets
            // 
            btn_viewTickets.BackColor = Color.LightSkyBlue;
            btn_viewTickets.FlatAppearance.BorderSize = 0;
            btn_viewTickets.FlatStyle = FlatStyle.Flat;
            btn_viewTickets.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_viewTickets.Location = new Point(1009, 184);
            btn_viewTickets.Margin = new Padding(4);
            btn_viewTickets.Name = "btn_viewTickets";
            btn_viewTickets.Size = new Size(111, 56);
            btn_viewTickets.TabIndex = 23;
            btn_viewTickets.Text = "View My Tickets";
            btn_viewTickets.UseVisualStyleBackColor = false;
            btn_viewTickets.Click += btn_viewTickets_Click;
            // 
            // seatnumBox
            // 
            seatnumBox.Location = new Point(236, 334);
            seatnumBox.Margin = new Padding(4);
            seatnumBox.Name = "seatnumBox";
            seatnumBox.ReadOnly = true;
            seatnumBox.Size = new Size(262, 28);
            seatnumBox.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(81, 337);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(130, 22);
            label10.TabIndex = 24;
            label10.Text = "Seat Number";
            // 
            // TicketInfo
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1139, 566);
            Controls.Add(seatnumBox);
            Controls.Add(label10);
            Controls.Add(btn_viewTickets);
            Controls.Add(button2);
            Controls.Add(btn_show_profile);
            Controls.Add(btn_cancel_reserve);
            Controls.Add(btn_back_flights);
            Controls.Add(btn_update_class);
            Controls.Add(txt_total_price);
            Controls.Add(label9);
            Controls.Add(comboBox_ClassType);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txt_arrival_date);
            Controls.Add(txt_dep_date);
            Controls.Add(txt_destination);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt_source);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_flight_id);
            Controls.Add(txt_ticket_id);
            Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "TicketInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticket Info";
            TransparencyKey = SystemColors.ActiveCaptionText;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_ticket_id;
        private TextBox txt_flight_id;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_source;
        private Label label5;
        private Label label6;
        private TextBox txt_destination;
        private TextBox txt_dep_date;
        private TextBox txt_arrival_date;
        private Label label7;
        private Label label8;
        private ComboBox comboBox_ClassType;
        private Label label9;
        private TextBox txt_total_price;
        private Button btn_update_class;
        private Button btn_back_flights;
        private Button btn_cancel_reserve;
        private Button button2;
        private Button btn_show_profile;
        private Button btn_viewTickets;
        private TextBox seatnumBox;
        private Label label10;
    }
}