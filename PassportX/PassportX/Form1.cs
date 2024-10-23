using System;
using System.Windows.Forms;

namespace PassportX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
