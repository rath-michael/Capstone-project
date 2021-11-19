using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class BasicStepTwo : Form
    {
        public BasicStepTwo()
        {
            InitializeComponent();
            LayoutSetup();
        }

        // Variables
        bool complete;
        int squareFeet;
        string insulation;
        string sunExposure;
        string winDoorTightness;

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
            // Reset error logo's after each check
            picErrorOne.Visible = false;
            picErrorTwo.Visible = false;
            picErrorThree.Visible = false;
            picErrorFour.Visible = false;

            // Reset completion tracker before each try
            complete = true;

            // Check square foot, if unsuccessful set completion tracker to false and display error image
            try
            {
                squareFeet = int.Parse(txtSquareFoot.Text);
            }
            catch (Exception)
            {
                complete = false;
                picErrorOne.Visible = true;
            }
            
            // Check insulation/exposure/seal
            CheckInsulation();
            CheckSunExposure();
            CheckSeal();

            // If all pass completion, assign values and progress
            if (complete)
            {
                BasicCalculation.SquareFeet = squareFeet;
                OpenChildForm(new BasicStepThree());
            }
        }

        // Previous Page Button
        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BasicStepOne());
        }

        // Insuation Help Button
        private void btnQuestionInsulation_Click(object sender, EventArgs e)
        {
            string message = "The grade of insulation used in the home.\n" +
                "If unknown, select average.";
            CustomMessageBox messageBox = new CustomMessageBox(message);
            DialogResult result = messageBox.ShowDialog();
            if (result == DialogResult.OK)
            {
                messageBox.Close();
            }
        }

        // Sun Exposure Help Button
        private void btnQuestionSun_Click(object sender, EventArgs e)
        {
            string message = "The amount of sun or shade that the home is exposed to.";
            CustomMessageBox messageBox = new CustomMessageBox(message);
            DialogResult result = messageBox.ShowDialog();
            if (result == DialogResult.OK)
            {
                messageBox.Close();
            }
        }

        // Window/Door Seal Help Button
        private void btnQuestionWindowDoor_Click(object sender, EventArgs e)
        {
            string message = "High effeciency windows use double pane glass.\n" +
                "High effeciency homes have doors with tigher tolerances.\n" +
                "If unknown, select average.";
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

        // Insulation Check Helper Method
        public void CheckInsulation()
        {
            // Check user selection
            insulation = cboInsulation.Text;

            // If incorrect selection, set completion tracker to false and display error image
            if (cboInsulation.SelectedIndex < 0)
            {
                complete = false;
                picErrorTwo.Visible = true;
            }

            // If correct selection, assign value
            else
            {
                BasicCalculation.Insulation = insulation;
            }  
        }

        // Exposure Check Helper Method
        public void CheckSunExposure()
        {
            // Check user selection
            sunExposure = cboSunExposure.Text;

            // If incorrect selection, set completion tracker to false and display error image
            if (cboSunExposure.SelectedIndex < 0)
            {
                complete = false;
                picErrorThree.Visible = true;
            }

            // If correct selection, assign value
            else
            {
                BasicCalculation.SunExposure = sunExposure;
            }    
        }

        // Seal Check Helper Method
        public void CheckSeal()
        {
            // Check user selection
            winDoorTightness = cboWindowDoor.Text;

            // If incorrect selection, set completion tracker to false and display error image
            if (cboWindowDoor.SelectedIndex < 0)
            {
                complete = false;
                picErrorFour.Visible = true;
            }

            // If correct selection, assign value
            else
            {
                BasicCalculation.SealTightness = winDoorTightness;
            }
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
