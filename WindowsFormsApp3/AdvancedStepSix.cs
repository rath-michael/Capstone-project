using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace WindowsFormsApp3
{
    public partial class AdvancedStepSix : Form
    {
        public AdvancedStepSix()
        {
            InitializeComponent();
            LayoutSetup();
            PerformCalculations();
            UpdateDatabase();
            CreateSaveList();
            DisplayResults();
        }

        // Variables
        Dictionary<string, string> outputList = new Dictionary<string, string>();
        bool writeSuccess;

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
            displayList.Left = (int)(panelMain.Width * 0.5f - displayList.Width * 0.5f);
            btnHome.Left = (int)(panelMain.Width * 0.5f - btnHome.Width * 0.5f);

            //ToolTip design
            toolTip1.OwnerDraw = true;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 0;
            toolTip1.BackColor = Color.FromArgb(61, 59, 60);
            toolTip1.ForeColor = Color.FromArgb(40, 146, 215);
        }

        // Home Page Button
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home());
        }

        // Restart Calculation Button
        private void btnRestart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdvancedStepOne());
        }

        // Save File Button
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            // Create SaveFileDialog to save calculations
            SaveFileDialog savefile = new SaveFileDialog();

            // Set file extension
            savefile.InitialDirectory = "c:\\";
            savefile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            savefile.FilterIndex = 2;
            savefile.RestoreDirectory = true;

            // If user selects to continue save
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                // Get filepath
                var path = savefile.FileName;

                // Create writer object
                StreamWriter writer = new StreamWriter(path);

                // Iterate outputList and write contents to file
                foreach (KeyValuePair<string, string> item in outputList)
                {
                    // Check for format spacing and write
                    if (item.Value == "--")
                    {
                        writer.Write("\n");
                    }
                    else
                    {
                        writer.Write(item.Key + ": " + item.Value + "\n");
                    }
                }

                // Close writer
                writer.Close();
            }
        }

        // Perform Calculation Helper Method
        private void PerformCalculations()
        {
            double unitSize = AdvancedCalculation.PerformCalculation();
        }

        // Database Update Helper Method
        private void UpdateDatabase()
        {
            writeSuccess = AdvancedCalculation.SaveToDatabase();
        }

        // Display Results Helper Method
        private void DisplayResults()
        {
            // Iterage outputList and display contents
            foreach (KeyValuePair<string, string> item in outputList)
            {
                // Check for format spacing and display
                if (item.Value == "--")
                {
                    displayList.Items.Add("");
                }
                else
                {
                    displayList.Items.Add(item.Key + ": " + item.Value);
                }
            }

            // Format spacing and final output message
            displayList.Items.Add("");
            displayList.Items.Add("");
            displayList.Items.Add($"Based off your need of {AdvancedCalculation.TotalGain} BTU's,");
            displayList.Items.Add($"we recommend a unit size of {AdvancedCalculation.SizeNeeded} tons.");

            // Format spacing and inform user if database save was successful or not
            displayList.Items.Add("");
            displayList.Items.Add("");
            if (writeSuccess)
            {
                displayList.Items.Add("Calculation was saved successfully.");
            }
            else
            {
                displayList.Items.Add("There was an error saving the calculation");
            }
        }

        // Helper Method To Create List For Display & File Save
        private void CreateSaveList()
        {
            // Standard Info
            outputList.Add("General Info", "-----");
            outputList.Add("State", AdvancedCalculation.State);
            outputList.Add("City", AdvancedCalculation.City);
            outputList.Add("Cooling 1%", AdvancedCalculation.CoolingPercent.ToString());
            outputList.Add("Relative Humidity", AdvancedCalculation.RelativeRH.ToString());
            outputList.Add("Square Feet", AdvancedCalculation.HouseArea.ToString());
            outputList.Add("Ceiling Height", AdvancedCalculation.CeilingHeight.ToString());
            outputList.Add("Number Occupants", AdvancedCalculation.NumPeople.ToString());
            outputList.Add("Number Appliances", AdvancedCalculation.NumAppliances.ToString());
            outputList.Add("Format1", "--");

            // North/South Info
            outputList.Add("North / South Exposure Info", "-----");
            outputList.Add("NS Window Area", AdvancedCalculation.NSWinArea.ToString());
            outputList.Add("NS Window Construction", AdvancedCalculation.NSwinConstType);
            outputList.Add("NS Door Area", AdvancedCalculation.NSDoorArea.ToString());
            outputList.Add("NS Door Construction", AdvancedCalculation.NSDoorConstType);
            outputList.Add("NS Wall Area", AdvancedCalculation.NSWallArea.ToString());
            outputList.Add("NS Frame Type", AdvancedCalculation.NSWallFrameType);
            outputList.Add("NS Insulation Type", AdvancedCalculation.NSWallInsulType);
            outputList.Add("NS Siding Type", AdvancedCalculation.NSWallSidingType);
            outputList.Add("Format2", "--");

            // West Info
            outputList.Add("W Western Exposure Info", "-----");
            outputList.Add("W Window Area", AdvancedCalculation.WWinArea.ToString());
            outputList.Add("W Window Construction", AdvancedCalculation.WWinConstType);
            outputList.Add("W Door Area", AdvancedCalculation.WDoorArea.ToString());
            outputList.Add("W Door Construction", AdvancedCalculation.WDoorConstType);
            outputList.Add("W Wall Area", AdvancedCalculation.WWallArea.ToString());
            outputList.Add("W Frame Type", AdvancedCalculation.WWallFrameType);
            outputList.Add("W Insulation Type", AdvancedCalculation.WWallInsulType);
            outputList.Add("W Siding Type", AdvancedCalculation.WWallSidingType);
            outputList.Add("Format3", "--");

            //East Info
            outputList.Add("Eastern Exposure Info", "-----");
            outputList.Add("E Window Area", AdvancedCalculation.EWinArea.ToString());
            outputList.Add("E Window Construction", AdvancedCalculation.EWinConstType);
            outputList.Add("E Door Area", AdvancedCalculation.EDoorArea.ToString());
            outputList.Add("E Door Construction", AdvancedCalculation.EDoorConstType);
            outputList.Add("E Wall Area", AdvancedCalculation.EWallArea.ToString());
            outputList.Add("E Frame Type", AdvancedCalculation.EWallFrameType);
            outputList.Add("E Insulation Type", AdvancedCalculation.EWallInsulType);
            outputList.Add("E Siding Type", AdvancedCalculation.EWallSidingType);
            outputList.Add("Format4", "--");

            // Roof / Floor info
            outputList.Add("Roof / Floor Info", "-----");
            outputList.Add("Roof Coloring", AdvancedCalculation.RoofColoring);
            outputList.Add("Roof Construction", AdvancedCalculation.RoofConst);
            outputList.Add("Floor Type", AdvancedCalculation.FloorType);
            outputList.Add("Floor Construction", AdvancedCalculation.FloorConst);
            outputList.Add("Format5", "--");

            // Final Info
            outputList.Add("Final Calculation Info", "-----");
            outputList.Add("User", AdvancedCalculation.User);
            outputList.Add("Total Gain", AdvancedCalculation.TotalGain.ToString());
            outputList.Add("Size Needed", AdvancedCalculation.SizeNeeded.ToString());
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
