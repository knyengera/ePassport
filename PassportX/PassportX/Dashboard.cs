using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassportX
{
    public partial class Dashboard : Form
    {
        private string currentUsername = string.Empty;

        public Dashboard()
        {
            InitializeComponent();
        }

        // Add this method to customize the welcome message
        public void SetWelcomeMessage(string username)
        {
            currentUsername = username;
            lblWelcome.Text = $"Welcome, {username}!";
            lblSessionInfo.Text = $"Logged in as: {username}";
            lblSessionInfo.Left = pnlSessionInfo.Width - lblSessionInfo.Width - btnLogout.Width - 20; // Adjust the 20 as needed for spacing
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                var loginForm = Application.OpenForms["Form1"];
                if (loginForm != null)
                {
                    loginForm.Show();
                }
                else
                {
                    // Handle the case when the login form is not found
                    Application.Exit();
                }
            }
        }

        private void btnApplicantSearch_Click(object sender, EventArgs e)
        {
            ApplicantSearchForm applicantSearchForm = new ApplicantSearchForm();
            applicantSearchForm.Show();
        }

        private void btnApplicantDetails_Click(object sender, EventArgs e)
        {
            ApplicantDetailsForm applicantDetailsForm = new ApplicantDetailsForm();
            applicantDetailsForm.Show();
        }

        private void btnFingerprintCapture_Click(object sender, EventArgs e)
        {
            FingerprintCaptureForm fingerprintCaptureForm = new FingerprintCaptureForm();
            fingerprintCaptureForm.Show();
        }

        private void btnBiometricReview_Click(object sender, EventArgs e)
        {
            BiometricReviewForm biometricReviewForm = new BiometricReviewForm();
            biometricReviewForm.Show();
        }

        private void btnBiometricCapture_Click(object sender, EventArgs e)
        {
            // TODO: Implement biometric capture functionality
            MessageBox.Show("Biometric Capture functionality not yet implemented.");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings functionality to be implemented.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pnlSessionInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = Color.FromArgb(46, 51, 73);
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = Color.Transparent;
            }
        }

        private void AttachHoverEvents()
        {
            foreach (Control control in pnlNavigation.Controls)
            {
                if (control is Button btn)
                {
                    btn.MouseEnter += Button_MouseEnter;
                    btn.MouseLeave += Button_MouseLeave;
                }
            }
        }
    }
}
