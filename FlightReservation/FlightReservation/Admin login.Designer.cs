namespace FlightReservation
{
    partial class Admin_login
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
            btnSignup = new Button();
            btnLogin = new Button();
            label3 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.Indigo;
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignup.ForeColor = SystemColors.ButtonHighlight;
            btnSignup.Location = new Point(829, 364);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(108, 36);
            btnSignup.TabIndex = 14;
            btnSignup.Text = "Sign up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Indigo;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(710, 286);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(137, 49);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Login ";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(604, 359);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(739, 215);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 31);
            txtPassword.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(739, 159);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 31);
            txtEmail.TabIndex = 10;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = Properties.Resources.customer_login_aircraft2;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(30, 12);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(558, 464);
            guna2PictureBox1.TabIndex = 50;
            guna2PictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(594, 223);
            label5.Name = "label5";
            label5.Size = new Size(107, 23);
            label5.TabIndex = 52;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(594, 163);
            label6.Name = "label6";
            label6.Size = new Size(63, 23);
            label6.TabIndex = 51;
            label6.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Indigo;
            label4.Location = new Point(628, 88);
            label4.Name = "label4";
            label4.Size = new Size(267, 43);
            label4.TabIndex = 53;
            label4.Text = "Admin Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(628, 371);
            label1.Name = "label1";
            label1.Size = new Size(195, 22);
            label1.TabIndex = 54;
            label1.Text = "Don't have account?";
            // 
            // Admin_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1019, 487);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(guna2PictureBox1);
            Controls.Add(btnSignup);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Name = "Admin_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_login";
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSignup;
        private Button btnLogin;
        private Label label3;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label1;
    }
}