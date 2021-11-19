using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace WindowsFormsApp3
{
    public partial class BasicStepFour : Form
    {
        public BasicStepFour()
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
            //Align controls horizontally
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
            OpenChildForm(new BasicStepOne());
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

                // Iterage outputList and write contents to file
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
            double unitSize = BasicCalculation.PerformCalculation();
        }

        // Database Update Helper Method
        private void UpdateDatabase()
        {
            writeSuccess = BasicCalculation.SaveToDatabase();
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
            displayList.Items.Add($"Based off your need of {BasicCalculation.BTUNeed} BTU's,");
            displayList.Items.Add($"we recommend a unit size of {BasicCalculation.BTURecommended} tons.");

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
            outputList.Add("General Info", "-----");
            outputList.Add("Region", BasicCalculation.Region.ToString());
            outputList.Add("Square Feet", BasicCalculation.SquareFeet.ToString());
            outputList.Add("Insulation", BasicCalculation.Insulation);
            outputList.Add("Sun Exposure", BasicCalculation.SunExposure);
            outputList.Add("Window / Door Seal Level", BasicCalculation.SealTightness);
            outputList.Add("Number Occupants", BasicCalculation.NumOccupants.ToString());
            outputList.Add("Number Appliances", BasicCalculation.NumAppliances.ToString());
            outputList.Add("Kitchen", BasicCalculation.Kitchen);
            outputList.Add("Format1", "--");
            outputList.Add("Final Calculation Info", "-----");
            outputList.Add("User", BasicCalculation.Username);
            outputList.Add("Total Gain", BasicCalculation.BTUNeed.ToString());
            outputList.Add("Size Needed", BasicCalculation.BTURecommended.ToString());
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
