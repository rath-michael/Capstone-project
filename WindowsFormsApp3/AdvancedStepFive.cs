using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class AdvancedStepFive : Form
    {
        public AdvancedStepFive()
        {
            InitializeComponent();
            LayoutSetup();
        }

        // Variables
        // Roof
        double roofTotal;
        // Floor
        double floorTotal;
        // Overall
        bool complete;

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
            //Align controls horizontally
            lblMain.Left = (int)(panelMain.Width * 0.5f - lblMain.Width * 0.5f);
            btnHome.Left = (int)(panelMain.Width * 0.5f - btnHome.Width * 0.5f);
            lblCeiling.Left = (int)(panelMain.Width * 0.5f - lblCeiling.Width * 0.5f);
            lblFloor.Left = (int)(panelMain.Width * 0.5f - lblFloor.Width * 0.5f);
            lblUsername.Left = (int)(panelMain.Width * 0.5f - lblUsername.Width * 0.5f);
            txtUsername.Left = (int)(panelMain.Width * 0.5f - txtUsername.Width * 0.5f);

            // ToolTip design
            toolTip1.OwnerDraw = true;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 0;
            toolTip1.BackColor = Color.FromArgb(61, 59, 60);
            toolTip1.ForeColor = Color.FromArgb(40, 146, 215);
        }

        // Next Page Button
        private void btnNext_Click(object sender, EventArgs e)
        {
            // Reset error logo's after each check
            picErrorOne.Visible = false;
            picErrorTwo.Visible = false;
            picErrorThree.Visible = false;
            picErrorFour.Visible = false;

            // Reset completion tracker before each check
            complete = true;

            // Gather user entered data
            FloorData();
            RoofData();

            // Check for username, if not empty assign value
            if (txtUsername.Text != null)
            {
                AdvancedCalculation.User = txtUsername.Text;
            }

            // If all pass completion, assign values and progress
            if (complete)
            {
                AdvancedCalculation.FloorRoofTotal = floorTotal + roofTotal;
                OpenChildForm(new AdvancedStepSix());
            }
        }

        // Previous Page Button
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdvancedStepFour());
        }

        // Home Page Button
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home());
        }

        // Floor Information Helper Method
        public void FloorData()
        {
            // Check floor type, if unsuccessful set completion tracker to false and display error image else assign value
            if (cboFloorType.SelectedIndex < 0)
            {
                complete = false;
                picErrorFour.Visible = true;
            }
            else
            {
                AdvancedCalculation.FloorType = cboFloorType.Text;
            }

            // Check floor construction, if unsuccessful set completion tracker to false and display error image else assign value
            if (cboFloorConst.SelectedIndex < 0)
            {
                complete = false;
                picErrorThree.Visible = true;
            }
            else
            {
                AdvancedCalculation.FloorConst = cboFloorConst.Text;
            }

            // Perform calculation and assign values based on floor type/construction
            if (cboFloorType.SelectedIndex == 0)
            {
                if (cboFloorConst.SelectedIndex == 0)
                {
                    floorTotal = AdvancedStepOne.houseArea * 0.5;
                }
                else if (cboFloorConst.SelectedIndex == 1)
                {
                    floorTotal = AdvancedStepOne.houseArea * 0;
                }
                else if (cboFloorConst.SelectedIndex == 2)
                {
                    floorTotal = AdvancedStepOne.houseArea * 0;
                }
            }
            else if (cboFloorType.SelectedIndex == 1)
            {
                if (cboFloorConst.SelectedIndex == 0)
                {
                    floorTotal = AdvancedStepOne.houseArea * 0.7;
                }
                else if (cboFloorConst.SelectedIndex == 1)
                {
                    floorTotal = AdvancedStepOne.houseArea * 0;
                }
                else if (cboFloorConst.SelectedIndex == 2)
                {
                    floorTotal = AdvancedStepOne.houseArea * 0;
                }
            }
        }

        // Roof Information Helper Method
        public void RoofData()
        {
            // Check roof coloring, if unsuccessful set completion tracker to false and display error image else assign value
            if (cboRoofColor.SelectedIndex < 0)
            {
                complete = false;
                picErrorOne.Visible = true;
            }
            else
            {
                AdvancedCalculation.RoofColoring = cboRoofColor.Text;
            }

            // Check roof construction, if unsuccessful set completion tracker to false and display error image else assign value
            if (cboRoofConst.SelectedIndex < 0)
            {
                complete = false;
                picErrorTwo.Visible = true;
            }
            else
            {
                AdvancedCalculation.RoofConst = cboRoofConst.Text;
            }

            // Perform calculation and assign values based on roof color/construction
            if (cboRoofColor.SelectedIndex == 0)
            {
                if (cboRoofConst.SelectedIndex == 0)
                {
                    roofTotal = AdvancedStepOne.houseArea * 2.1;
                }
                else if (cboRoofConst.SelectedIndex == 1)
                {
                    roofTotal = AdvancedStepOne.houseArea * 4.2;
                }
                else if (cboRoofConst.SelectedIndex == 2)
                {
                    roofTotal = AdvancedStepOne.houseArea * 2.3;
                }
            }
            else if (cboRoofColor.SelectedIndex == 1)
            {
                if (cboRoofConst.SelectedIndex == 0)
                {
                    roofTotal = AdvancedStepOne.houseArea * 4.6;
                }
                else if (cboRoofConst.SelectedIndex == 1)
                {
                    roofTotal = AdvancedStepOne.houseArea * 6.5;
                }
                else if (cboRoofConst.SelectedIndex == 2)
                {
                    roofTotal = AdvancedStepOne.houseArea * 3.2;
                }
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
