namespace FlightReservation
{
    partial class Tickets
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btn_show_profile = new Button();
            button2 = new Button();
            label1 = new Label();
            txt_ticketID_info = new TextBox();
            flightId = new Label();
            btn_get_ticket_info = new Button();
            button1 = new Button();
            dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_show_profile
            // 
            btn_show_profile.BackColor = Color.LightSkyBlue;
            btn_show_profile.FlatAppearance.BorderSize = 0;
            btn_show_profile.FlatStyle = FlatStyle.Flat;
            btn_show_profile.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_show_profile.ForeColor = SystemColors.ActiveCaptionText;
            btn_show_profile.Location = new Point(693, 41);
            btn_show_profile.Margin = new Padding(3, 4, 3, 4);
            btn_show_profile.Name = "btn_show_profile";
            btn_show_profile.Size = new Size(111, 46);
            btn_show_profile.TabIndex = 27;
            btn_show_profile.Text = "Profile";
            btn_show_profile.UseVisualStyleBackColor = false;
            btn_show_profile.Click += btn_show_profile_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(693, 208);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(111, 45);
            button2.TabIndex = 26;
            button2.Text = "Log Out";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(61, 44);
            label1.Name = "label1";
            label1.Size = new Size(341, 43);
            label1.TabIndex = 19;
            label1.Text = "Reserved Tickets";
            // 
            // txt_ticketID_info
            // 
            txt_ticketID_info.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ticketID_info.Location = new Point(230, 123);
            txt_ticketID_info.Margin = new Padding(3, 4, 3, 4);
            txt_ticketID_info.Name = "txt_ticketID_info";
            txt_ticketID_info.Size = new Size(121, 31);
            txt_ticketID_info.TabIndex = 17;
            // 
            // flightId
            // 
            flightId.AutoSize = true;
            flightId.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            flightId.Location = new Point(112, 127);
            flightId.Name = "flightId";
            flightId.Size = new Size(92, 22);
            flightId.TabIndex = 16;
            flightId.Text = "Ticket ID";
            // 
            // btn_get_ticket_info
            // 
            btn_get_ticket_info.BackColor = Color.Indigo;
            btn_get_ticket_info.FlatStyle = FlatStyle.Flat;
            btn_get_ticket_info.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_get_ticket_info.ForeColor = SystemColors.ControlLightLight;
            btn_get_ticket_info.Location = new Point(387, 123);
            btn_get_ticket_info.Margin = new Padding(3, 4, 3, 4);
            btn_get_ticket_info.Name = "btn_get_ticket_info";
            btn_get_ticket_info.Size = new Size(120, 31);
            btn_get_ticket_info.TabIndex = 15;
            btn_get_ticket_info.Text = "Get Info";
            btn_get_ticket_info.UseVisualStyleBackColor = false;
            btn_get_ticket_info.Click += btn_get_ticket_info_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(693, 116);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(111, 70);
            button1.TabIndex = 28;
            button1.Text = "Availiable Flights";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            dataGridView1.Location = new Point(61, 211);
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
            dataGridView1.Size = new Size(567, 320);
            dataGridView1.TabIndex = 29;
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
            // Tickets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(828, 587);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(btn_show_profile);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(txt_ticketID_info);
            Controls.Add(flightId);
            Controls.Add(btn_get_ticket_info);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Tickets";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tickets";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_show_profile;
        private Button button2;
        private Label label1;
        private TextBox txt_ticketID_info;
        private Label flightId;
        private Button btn_get_ticket_info;
        private Button button1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
    }
}