using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class AdvancedStepThree : Form
    {
        public AdvancedStepThree()
        {
            InitializeComponent();
            LayoutSetup();
        }

        // Variables
        // Windows
        double winArea;
        double windowTotal;
        // Doors
        double doorArea;
        double doorTotal;
        // Walls
        double wallArea;
        double wallTotal;
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
            // Align controls horizontally
            lblMain.Left = (int)(panelMain.Width * 0.5f - lblMain.Width * 0.5f);
            lblWest.Left = (int)(panelMain.Width * 0.5f - lblWest.Width * 0.5f);
            lblWindows.Left = (int)(panelMain.Width * 0.5f - lblWindows.Width * 0.5f);
            lblDoors.Left = (int)(panelMain.Width * 0.5f - lblDoors.Width * 0.5f);
            lblWalls.Left = (int)(panelMain.Width * 0.5f - lblWalls.Width * 0.5f);
            btnHome.Left = (int)(panelMain.Width * 0.5f - btnHome.Width * 0.5f);

            //ToolTip design
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
            picErrorFive.Visible = false;
            picErrorSix.Visible = false;
            picErrorSeven.Visible = false;
            picErrorEight.Visible = false;

            // Reset completion tracker before each check
            complete = true;

            // Gather user entered data
            WindowData();
            DoorData();
            WallData();

            // If all pass completion, assign values and progress
            if (complete)
            {
                AdvancedCalculation.WestTotal = windowTotal + doorTotal + wallTotal;
                AdvancedCalculation.WestTotalArea = winArea + doorArea;
                AdvancedCalculation.WWinArea = winArea;
                AdvancedCalculation.WDoorArea = doorArea;
                AdvancedCalculation.WWallArea = wallArea;
                OpenChildForm(new AdvancedStepFour());
            }
        }

        // Previous Page Button
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdvancedStepTwo());
        }

        // Home Page Button
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home());
        }

        // Window Information Helper Method
        public void WindowData()
        {
            // Check square foot, if unsuccessful set completion tracker to false and display error image
            try
            {
                winArea = double.Parse(txtWestWindow.Text);
            }
            catch (Exception)
            {
                complete = false;
                picErrorOne.Visible = true;
            }

            // Check construction type, if unsuccessful set completion tracker to false and display error image else assign value
            if (cboWestWindow.SelectedIndex < 0)
            {
                complete = false;
                picErrorTwo.Visible = true;
            }
            else
            {
                AdvancedCalculation.WWinConstType = cboWestWindow.Text;
            }

            // Perform calculation and assign values based on window construction
            if (cboWestWindow.SelectedIndex == 0)
            {
                windowTotal = winArea * 40;
            }
            else
            {
                windowTotal = winArea * 30;
            }
        }

        // Door Information Helper Method
        public void DoorData()
        {
            // Check square foot, if unsuccessful set completion tracker to false and display error image
            try
            {
                doorArea = double.Parse(txtWestDoor.Text);
            }
            catch (Exception)
            {
                complete = false;
                picErrorThree.Visible = true;
            }

            // Check construction type, if unsuccessful set completion tracker to false and display error image else assign value
            if (cboWestDoor.SelectedIndex < 0)
            {
                complete = false;
                picErrorFour.Visible = true;
            }
            else
            {
                AdvancedCalculation.WDoorConstType = cboWestDoor.Text;
            }

            // Perform calculation and assign values
            if (cboWestDoor.SelectedIndex == 0)
            {
                doorTotal = doorArea * 8.6;
            }
            else if (cboWestDoor.SelectedIndex == 1)
            {
                doorTotal = doorArea * 11.0;
            }
            else if (cboWestDoor.SelectedIndex == 2)
            {
                doorTotal = doorArea * 3.5;
            }
            else if (cboWestDoor.SelectedIndex == 3)
            {
                doorTotal = doorArea * 8.7;
            }
        }

        // Wall Information Helper Method
        public void WallData()
        {
            // Assign wall frame type, construction type, and insulation type strings to AdvancedCalculation
            // Check square foot, if unsuccessful set completion tracker to false and display error image
            try
            {
                wallArea = double.Parse(txtWestWall.Text);
            }
            catch (Exception)
            {
                complete = false;
                picErrorFive.Visible = true;
            }

            // Check construction type, if unsuccessful set completion tracker to false and display error image else assign value
            if (cboWestWallFrame.SelectedIndex < 0)
            {
                complete = false;
                picErrorSix.Visible = true;
            }
            else
            {
                AdvancedCalculation.WWallFrameType = cboWestWallFrame.Text;
            }

            // Check insulation type, if unsuccessful set completion tracker to false and display error image else assign value
            if (cboWestWallInsulation.SelectedIndex < 0)
            {
                complete = false;
                picErrorSeven.Visible = true;
            }
            else
            {
                AdvancedCalculation.WWallInsulType = cboWestWallInsulation.Text;
            }

            // Check siding type, if unsuccessful set completion tracker to false and display error image else assign value
            if (cboWestWallSiding.SelectedIndex < 0)
            {
                complete = false;
                picErrorEight.Visible = true;
            }
            else
            {
                AdvancedCalculation.WWallSidingType = cboWestWallSiding.Text;
            }

            // If all data entered correctly, perform calculation
            if (complete)
            {
                // Using wallModifiers array, determine wallTotal from user inputs
                double[,,] wallModifiers = { { { 5.0 , 4.0 , 2.0 } , { 1.5 , 1.4 , 0.9} , { 1.5 , 1.3 , 0.9 } , {1.1 , 0.9 , 0.7 } },
                                       { { 2.7 , 2.2 , 1.5 } , { 0.9 , 0.7 , 0.5} , { 0.8 , 0.7 , 0.5 } , { 0.6 , 0.4 , 0.4 } },
                                       { { 2.7 , 2.5 , 2.2 } , { 1.9 , 1.6 , 1.5} , { 0.9 , 0.7 , 0.5 } , { 0.4 , 0.3 , 0.2 } } };

                wallTotal = wallArea * wallModifiers[cboWestWallFrame.SelectedIndex, cboWestWallInsulation.SelectedIndex, cboWestWallSiding.SelectedIndex];
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
