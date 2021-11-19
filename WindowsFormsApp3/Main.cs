using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public Main(bool weatherComplete)
        {
            InitializeComponent();
            InitializeMenus();
            LayoutSetup();
            DisplayWeatherInfo(weatherComplete);
        }

        // Variables
        public static string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\micha\source\repos\WindowsFormsApp3\WindowsFormsApp3\Database1.mdf; Integrated Security = True";

        // Method to display weather data
        private void DisplayWeatherInfo(bool weatherComplete)
        {
            // If weather data was found display, else show failure panel
            if (weatherComplete)
            {
                // Display weather condition
                lblWeatherCondition.Visible = true;
                lblWeatherCondition.Text = LoadingPage.weatherCondition;

                // Display temperature
                lblTemp.Visible = true;
                lblTemp.Text = LoadingPage.temperature;

                // Display weather icon image
                string icon = LoadingPage.weatherImage;

                // Dictionary to hold icon/image pairings
                Dictionary<string, Bitmap> images = new Dictionary<string, Bitmap>();
                images.Add("01d", Properties.Resources._01d);
                images.Add("01n", Properties.Resources._01n);
                images.Add("02d", Properties.Resources._02d);
                images.Add("02n", Properties.Resources._02n);
                images.Add("03d", Properties.Resources._03d);
                images.Add("03n", Properties.Resources._03n);
                images.Add("04d", Properties.Resources._04d);
                images.Add("04n", Properties.Resources._04n);
                images.Add("09d", Properties.Resources._09d);
                images.Add("09n", Properties.Resources._09n);
                images.Add("10d", Properties.Resources._10d);
                images.Add("10n", Properties.Resources._10n);
                images.Add("11d", Properties.Resources._11d);
                images.Add("11n", Properties.Resources._11n);
                images.Add("13d", Properties.Resources._13d);
                images.Add("13n", Properties.Resources._13n);
                images.Add("50d", Properties.Resources._50d);
                images.Add("50n", Properties.Resources._50n);

                // Iterate dictionary and display correct image
                foreach (KeyValuePair<string, Bitmap> item in images)
                {
                    if (item.Key == icon)
                    {
                        picWeatherIcon.Image = item.Value;
                    }
                }
            }
            else
            {
                panelWeatherFail.Visible = true;
            }
        }

        // Form/Panel Controls
        private Form activeForm = null;

        // Method to open and display new form
        private void OpenChildForm(Form childForm)
        {
            // Verify current active form is null, else close current active form
            if (activeForm != null)
            {
                activeForm.Close();
            }

            // Set newly passed form as active form
            activeForm = childForm;

            // Make sure new form is not set as parent container
            childForm.TopLevel = false;

            // Set BorderStyle to none
            childForm.FormBorderStyle = FormBorderStyle.None;

            // Set DockStyle to fill
            childForm.Dock = DockStyle.Fill;

            // Add newly passed childForm controls to parent
            panelMain.Controls.Add(childForm);

            // Add all data from newly passed form to parent
            panelMain.Tag = childForm;

            // Bring newly passed form to front of z-order
            childForm.BringToFront();

            // Make newly passed form visible
            childForm.Show();
        }

        private void LayoutSetup()
        {
            // Align controls hoizontally
            picWeatherIcon.Left = (int)(panelSideMenu.Width * 0.5f - picWeatherIcon.Width * 0.5f);

            // ToolTip design
            toolTip1.OwnerDraw = true;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 0;
            toolTip1.BackColor = Color.FromArgb(61, 59, 60);
            toolTip1.ForeColor = Color.FromArgb(40, 146, 215);

            // Create new home instance to load from and attach color changing events
            Home home = new Home();
            
            // Load new Home form
            OpenChildForm(home);

            // Attach color changing events to Home form
            home.GetStartedToColor += new ChangeBackColor(getStartedNewColor);
            home.GetStartedBackColor += new ChangeBackColor(getStartedOldColor);
            home.HelpToColor += new ChangeBackColor(helpNewColor);
            home.HelpBackColor += new ChangeBackColor(helpOldColor);
            home.HistoryToColor += new ChangeBackColor(historyNewColor);
            home.HistoryBackColor += new ChangeBackColor(historyOldColor);
        }

        // Initial layout of menus
        public void InitializeMenus()
        {
            this.AutoSize = true;
            panelGetStarted.Visible = false;
            panelHelp.Visible = false;
            panelAccount.Visible = false;
        }

        // Method to hide menus
        public void HideMenu()
        {
            if (panelGetStarted.Visible == true) panelGetStarted.Visible = false;
            if (panelHelp.Visible == true) panelHelp.Visible = false;
            if (panelAccount.Visible == true) panelAccount.Visible = false;
        }

        // Method to change panel visibility on request
        public void ShowMenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                HideMenu();
                menu.Visible = true;
            }
            else
            {
                menu.Visible = false;
            }
        }

        // Show Get Started Menu
        private void btnGetStarted_Click(object sender, EventArgs e)
        {
            ShowMenu(panelGetStarted);
        }

        // Basic Calculation Start Button
        private void btnBasicEdition_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BasicStepOne());
            HideMenu();
        }

        // Advanced Calculation Start Button
        private void btnAdvancedEdition_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdvancedStepOne());
            HideMenu();
        }

        // Show Help Menu
        private void btnHelp_Click(object sender, EventArgs e)
        {
            ShowMenu(panelHelp);
        }

        // How It Works Page Button
        private void btnHowItWorks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HowItWorks());
            HideMenu();
        }

        // Contact Us Page Button
        private void btnContactUs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ContactUs());
            HideMenu();
        }

        // Show History Menu
        private void btnAccount_Click(object sender, EventArgs e)
        {
            ShowMenu(panelAccount);
        }

        // Search Page Button
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Search());
            HideMenu();
        }

        // View All Page Button
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewAll());
            HideMenu();
        }

        // Exit Program Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Maximize Program Button
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        // Minimize Program Button
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        // ToolTip Draw Event
        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        // Method to change button to hover color
        void getStartedNewColor()
        {
            btnGetStarted.BackColor = Color.FromArgb(104, 99, 122);
        }

        //Method to change button back to original color
        void getStartedOldColor()
        {
            btnGetStarted.BackColor = Color.FromArgb(87, 83, 102);
        }
        // Method to change button to hover color
        void helpNewColor()
        {
            btnHelp.BackColor = Color.FromArgb(104, 99, 122);
        }
        //Method to change button back to original color
        void helpOldColor()
        {
            btnHelp.BackColor = Color.FromArgb(87, 83, 102);
        }
        // Method to change button to hover color
        void historyNewColor()
        {
            btnHistory.BackColor = Color.FromArgb(104, 99, 122);
        }
        //Method to change button back to original color
        void historyOldColor()
        {
            btnHistory.BackColor = Color.FromArgb(87, 83, 102);
        }
    }
}
