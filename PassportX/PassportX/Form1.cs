using System;
using System.Drawing;
using System.Windows.Forms;

namespace PassportX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Add demo admin credentials
            if (username == "admin" && password == "demo123")
            {
                MessageBox.Show("Demo admin login successful!");
                // Open dashboard or perform admin actions
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                // TODO: Implement actual authentication logic
                if (username == "admin" && password == "password")
                {
                    // Create and show the Dashboard form
                    Dashboard dashboardForm = new Dashboard();
                    dashboardForm.SetWelcomeMessage(username);
                    dashboardForm.Show();

                    // Hide the login form
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(0, 122, 204), ButtonBorderStyle.Solid);
        }
    }
}
