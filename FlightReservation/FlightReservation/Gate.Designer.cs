namespace FlightReservation
{
    partial class Gate
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
            label2 = new Label();
            btnAdmin = new Button();
            btnCustomer = new Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(490, 500);
            label2.Name = "label2";
            label2.Size = new Size(170, 43);
            label2.TabIndex = 7;
            label2.Text = "Start As";
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Indigo;
            btnAdmin.FlatStyle = FlatStyle.Popup;
            btnAdmin.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdmin.ForeColor = SystemColors.ControlLightLight;
            btnAdmin.Location = new Point(657, 565);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(275, 80);
            btnAdmin.TabIndex = 5;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.Indigo;
            btnCustomer.FlatAppearance.BorderColor = Color.White;
            btnCustomer.FlatAppearance.BorderSize = 40;
            btnCustomer.FlatStyle = FlatStyle.Popup;
            btnCustomer.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustomer.ForeColor = SystemColors.ControlLightLight;
            btnCustomer.Location = new Point(230, 565);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(275, 80);
            btnCustomer.TabIndex = 4;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Georgia", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.Indigo;
            guna2HtmlLabel1.Location = new Point(171, 104);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(832, 45);
            guna2HtmlLabel1.TabIndex = 9;
            guna2HtmlLabel1.Text = "Welcome To Flight Reservation Application";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = Properties.Resources.aircraft;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(232, 37);
            guna2PictureBox1.Margin = new Padding(3, 5, 3, 5);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(887, 457);
            guna2PictureBox1.TabIndex = 8;
            guna2PictureBox1.TabStop = false;
            // 
            // Gate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1167, 683);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2PictureBox1);
            Controls.Add(label2);
            Controls.Add(btnAdmin);
            Controls.Add(btnCustomer);
            Name = "Gate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gate";
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnAdmin;
        private Button btnCustomer;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}