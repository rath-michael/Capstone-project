using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    // Delegate needed to change button background color upon hover in Main form
    public delegate void ChangeBackColor();

    public partial class Home : Form
    {
        // Set up events to change Main Form control colors upon hover
        public event ChangeBackColor GetStartedToColor;
        public event ChangeBackColor GetStartedBackColor;
        public event ChangeBackColor HelpToColor;
        public event ChangeBackColor HelpBackColor;
        public event ChangeBackColor HistoryToColor;
        public event ChangeBackColor HistoryBackColor;

        public Home()
        {
            InitializeComponent();
            LayoutSetup();
        }

        public void LayoutSetup()
        {
            // Get system time and display correct greeting
            DateTime now = DateTime.Now;

            if (now.Hour > 4 && now.Hour <= 12)
            {
                lblHeader.Text = "Good Morning!";
            }
            else if (now.Hour > 12 && now.Hour <= 17)
            {
                lblHeader.Text = "Good Afternoon!";
            }
            else
            {
                lblHeader.Text = "Good Evening!";
            }

            //Align controls horizontally
            lblHeader.Left = (int)(panelMain.Width * 0.5f - lblHeader.Width * 0.5f);
            panelBackground.Left = (int)(panelMain.Width * 0.5f - panelBackground.Width * 0.5f);
            lblGetStarted.Left = (int)(panelBackground.Width * 0.5f - lblGetStarted.Width * 0.5f);
            lblHelp.Left = (int)(panelBackground.Width * 0.5f - lblHelp.Width * 0.5f);
            lblHistory.Left = (int)(panelBackground.Width * 0.5f - lblHistory.Width * 0.5f);
            lblParagraph.Left = (int)(panelBackground.Width * 0.5f - lblParagraph.Width * 0.5f);
        }

        // Display image when mouse hovers over label
        private void lblGetStarted_MouseEnter(object sender, EventArgs e)
        {
            GetStartedToColor?.Invoke();
        }

        // Remove image when mouse no longer hovers over label
        private void lblGetStarted_MouseLeave(object sender, EventArgs e)
        {
            GetStartedBackColor?.Invoke();
        }

        // Display image when mouse hovers over label
        private void lblHelp_MouseEnter(object sender, EventArgs e)
        {
            HelpToColor?.Invoke();
        }

        // Remove image when mouse no longer hovers over label
        private void lblHelp_MouseLeave(object sender, EventArgs e)
        {
            HelpBackColor?.Invoke();
        }

        // Display image when mouse hovers over label
        private void lblHistory_MouseEnter(object sender, EventArgs e)
        {
            HistoryToColor?.Invoke();
        }

        // Remove image when mouse no longer hovers over label
        private void lblHistory_MouseLeave(object sender, EventArgs e)
        {
            HistoryBackColor?.Invoke();
        }
    }
}
