namespace FlightReservation
{
    partial class Flights
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnBook = new Button();
            flightId = new Label();
            textFlightID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxFlightClass = new ComboBox();
            txt_src_search = new TextBox();
            label3 = new Label();
            btn_src_search = new Button();
            button2 = new Button();
            btn_show_profile = new Button();
            get_legs_info = new Button();
            txt_flightID_leg = new TextBox();
            label4 = new Label();
            btn_view_flights = new Guna.UI2.WinForms.Guna2Button();
            dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.Indigo;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnBook.ForeColor = SystemColors.ControlLightLight;
            btnBook.Location = new Point(657, 124);
            btnBook.Margin = new Padding(3, 4, 3, 4);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(112, 38);
            btnBook.TabIndex = 0;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += button1_Click;
            // 
            // flightId
            // 
            flightId.AutoSize = true;
            flightId.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            flightId.Location = new Point(84, 135);
            flightId.Name = "flightId";
            flightId.Size = new Size(86, 22);
            flightId.TabIndex = 1;
            flightId.Text = "Flight ID";
            // 
            // textFlightID
            // 
            textFlightID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textFlightID.Location = new Point(195, 126);
            textFlightID.Margin = new Padding(3, 4, 3, 4);
            textFlightID.Name = "textFlightID";
            textFlightID.Size = new Size(104, 30);
            textFlightID.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(74, 42);
            label1.Name = "label1";
            label1.Size = new Size(281, 43);
            label1.TabIndex = 4;
            label1.Text = "Book A Ticket";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(335, 129);
            label2.Name = "label2";
            label2.Size = new Size(116, 22);
            label2.TabIndex = 5;
            label2.Text = "Flight Class";
            // 
            // comboBoxFlightClass
            // 
            comboBoxFlightClass.BackColor = SystemColors.InactiveBorder;
            comboBoxFlightClass.FormattingEnabled = true;
            comboBoxFlightClass.Location = new Point(467, 129);
            comboBoxFlightClass.Margin = new Padding(3, 4, 3, 4);
            comboBoxFlightClass.Name = "comboBoxFlightClass";
            comboBoxFlightClass.Size = new Size(158, 28);
            comboBoxFlightClass.TabIndex = 6;
            // 
            // txt_src_search
            // 
            txt_src_search.Location = new Point(195, 237);
            txt_src_search.Margin = new Padding(3, 4, 3, 4);
            txt_src_search.Name = "txt_src_search";
            txt_src_search.Size = new Size(116, 27);
            txt_src_search.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(87, 237);
            label3.Name = "label3";
            label3.Size = new Size(75, 22);
            label3.TabIndex = 9;
            label3.Text = "Source";
            // 
            // btn_src_search
            // 
            btn_src_search.BackColor = Color.Indigo;
            btn_src_search.FlatStyle = FlatStyle.Flat;
            btn_src_search.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_src_search.ForeColor = SystemColors.ControlLightLight;
            btn_src_search.Location = new Point(328, 231);
            btn_src_search.Margin = new Padding(3, 4, 3, 4);
            btn_src_search.Name = "btn_src_search";
            btn_src_search.Size = new Size(96, 39);
            btn_src_search.TabIndex = 10;
            btn_src_search.Text = "Search";
            btn_src_search.UseVisualStyleBackColor = false;
            btn_src_search.Click += btn_src_search_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(1253, 109);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(111, 45);
            button2.TabIndex = 12;
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
            btn_show_profile.ForeColor = SystemColors.ActiveCaptionText;
            btn_show_profile.Location = new Point(1253, 47);
            btn_show_profile.Margin = new Padding(3, 4, 3, 4);
            btn_show_profile.Name = "btn_show_profile";
            btn_show_profile.Size = new Size(111, 46);
            btn_show_profile.TabIndex = 13;
            btn_show_profile.Text = "Profile";
            btn_show_profile.UseVisualStyleBackColor = false;
            btn_show_profile.Click += btn_show_profile_Click;
            // 
            // get_legs_info
            // 
            get_legs_info.BackColor = Color.Indigo;
            get_legs_info.FlatStyle = FlatStyle.Flat;
            get_legs_info.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            get_legs_info.ForeColor = SystemColors.ControlLightLight;
            get_legs_info.Location = new Point(748, 229);
            get_legs_info.Margin = new Padding(3, 4, 3, 4);
            get_legs_info.Name = "get_legs_info";
            get_legs_info.Size = new Size(133, 39);
            get_legs_info.TabIndex = 14;
            get_legs_info.Text = "Get Legs Info";
            get_legs_info.UseVisualStyleBackColor = false;
            get_legs_info.Click += get_legs_info_Click;
            // 
            // txt_flightID_leg
            // 
            txt_flightID_leg.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_flightID_leg.Location = new Point(625, 234);
            txt_flightID_leg.Margin = new Padding(3, 4, 3, 4);
            txt_flightID_leg.Name = "txt_flightID_leg";
            txt_flightID_leg.Size = new Size(104, 30);
            txt_flightID_leg.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(520, 237);
            label4.Name = "label4";
            label4.Size = new Size(86, 22);
            label4.TabIndex = 18;
            label4.Text = "Flight ID";
            // 
            // btn_view_flights
            // 
            btn_view_flights.BackColor = Color.Indigo;
            btn_view_flights.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btn_view_flights.CustomizableEdges = customizableEdges1;
            btn_view_flights.DisabledState.BorderColor = Color.DarkGray;
            btn_view_flights.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_view_flights.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_view_flights.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_view_flights.FillColor = Color.Indigo;
            btn_view_flights.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_view_flights.ForeColor = Color.White;
            btn_view_flights.Location = new Point(1098, 231);
            btn_view_flights.Margin = new Padding(3, 4, 3, 4);
            btn_view_flights.Name = "btn_view_flights";
            btn_view_flights.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_view_flights.Size = new Size(130, 39);
            btn_view_flights.TabIndex = 20;
            btn_view_flights.Text = "View All";
            btn_view_flights.Click += btn_view_flights_Click_1;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = SystemColors.MenuBar;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Indigo;
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Indigo;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = Color.DodgerBlue;
            dataGridView1.Location = new Point(74, 297);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 55;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.Size = new Size(1154, 286);
            dataGridView1.TabIndex = 21;
            dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridView1.ThemeStyle.BackColor = SystemColors.MenuBar;
            dataGridView1.ThemeStyle.GridColor = Color.DodgerBlue;
            dataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView1.ThemeStyle.HeaderStyle.Height = 50;
            dataGridView1.ThemeStyle.ReadOnly = true;
            dataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridView1.ThemeStyle.RowsStyle.Height = 30;
            dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Flights
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1384, 608);
            Controls.Add(dataGridView1);
            Controls.Add(btn_view_flights);
            Controls.Add(txt_flightID_leg);
            Controls.Add(label4);
            Controls.Add(get_legs_info);
            Controls.Add(btn_show_profile);
            Controls.Add(button2);
            Controls.Add(btn_src_search);
            Controls.Add(label3);
            Controls.Add(txt_src_search);
            Controls.Add(comboBoxFlightClass);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textFlightID);
            Controls.Add(flightId);
            Controls.Add(btnBook);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Flights";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flights";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBook;
        private Label flightId;
        private TextBox textFlightID;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxFlightClass;
        private TextBox txt_src_search;
        private Label label3;
        private Button btn_src_search;
        private Button button2;
        private Button btn_show_profile;
        private Button get_legs_info;
        private TextBox txt_flightID_leg;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button btn_view_flights;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
    }
}

