﻿namespace PassportX
{
    partial class Dashboard
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
            lblWelcome = new Label();
            pnlNavigation = new Panel();
            btnSettings = new Button();
            btnBiometricCapture = new Button();
            btnApplicantSearch = new Button();
            btnApplicantDetails = new Button();
            btnFingerprintCapture = new Button();
            btnBiometricReview = new Button();
            pnlSessionInfo = new Panel();
            btnLogout = new Button();
            lblSessionInfo = new Label();
            pnlContent = new Panel();
            
            pnlNavigation.SuspendLayout();
            pnlSessionInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(16, 14);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(121, 29);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome!";
            // 
            // pnlNavigation
            // 
            pnlNavigation.BackColor = Color.FromArgb(24, 30, 54);
            pnlNavigation.Controls.Clear();
            pnlNavigation.Controls.Add(btnApplicantSearch);
            pnlNavigation.Controls.Add(btnApplicantDetails);
            pnlNavigation.Controls.Add(btnBiometricCapture);
            pnlNavigation.Controls.Add(btnFingerprintCapture);
            pnlNavigation.Controls.Add(btnBiometricReview);
            pnlNavigation.Controls.Add(btnSettings);
            pnlNavigation.Dock = DockStyle.Left;
            pnlNavigation.Location = new Point(0, 0);
            pnlNavigation.Name = "pnlNavigation";
            pnlNavigation.Size = new Size(230, 720);
            pnlNavigation.TabIndex = 1;
            pnlNavigation.Padding = new Padding(10, 60, 10, 10);
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(16, 624);
            btnSettings.Margin = new Padding(4, 5, 4, 5);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(233, 54);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.Margin = new Padding(0, 10, 0, 0);
            // 
            // btnBiometricCapture
            // 
            btnBiometricCapture.Location = new Point(16, 216);
            btnBiometricCapture.Margin = new Padding(4, 5, 4, 5);
            btnBiometricCapture.Name = "btnBiometricCapture";
            btnBiometricCapture.Size = new Size(233, 54);
            btnBiometricCapture.TabIndex = 1;
            btnBiometricCapture.Text = "Biometric Capture";
            btnBiometricCapture.UseVisualStyleBackColor = true;
            btnBiometricCapture.Click += btnBiometricCapture_Click;
            btnBiometricCapture.Dock = DockStyle.Top;
            // 
            // btnApplicantSearch
            // 
            btnApplicantSearch.Location = new Point(16, 91);
            btnApplicantSearch.Margin = new Padding(4, 5, 4, 5);
            btnApplicantSearch.Name = "btnApplicantSearch";
            btnApplicantSearch.Size = new Size(233, 54);
            btnApplicantSearch.TabIndex = 0;
            btnApplicantSearch.Text = "Applicant Search";
            btnApplicantSearch.UseVisualStyleBackColor = true;
            btnApplicantSearch.Click += btnApplicantSearch_Click;
            btnApplicantSearch.Dock = DockStyle.Top;
            // 
            // btnApplicantDetails
            // 
            btnApplicantDetails.Location = new Point(16, 155);
            btnApplicantDetails.Margin = new Padding(4, 5, 4, 5);
            btnApplicantDetails.Name = "btnApplicantDetails";
            btnApplicantDetails.Size = new Size(233, 54);
            btnApplicantDetails.TabIndex = 3;
            btnApplicantDetails.Text = "Applicant Details";
            btnApplicantDetails.UseVisualStyleBackColor = true;
            btnApplicantDetails.Click += btnApplicantDetails_Click;
            btnApplicantDetails.Dock = DockStyle.Top;
            // 
            // btnFingerprintCapture
            // 
            btnFingerprintCapture.Location = new Point(16, 280);
            btnFingerprintCapture.Margin = new Padding(4, 5, 4, 5);
            btnFingerprintCapture.Name = "btnFingerprintCapture";
            btnFingerprintCapture.Size = new Size(233, 54);
            btnFingerprintCapture.TabIndex = 4;
            btnFingerprintCapture.Text = "Fingerprint Capture";
            btnFingerprintCapture.UseVisualStyleBackColor = true;
            btnFingerprintCapture.Click += btnFingerprintCapture_Click;
            btnFingerprintCapture.Dock = DockStyle.Top;
            // 
            // btnBiometricReview
            // 
            btnBiometricReview.Location = new Point(16, 344);
            btnBiometricReview.Margin = new Padding(4, 5, 4, 5);
            btnBiometricReview.Name = "btnBiometricReview";
            btnBiometricReview.Size = new Size(233, 54);
            btnBiometricReview.TabIndex = 6;
            btnBiometricReview.Text = "Biometric Review";
            btnBiometricReview.UseVisualStyleBackColor = true;
            btnBiometricReview.Click += btnBiometricReview_Click;
            btnBiometricReview.Dock = DockStyle.Top;
            // 
            // pnlSessionInfo
            // 
            pnlSessionInfo.BackColor = Color.FromArgb(24, 30, 54);
            pnlSessionInfo.Controls.Clear();
            pnlSessionInfo.Controls.Add(btnLogout);
            pnlSessionInfo.Controls.Add(lblSessionInfo);
            pnlSessionInfo.Dock = DockStyle.Top;
            pnlSessionInfo.Height = 60;
            pnlSessionInfo.Padding = new Padding(10);

            btnLogout.Anchor = AnchorStyles.Right;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.FromArgb(0, 126, 249);
            btnLogout.Text = "Logout";
            btnLogout.Size = new Size(100, 40);
            btnLogout.Location = new Point(pnlSessionInfo.Width - btnLogout.Width - 10, 10);

            lblSessionInfo.AutoSize = true;
            lblSessionInfo.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblSessionInfo.ForeColor = Color.FromArgb(0, 126, 249);
            lblSessionInfo.Location = new Point(10, 20);

            // Add a Resize event handler to pnlSessionInfo to keep the layout correct when resizing
            pnlSessionInfo.Resize += (sender, e) => UpdateSessionInfoLayout();

            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(687, 19);
            btnLogout.Margin = new Padding(4, 5, 4, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 35);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblSessionInfo
            // 
            lblSessionInfo.AutoSize = true;
            lblSessionInfo.Location = new Point(578, 26);
            lblSessionInfo.Margin = new Padding(4, 0, 4, 0);
            lblSessionInfo.Name = "lblSessionInfo";
            lblSessionInfo.Size = new Size(101, 20);
            lblSessionInfo.TabIndex = 0;
            lblSessionInfo.Text = "Logged in as: ";
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(pnlSessionInfo);
            this.Controls.Add(pnlNavigation);
            this.Controls.Add(pnlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            pnlNavigation.ResumeLayout(false);
            pnlSessionInfo.ResumeLayout(false);
            pnlSessionInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

            // Set consistent margins for all buttons
            foreach (Control control in pnlNavigation.Controls)
            {
                if (control is Button button)
                {
                    button.Margin = new Padding(0, 0, 0, 10);
                }
            }
        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnBiometricCapture;
        private System.Windows.Forms.Button btnApplicantSearch;
        private System.Windows.Forms.Panel pnlSessionInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblSessionInfo;
        private System.Windows.Forms.Button btnApplicantDetails;
        private System.Windows.Forms.Button btnFingerprintCapture;
        private System.Windows.Forms.Button btnBiometricReview;
        private System.Windows.Forms.Panel pnlContent;

        // Add this method to the Dashboard class
        private void UpdateSessionInfoLayout()
        {
            btnLogout.Location = new Point(pnlSessionInfo.Width - btnLogout.Width - 10, (pnlSessionInfo.Height - btnLogout.Height) / 2);
            lblSessionInfo.Location = new Point(pnlSessionInfo.Width - btnLogout.Width - lblSessionInfo.Width - 20, (pnlSessionInfo.Height - lblSessionInfo.Height) / 2);
        }

        private void StyleButton(Button btn, string iconName)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn.ForeColor = Color.FromArgb(0, 126, 249);
            btn.Image = Image.FromFile($"icons/{iconName}.png");
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(10, 0, 0, 0);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.Size = new Size(210, 45);
            btn.Dock = DockStyle.Top;
            btn.Margin = new Padding(0, 0, 0, 10);
        }
    }
}
