using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class AdvancedStepOne : Form
    {
        public AdvancedStepOne()
        {
            InitializeComponent();
            LayoutSetup();
            ComboBoxPreload();
        }

        // Variables
        double ceilingHeight;
        int numPeople;
        int numAppliances;
        bool complete;
        // houseArea is needed for Step Five
        public static double houseArea;

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
            // Algn controls horizontally
            lblMain.Left = (int)(panelMain.Width * 0.5F - lblMain.Width * 0.5);
            btnHome.Left = (int)(panelMain.Width * 0.5F - btnHome.Width * 0.5);
            panelError.Left = (int)(panelMain.Width * 0.5f - panelError.Width * 0.5f);
            lblError.Left = (int)(panelError.Width * 0.5f - lblError.Width * 0.5f);

            //ToolTip design
            toolTip1.OwnerDraw = true;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 0;
            toolTip1.BackColor = Color.FromArgb(61, 59, 60);
            toolTip1.ForeColor = Color.FromArgb(40, 146, 215);
        }

        // Combo Box Preload Controls
        private void ComboBoxPreload()
        {
            // Use SQL connection to connect to database
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                // Try to get states to fill cboState, if error display message
                try
                {
                    // Database query
                    string query = "Select Distinct State From Locations";

                    // Create SQL command
                    SqlCommand command = new SqlCommand(query, connection);

                    // Open connection
                    connection.Open();

                    // Create DataAdapter object
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    // Create table to hold info
                    DataTable dt = new DataTable();

                    // Fill and display
                    adapter.Fill(dt);
                    cboState.ValueMember = "State";
                    cboState.DisplayMember = "State";
                    cboState.DataSource = dt;
                }
                catch (Exception)
                {
                    panelError.Visible = true;
                }
            }
        }

        // If selected state changes then change values in cboCity to correct cities
        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboState.SelectedValue.ToString() != null)
            {
                // Use SQL connection to connect to database
                using (SqlConnection connection = new SqlConnection(Main.connectionString))
                {
                    // Try to get city list based off which state has been selected, if error display error message
                    try
                    {
                        // Database query
                        string query = "Select City From Locations where State = @State";

                        // Create SQL command
                        SqlCommand command = new SqlCommand(query, connection);

                        // Open connection
                        connection.Open();

                        // Add input parameter to command
                        command.Parameters.AddWithValue("@State", cboState.SelectedValue.ToString());

                        //Create DataAdapter object
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        // Create table to hold info
                        DataTable dt = new DataTable();

                        // Fill and display
                        adapter.Fill(dt);
                        cboCity.ValueMember = "Id";
                        cboCity.DisplayMember = "City";
                        cboCity.DataSource = dt;
                    }
                    catch (Exception)
                    {
                        panelError.Visible = true;
                    }
                }
            }
        }

        // Next Page Button
        private void btnNext_Click(object sender, EventArgs e)
        {
            // Use SQL connection to connect to database
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                // Try to get calculation data needed from user selected state/city, if error display message and switch completion tracker to false
                try
                {
                    // Reset error logo's after each check
                    picErrorOne.Visible = false;
                    picErrorTwo.Visible = false;
                    picErrorThree.Visible = false;
                    picErrorFour.Visible = false;

                    // Reset error logo's after each check
                    complete = true;

                    // Assign selected city/state to AdvancedCalculation
                    AdvancedCalculation.State = cboState.Text;
                    AdvancedCalculation.City = cboCity.Text;

                    // Database query
                    string query = $"select [Cooling1%], [Design55%RH] from CalcBaseData where State = '{cboState.Text}' and city = '{cboCity.Text}'";

                    // Create SQL command
                    SqlCommand command = new SqlCommand(query, connection);

                    // Open connection
                    connection.Open();

                    // Create DataReader and execute command
                    SqlDataReader dataReader = command.ExecuteReader();

                    // While DataReader is returning values
                    while (dataReader.Read())
                    {
                        // Assign values
                        AdvancedCalculation.CoolingPercent = (int)dataReader.GetValue(0);
                        AdvancedCalculation.RelativeRH = (int)dataReader.GetValue(1);
                    }
                }
                catch (Exception)
                {
                    panelError.Visible = true;
                    complete = false;
                }

                // Check square foot, if unsuccessful set completion tracker to false and display error image
                try
                {
                    houseArea = int.Parse(txtHouseArea.Text);
                }
                catch (Exception)
                {
                    complete = false;
                    picErrorOne.Visible = true;
                }

                // Check ceiling height, if unsuccessful set completion tracker to false and display error image
                try
                {
                    ceilingHeight = double.Parse(txtCeilingHeight.Text);
                }
                catch (Exception)
                {
                    complete = false;
                    picErrorTwo.Visible = true;
                }

                // Check number of occupants, if unsuccessful set completion tracker to false and display error image
                try
                {
                    numPeople = int.Parse(txtNumPeople.Text);
                }
                catch (Exception)
                {
                    complete = false;
                    picErrorThree.Visible = true;
                }

                // Check number of appliances, if unsuccessful set completion tracker to false and display error image
                try
                {
                    numAppliances = int.Parse(txtNumAppliances.Text);
                }
                catch (Exception)
                {
                    complete = false;
                    picErrorFour.Visible = true;
                }

                // If all pass completion, assign values and progress
                if (complete)
                {
                    AdvancedCalculation.HouseArea = houseArea;
                    AdvancedCalculation.CeilingHeight = ceilingHeight;
                    AdvancedCalculation.NumPeople = numPeople;
                    AdvancedCalculation.NumAppliances = numAppliances;
                    OpenChildForm(new AdvancedStepTwo());
                }
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
