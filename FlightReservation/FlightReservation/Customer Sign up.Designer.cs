namespace FlightReservation
{
    partial class Customer_Sign_up
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            btnLogin = new Button();
            comboGender = new ComboBox();
            timeDOB = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            txtAge = new TextBox();
            label6 = new Label();
            label3 = new Label();
            txtPhone = new TextBox();
            txtName = new TextBox();
            btnSignup = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = Properties.Resources.customer_login_aircraft2;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(47, 89);
            guna2PictureBox1.Margin = new Padding(5, 4, 5, 4);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(531, 491);
            guna2PictureBox1.TabIndex = 51;
            guna2PictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Indigo;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(994, 682);
            btnLogin.Margin = new Padding(5, 4, 5, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(117, 39);
            btnLogin.TabIndex = 69;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // comboGender
            // 
            comboGender.FormattingEnabled = true;
            comboGender.Items.AddRange(new object[] { "Male", "Female" });
            comboGender.Location = new Point(813, 464);
            comboGender.Margin = new Padding(5, 4, 5, 4);
            comboGender.Name = "comboGender";
            comboGender.Size = new Size(347, 35);
            comboGender.TabIndex = 67;
            // 
            // timeDOB
            // 
            timeDOB.CalendarFont = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            timeDOB.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            timeDOB.Location = new Point(810, 189);
            timeDOB.Margin = new Padding(5, 4, 5, 4);
            timeDOB.Name = "timeDOB";
            timeDOB.Size = new Size(347, 29);
            timeDOB.TabIndex = 66;
            timeDOB.ValueChanged += timeDOB_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(623, 189);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(154, 27);
            label8.TabIndex = 65;
            label8.Text = "Date of Birth";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(626, 467);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(96, 27);
            label7.TabIndex = 64;
            label7.Text = "Gender";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(813, 532);
            txtAge.Margin = new Padding(5, 4, 5, 4);
            txtAge.Name = "txtAge";
            txtAge.ReadOnly = true;
            txtAge.Size = new Size(347, 31);
            txtAge.TabIndex = 63;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(626, 532);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 27);
            label6.TabIndex = 62;
            label6.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(691, 35);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(393, 46);
            label3.TabIndex = 61;
            label3.Text = "Customer Sign Up";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(813, 394);
            txtPhone.Margin = new Padding(5, 4, 5, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(347, 31);
            txtPhone.TabIndex = 60;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(810, 118);
            txtName.Margin = new Padding(5, 4, 5, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(347, 31);
            txtName.TabIndex = 59;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.Indigo;
            btnSignup.FlatAppearance.BorderColor = Color.Indigo;
            btnSignup.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignup.ForeColor = SystemColors.ControlLightLight;
            btnSignup.Location = new Point(810, 609);
            btnSignup.Margin = new Padding(5, 4, 5, 4);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(137, 47);
            btnSignup.TabIndex = 56;
            btnSignup.Text = "Sign up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(813, 325);
            txtPassword.Margin = new Padding(5, 4, 5, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(347, 31);
            txtPassword.TabIndex = 55;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(813, 253);
            txtEmail.Margin = new Padding(5, 4, 5, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(347, 31);
            txtEmail.TabIndex = 54;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(626, 398);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(175, 27);
            label10.TabIndex = 73;
            label10.Text = "Phone number";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(626, 122);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(77, 27);
            label11.TabIndex = 72;
            label11.Text = "Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(626, 329);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(122, 27);
            label12.TabIndex = 71;
            label12.Text = "Password";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(626, 257);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(73, 27);
            label13.TabIndex = 70;
            label13.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(682, 686);
            label1.Name = "label1";
            label1.Size = new Size(304, 27);
            label1.TabIndex = 74;
            label1.Text = "Already have an account?";
            // 
            // Customer_Sign_up
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1314, 752);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(btnLogin);
            Controls.Add(comboGender);
            Controls.Add(timeDOB);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtAge);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(btnSignup);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(guna2PictureBox1);
            Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Customer_Sign_up";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer_Sign_up";
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Button btnLogin;
        private ComboBox comboGender;
        private DateTimePicker timeDOB;
        private Label label8;
        private Label label7;
        private TextBox txtAge;
        private Label label6;
        private Label label3;
        private TextBox txtPhone;
        private TextBox txtName;
        private Button btnSignup;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label1;
    }
}