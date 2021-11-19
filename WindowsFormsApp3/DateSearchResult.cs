using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class DateSearchResult : Form
    {
        public DateSearchResult()
        {
            InitializeComponent();
        }

        public DateSearchResult(string id, string type)
        {
            InitializeComponent();
            LayoutSetup();
            SearchDatabase(id, type);
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

        // Format Design Of Page
        private void LayoutSetup()
        {
            // Align controls horizontally
            lblMain.Left = (int)(panelMain.Width * 0.5f - lblMain.Width * 0.5f);
            listDisplay.Left = (int)(panelMain.Width * 0.5f - listDisplay.Width * 0.5f);
            panelBackground.Left = (int)(panelMain.Width * 0.5f - panelBackground.Width * 0.5f);
            lblError.Left = (int)(panelBackground.Width * 0.5f - lblError.Width * 0.5f);
            lblErrorTwo.Left = (int)(panelBackground.Width * 0.5f - lblErrorTwo.Width * 0.5f);

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

        // New Search Button
        private void btnNewSearch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Search());
        }

        // Method to search database and display results
        public void SearchDatabase(string id, string type)
        {
            // Use SQL connection to connect to database
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                // Try to query database, if exception display error message
                try
                {
                    // If calculation was type basic
                    if (type == "Basic")
                    {
                        // Pull data from neccessary different tables, add to dictionary, display at end
                        // Database query
                        string query = $"Select * from BasicCalcInput where Date_ID = {id}";

                        // Create SQL command
                        SqlCommand command = new SqlCommand(query, connection);

                        // Open connection
                        connection.Open();

                        // Create DataAdapter object
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        // Create DataTable object
                        DataTable dt = new DataTable();

                        // Fill DataTable from DataAdapter return
                        adapter.Fill(dt);

                        // Get data to display from BasicCalcInput
                        DataRow row = dt.Rows[0];

                        // Create dictionary to hold calculation info for display
                        Dictionary<string, string> results = new Dictionary<string, string>();
                        results.Add("Region", row["Region"].ToString());
                        results.Add("Square Feet", row["Square_Feet"].ToString());
                        results.Add("Insulation", row["Insulation"].ToString());
                        results.Add("Sun Exposure", row["Sun_Exposure"].ToString());
                        results.Add("Window/Door Seal", row["Win_Door_Seal"].ToString());
                        results.Add("# of Occupants", row["Num_Occupants"].ToString());
                        results.Add("# of Appliances", row["Num_Appliances"].ToString());
                        results.Add("Kitchen", row["Kitchen"].ToString());
                        results.Add("Username", row["Username"].ToString());

                        // Get ID to search for remaining results
                        string inputId = row["ID"].ToString();

                        // Database query
                        query = $"Select * from BasicCalcResults where Input_ID = {inputId}";

                        // Modify SQL command
                        command = new SqlCommand(query, connection);

                        // Modify DataAdapter object
                        adapter = new SqlDataAdapter(command);

                        // Clear DataTable for new results
                        dt = new DataTable();

                        // Fill DataTable from DataAdapter return
                        adapter.Fill(dt);

                        // Get data to display from BasicCalcResults
                        row = dt.Rows[0];

                        // Add remaining data to dictionary
                        results.Add("BTU Load", row["BTU_Load"].ToString());
                        results.Add("Size Needed", row["BTU_Need"].ToString());

                        // Iterate dictionary and display results
                        foreach (var thing in results)
                        {
                            listDisplay.Items.Add(thing.Key.ToString() + " - " + thing.Value.ToString());
                        }
                    }

                    // Else calculation type is advanced
                    else
                    {
                        // Pull data from neccessary different tables, add to dictionary, display at end
                        // Database query
                        string query = $"Select * from AdvCalcInput where Date_ID = {id}";

                        // Create SQL command
                        SqlCommand command = new SqlCommand(query, connection);

                        // Open connection
                        connection.Open();

                        // Create DataAdapter object
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        // Create DataTable object
                        DataTable dt = new DataTable();

                        // Fill DataTable from DataAdapter return
                        adapter.Fill(dt);

                        // Get data to display from AdvCalcInput
                        DataRow row = dt.Rows[0];

                        // Create dictionary to hold calculation info for display
                        Dictionary<string, string> advResults = new Dictionary<string, string>();
                        advResults.Add("State", row["State"].ToString());
                        advResults.Add("City", row["City"].ToString());
                        advResults.Add("Square Feet", row["Square_Feet"].ToString());
                        advResults.Add("Ceiling Height", row["Ceiling_Height"].ToString());
                        advResults.Add("# of Occupants", row["Num_Occupants"].ToString());
                        advResults.Add("# of Appliances", row["Num_Appliances"].ToString());
                        advResults.Add("Roof Color", row["Ceiling_Color"].ToString());
                        advResults.Add("Roof Type", row["Ceiling_Const_Type"].ToString());
                        advResults.Add("Floor Material", row["Floor_Type"].ToString());
                        advResults.Add("Floor Type", row["Floor_Const_Type"].ToString());
                        advResults.Add("Username", row["Username"].ToString());

                        // Format display
                        listDisplay.Items.Add("--General--");

                        // Iterate dictionary and display results
                        foreach (var thing in advResults)
                        {
                            listDisplay.Items.Add(thing.Key.ToString() + " - " + thing.Value.ToString());
                        }

                        // Clear dictionary for new data to display
                        advResults.Clear();

                        // Get ID to search for remaining results
                        string inputId = row["ID"].ToString();

                        // Database query
                        query = $"Select * from AdvCalcNSInput where Input_ID = {inputId}";

                        // Modify SQL command
                        command = new SqlCommand(query, connection);

                        // Modify DataAdapter object
                        adapter = new SqlDataAdapter(command);

                        // Clear DataTable for new results
                        dt = new DataTable();

                        // Fill DataTable from DataAdapter return
                        adapter.Fill(dt);

                        // Get data to display from AdvCalcNSInput
                        row = dt.Rows[0];

                        // Add remaining data to dictionary
                        advResults.Add("Window Area", row["Win_SQFT"].ToString());
                        advResults.Add("Window Type", row["Win_Const"].ToString());
                        advResults.Add("Door Area", row["Door_SQFT"].ToString());
                        advResults.Add("Door Type", row["Door_Const"].ToString());
                        advResults.Add("Exposed Wall Area", row["Wall_SQFT"].ToString());
                        advResults.Add("Wall Frame Type", row["Wall_Frame_Type"].ToString());
                        advResults.Add("Wall Insulation Type", row["Wall_Ins_Type"].ToString());
                        advResults.Add("Wall Siding Type", row["Wall_Siding_Type"].ToString());

                        // Format display
                        listDisplay.Items.Add("");
                        listDisplay.Items.Add("--North South Exposure--");

                        // Iterate dictionary and display results
                        foreach (var thing in advResults)
                        {
                            listDisplay.Items.Add(thing.Key.ToString() + " - " + thing.Value.ToString());
                        }

                        // Clear dictionary for new data to display
                        advResults.Clear();

                        // Database query
                        query = $"Select * from AdvCalcWInput where Input_ID = {inputId}";

                        // Modify SQL command
                        command = new SqlCommand(query, connection);

                        // Modify DataAdapter object
                        adapter = new SqlDataAdapter(command);

                        // Clear DataTable for new results
                        dt = new DataTable();

                        // Fill DataTable from DataAdapter return
                        adapter.Fill(dt);

                        // Get data to display from AdvCalcWInput
                        row = dt.Rows[0];

                        // Add remaining data to dictionary
                        advResults.Add("Window Area", row["Win_SQFT"].ToString());
                        advResults.Add("Window Type", row["Win_Const"].ToString());
                        advResults.Add("Door Area", row["Door_SQFT"].ToString());
                        advResults.Add("Door Type", row["Door_Const"].ToString());
                        advResults.Add("Exposed Wall Area", row["Wall_SQFT"].ToString());
                        advResults.Add("Wall Frame Type", row["Wall_Frame_Type"].ToString());
                        advResults.Add("Wall Insulation Type", row["Wall_Ins_Type"].ToString());
                        advResults.Add("Wall Siding Type", row["Wall_Siding_Type"].ToString());

                        // Format display
                        listDisplay.Items.Add("");
                        listDisplay.Items.Add("--East Exposure--");

                        // Iterate dictionary and display results
                        foreach (var thing in advResults)
                        {
                            listDisplay.Items.Add(thing.Key.ToString() + " - " + thing.Value.ToString());
                        }

                        // Clear dictionary for new data to display
                        advResults.Clear();

                        // Database query
                        query = $"Select * from AdvCalcEInput where Input_ID = {inputId}";

                        // Modify SQL command
                        command = new SqlCommand(query, connection);

                        // Modify DataAdapter object
                        adapter = new SqlDataAdapter(command);

                        // Clear DataTable for new results
                        dt = new DataTable();

                        // Fill DataTable from DataAdapter return
                        adapter.Fill(dt);

                        // Get data to display from AdvCalcEInput
                        row = dt.Rows[0];

                        // Add remaining data to dictionary
                        advResults.Add("Window Area", row["Win_SQFT"].ToString());
                        advResults.Add("Window Type", row["Win_Const"].ToString());
                        advResults.Add("Door Area", row["Door_SQFT"].ToString());
                        advResults.Add("Door Type", row["Door_Const"].ToString());
                        advResults.Add("Exposed Wall Area", row["Wall_SQFT"].ToString());
                        advResults.Add("Wall Frame Type", row["Wall_Frame_Type"].ToString());
                        advResults.Add("Wall Insulation Type", row["Wall_Ins_Type"].ToString());
                        advResults.Add("Wall Siding Type", row["Wall_Siding_Type"].ToString());

                        // Format display
                        listDisplay.Items.Add("");
                        listDisplay.Items.Add("--West Exposure--");

                        // Iterate dictionary and display results
                        foreach (var thing in advResults)
                        {
                            listDisplay.Items.Add(thing.Key.ToString() + " - " + thing.Value.ToString());
                        }

                        // Clear dictionary for new data to display
                        advResults.Clear();

                        // Format display
                        listDisplay.Items.Add("");
                        listDisplay.Items.Add("--Calculation Results--");

                        // Database query
                        query = $"Select * from AdvCalcResults where Input_ID = {inputId}";

                        // Modify SQL command
                        command = new SqlCommand(query, connection);

                        // Modify DataAdapter object
                        adapter = new SqlDataAdapter(command);

                        // Clear DataTable for new results
                        dt = new DataTable();

                        // Fill DataTable from DataAdapter return
                        adapter.Fill(dt);

                        // Get data to display from AdvCalcResults
                        row = dt.Rows[0];

                        // Add remaining data to dictionary
                        advResults.Add("BTU Load", row["BTU_Load"].ToString());
                        advResults.Add("Size Needed", row["BTU_Need"].ToString());

                        // Iterate dictionary and display results
                        foreach (var thing in advResults)
                        {
                            listDisplay.Items.Add(thing.Key.ToString() + " - " + thing.Value.ToString());
                        }
                    }
                }
                catch (Exception)
                {
                    listDisplay.Visible = false;
                    panelBackground.Visible = true;
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
