using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class BasicStepOne : Form
    {
        public BasicStepOne()
        {
            InitializeComponent();
            LayoutSetup();
        }

        // Variables
        int region;

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

        // Format Design Of Page
        private void LayoutSetup()
        {
            // Align controls horizontally
            lblMain.Left = (int)(panelMain.Width * 0.5f - lblMain.Width * 0.5f);
            lblRegion.Left = (int)(panelMain.Width * 0.5f - lblRegion.Width * 0.5f);
            cboRegion.Left = (int)(panelMain.Width * 0.5f - cboRegion.Width * 0.5f);
            picHeatMap.Left = (int)(panelMain.Width * 0.5f - picHeatMap.Width * 0.5f);
            btnHome.Left = (int)(panelMain.Width * 0.5f - btnHome.Width * 0.5f);
            picErrorOne.Left = (int)(panelMain.Width * 0.5f + cboRegion.Width * 0.5f + 5);

            //ToolTip design
            myToolTip.OwnerDraw = true;
            myToolTip.InitialDelay = 0;
            myToolTip.ReshowDelay = 0;
            myToolTip.BackColor = Color.FromArgb(61, 59, 60);
            myToolTip.ForeColor = Color.FromArgb(40, 146, 215);
        }

        // Next Page Button
        private void btnForm2Next_Click(object sender, EventArgs e)
        {
            // Check region from user
            region = cboRegion.SelectedIndex + 1;

            // If incorrect selection, display error image
            if (region < 0)
            {
                picErrorOne.Visible = true;
            }
            // If correct selection, assign value and progress to next step
            else
            {
                BasicCalculation.Region = region;
                OpenChildForm(new BasicStepTwo());
            }
        }

        // Home Page Button
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home());
        }

        // ToolTip Draw Event
        private void myToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }
    }
}
