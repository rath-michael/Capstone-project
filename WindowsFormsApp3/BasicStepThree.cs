using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class BasicStepThree : Form
    {
        public BasicStepThree()
        {
            InitializeComponent();
            LayoutSetup();
        }

        // Variables
        int numOccupants;
        int numAppliances;
        string kitchen;

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
            panelKitchen.Left = (int)(panelMain.Width * 0.5f - panelKitchen.Width * 0.5f);
            lblUsername.Left = (int)(panelMain.Width * 0.5f - lblUsername.Width * 0.5f);
            txtUsername.Left = (int)(panelMain.Width * 0.5f - txtUsername.Width * 0.5f);
            btnHome.Left = (int)(panelMain.Width * 0.5f - btnHome.Width * 0.5f);

            //ToolTip design
            toolTip1.OwnerDraw = true;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 0;
            toolTip1.BackColor = Color.FromArgb(61, 59, 60);
            toolTip1.ForeColor = Color.FromArgb(40, 146, 215);
        }

        // Next Page Button
        private void button2_Click(object sender, EventArgs e)
        {
            // Variable to track if steps complete
            bool complete = true;

            // Reset all error images
            picErrorOne.Visible = false;
            picErrorTwo.Visible = false;
            picErrorThree.Visible = false;

            // Check occupants, if unsuccessful set completion tracker to false and display error image
            try
            {
                numOccupants = int.Parse(txtOccupants.Text);
            }
            catch (Exception)
            {
                complete = false;
                picErrorOne.Visible = true;
            }

            // Check appliances, if unsuccessful set completion tracker to false and display error image
            try
            {
                numAppliances = int.Parse(txtAppliances.Text);
            }
            catch (Exception)
            {
                complete = false;
                picErrorTwo.Visible = true;
            }

            // Check kitchen, if unsuccessful set completion tracker to false and display error image
            if (radYes.Checked == true)
            {
                kitchen = "Yes";
            }
            else if (radNo.Checked == true)
            {
                kitchen = "No";
            }
            else
            {
                picErrorThree.Visible = true;
                complete = false;
            }

            // Check for username, if not empty assign value
            if (txtUsername.Text != null)
            {
                BasicCalculation.Username = txtUsername.Text;
            }

            // If completion tracker true, assign values and progress
            if (complete)
            {
                BasicCalculation.NumOccupants = numOccupants;
                BasicCalculation.NumAppliances = numAppliances;
                BasicCalculation.Kitchen = kitchen;
                OpenChildForm(new BasicStepFour());
            }
        }

        // Previous Page Button
        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BasicStepTwo());
        }

        // Occupants Help Button
        private void btnQuestionOccupants_Click(object sender, EventArgs e)
        {
            string message = "The total number of people living in the home.";
            CustomMessageBox messageBox = new CustomMessageBox(message);
            DialogResult result = messageBox.ShowDialog();
            if (result == DialogResult.OK)
            {
                messageBox.Close();
            }
        }

        // Appliances Help Button
        private void btnQuestionAppliances_Click(object sender, EventArgs e)
        {
            string message = "Heat producing appliances include:\n" +
                "Washing / Drying Maching, Regrigerator,\n" +
                "Dishwashing Machine, Oven / Stovetop.";
            CustomMessageBox messageBox = new CustomMessageBox(message);
            DialogResult result = messageBox.ShowDialog();
            if (result == DialogResult.OK)
            {
                messageBox.Close();
            }
        }

        // Home Page Button
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home());
        }

        // ToolTip Draw Event
        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }
    }
}
