using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PassportX
{
    public partial class SplashScreen : Form
    {
        private System.Windows.Forms.Timer timer;
        private int progressValue = 0;

        public SplashScreen()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = Color.Transparent;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 30; // Update every 30ms for smooth animation
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            progressValue += 1;
            if (progressValue >= 100)
            {
                timer.Stop();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
            this.Invalidate(); // Force a redraw
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw "PassportX" text in solid white
            using (SolidBrush lightGrayBrush = new SolidBrush(Color.FromArgb(200, 255, 255, 255)))
            {
                g.DrawString("PassportX", new Font("Arial", 24, FontStyle.Bold), lightGrayBrush, new PointF(40, 50));
                g.DrawString("v1.0.0", new Font("Arial", 12), lightGrayBrush, new PointF(50, 95));
            }

            // Draw additional text
            using (SolidBrush lightGrayBrush = new SolidBrush(Color.FromArgb(200, 255, 255, 255)))
            {
                g.DrawString("Fast, Secure, and Digital – The Future of Passport Processing", new Font("Arial", 12, FontStyle.Bold), lightGrayBrush, new RectangleF(50, 130, this.Width - 100, 40));
                
                string licenseText = "This application is licensed under the Proprietary License.\n" +
                                     "Unauthorized reproduction or distribution of this software, or any portion of it, may result in severe civil and criminal penalties, and will be prosecuted to the maximum extent possible under the law.";
                g.DrawString(licenseText, new Font("Arial", 8), lightGrayBrush, new RectangleF(50, 180, this.Width - 100, 80));

                g.DrawString("For more information or support, visit www.rapidhive.com/passportx.", new Font("Arial", 8), lightGrayBrush, new RectangleF(50, this.Height - 180, this.Width - 100, 20));
            }

            // Draw progress bar
            int barWidth = this.Width - 100;
            int barHeight = 10;
            int barX = 50;
            int barY = this.Height - 70;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Point(barX, barY),
                new Point(barX + barWidth, barY),
                Color.FromArgb(0, 122, 204),  // Start color (blue)
                Color.FromArgb(76, 217, 100)  // End color (green)
            ))
            {
                // Draw background
                g.FillRectangle(new SolidBrush(Color.FromArgb(30, 255, 255, 255)), barX, barY, barWidth, barHeight);

                // Draw progress
                int progressWidth = (int)((progressValue / 100.0) * barWidth);
                g.FillRectangle(brush, barX, barY, progressWidth, barHeight);
            }

            // Draw percentage text

            SolidBrush whiteBrush = new SolidBrush(Color.FromArgb(200, 255, 255, 255));
            string percentText = $"{progressValue}%";
            SizeF textSize = g.MeasureString(percentText, new Font("Arial", 12));
            g.DrawString(percentText, new Font("Arial", 10), whiteBrush, 
                new PointF(barX + (barWidth - textSize.Width) / 2, barY - textSize.Height - 5));
        }
    }
}
