namespace FlightReservation
{
    partial class CustomerProfile
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
            label1 = new Label();
            txt_cust_name = new TextBox();
            txt_cust_phone = new TextBox();
            txt_cust_age = new TextBox();
            txt_cust_gender = new TextBox();
            txt_cust_email = new TextBox();
            txt_cust_password = new TextBox();
            txt_cust_id = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btn_update_profile = new Button();
            button2 = new Button();
            back_view = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Georgia", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(98, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(241, 43);
            label1.TabIndex = 0;
            label1.Text = "Profile Info";
            // 
            // txt_cust_name
            // 
            txt_cust_name.Location = new Point(270, 138);
            txt_cust_name.Margin = new Padding(4);
            txt_cust_name.Name = "txt_cust_name";
            txt_cust_name.Size = new Size(246, 27);
            txt_cust_name.TabIndex = 1;
            // 
            // txt_cust_phone
            // 
            txt_cust_phone.Location = new Point(270, 382);
            txt_cust_phone.Margin = new Padding(4);
            txt_cust_phone.Name = "txt_cust_phone";
            txt_cust_phone.Size = new Size(246, 27);
            txt_cust_phone.TabIndex = 4;
            // 
            // txt_cust_age
            // 
            txt_cust_age.Location = new Point(270, 215);
            txt_cust_age.Margin = new Padding(4);
            txt_cust_age.Name = "txt_cust_age";
            txt_cust_age.ReadOnly = true;
            txt_cust_age.Size = new Size(246, 27);
            txt_cust_age.TabIndex = 6;
            // 
            // txt_cust_gender
            // 
            txt_cust_gender.Location = new Point(720, 212);
            txt_cust_gender.Margin = new Padding(4);
            txt_cust_gender.Name = "txt_cust_gender";
            txt_cust_gender.ReadOnly = true;
            txt_cust_gender.Size = new Size(246, 27);
            txt_cust_gender.TabIndex = 10;
            // 
            // txt_cust_email
            // 
            txt_cust_email.Location = new Point(270, 300);
            txt_cust_email.Margin = new Padding(4);
            txt_cust_email.Name = "txt_cust_email";
            txt_cust_email.Size = new Size(246, 27);
            txt_cust_email.TabIndex = 9;
            // 
            // txt_cust_password
            // 
            txt_cust_password.Location = new Point(720, 297);
            txt_cust_password.Margin = new Padding(4);
            txt_cust_password.Name = "txt_cust_password";
            txt_cust_password.Size = new Size(246, 27);
            txt_cust_password.TabIndex = 8;
            // 
            // txt_cust_id
            // 
            txt_cust_id.Location = new Point(720, 138);
            txt_cust_id.Margin = new Padding(4);
            txt_cust_id.Name = "txt_cust_id";
            txt_cust_id.ReadOnly = true;
            txt_cust_id.Size = new Size(246, 27);
            txt_cust_id.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(98, 215);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 22);
            label2.TabIndex = 11;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(98, 138);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 22);
            label3.TabIndex = 12;
            label3.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(98, 382);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(145, 22);
            label5.TabIndex = 14;
            label5.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(580, 302);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 22);
            label6.TabIndex = 18;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(98, 300);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(61, 22);
            label7.TabIndex = 17;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(580, 140);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(30, 22);
            label8.TabIndex = 16;
            label8.Text = "ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(580, 217);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(78, 22);
            label9.TabIndex = 15;
            label9.Text = "Gender";
            // 
            // btn_update_profile
            // 
            btn_update_profile.BackColor = Color.Indigo;
            btn_update_profile.FlatStyle = FlatStyle.Flat;
            btn_update_profile.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_update_profile.ForeColor = SystemColors.ControlLightLight;
            btn_update_profile.Location = new Point(497, 463);
            btn_update_profile.Margin = new Padding(4);
            btn_update_profile.Name = "btn_update_profile";
            btn_update_profile.Size = new Size(161, 48);
            btn_update_profile.TabIndex = 19;
            btn_update_profile.Text = "Update";
            btn_update_profile.UseVisualStyleBackColor = false;
            btn_update_profile.Click += btn_update_profile_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1012, 39);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(111, 70);
            button2.TabIndex = 20;
            button2.Text = "View My Tickets";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // back_view
            // 
            back_view.BackColor = Color.LightSkyBlue;
            back_view.FlatAppearance.BorderSize = 0;
            back_view.FlatStyle = FlatStyle.Flat;
            back_view.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            back_view.Location = new Point(1012, 138);
            back_view.Margin = new Padding(4);
            back_view.Name = "back_view";
            back_view.Size = new Size(111, 70);
            back_view.TabIndex = 22;
            back_view.Text = "Availiable Flights";
            back_view.UseVisualStyleBackColor = false;
            back_view.Click += back_view_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(1012, 235);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(111, 40);
            button1.TabIndex = 23;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CustomerProfile
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1148, 550);
            Controls.Add(button1);
            Controls.Add(back_view);
            Controls.Add(button2);
            Controls.Add(btn_update_profile);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_cust_gender);
            Controls.Add(txt_cust_email);
            Controls.Add(txt_cust_password);
            Controls.Add(txt_cust_id);
            Controls.Add(txt_cust_age);
            Controls.Add(txt_cust_phone);
            Controls.Add(txt_cust_name);
            Controls.Add(label1);
            Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CustomerProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            Load += CustomerProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_cust_name;
        private TextBox txt_cust_phone;
        private TextBox txt_cust_age;
        private TextBox txt_cust_gender;
        private TextBox txt_cust_email;
        private TextBox txt_cust_password;
        private TextBox txt_cust_id;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btn_update_profile;
        private Button button2;
        private Button back_view;
        private Button button1;
    }
}