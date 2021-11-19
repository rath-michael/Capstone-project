using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace WindowsFormsApp3
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            LayoutSetup();
        }

        // Variables
        // Date search variables
        string dateId;
        string dateCalcType;
        string user;
        DateTime startSearch;
        DateTime endSearch;

        // User search variables
        int userId;
        string userCalcType;
        string username;

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
            // Reset Error and Panel Visibilities
            picErrorOne.Visible = false;
            picErrorTwo.Visible = false;
            picErrorThree.Visible = false;
            picErrorFour.Visible = false;
            panelUserSearch.Visible = false;
            panelDateSearch.Visible = false;
            panelBackground.Visible = true;

            // Align Controls Horizontally
            lblMain.Left = (int)(panelMain.Width * 0.5f - lblMain.Width * 0.5f);
            panelType.Left = (int)(panelMain.Width * 0.5f - panelType.Width * 0.5f);
            panelUserSearch.Left = (int)(panelMain.Width * 0.5f - panelUserSearch.Width * 0.5f);
            panelDateSearch.Left = (int)(panelMain.Width * 0.5f - panelDateSearch.Width * 0.5f);
            panelBackground.Left = (int)(panelMain.Width * 0.5f - panelBackground.Width * 0.5f);
            listView1.Left = (int)(panelDateSearch.Width * 0.5f - listView1.Width * 0.5f);
            btnSearchDate.Left = (int)(panelDateSearch.Width * 0.5f - btnSearchDate.Width * 0.5f);
            listView2.Left = (int)(panelUserSearch.Width * 0.5f - listView2.Width * 0.5f);
            btnSearchUser.Left = (int)(panelUserSearch.Width * 0.5f - btnSearchUser.Width * 0.5f);
            btnShowDetailsUser.Left = (int)(panelUserSearch.Width * 0.5f - btnShowDetailsUser.Width * 0.5f);
            btnHome.Left = (int)(panelMain.Width * 0.5f - btnHome.Width * 0.5f);
            lblError.Left = (int)(panelBackground.Width * 0.5f - lblError.Width * 0.5f);

            //ToolTip design
            toolTip1.OwnerDraw = true;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 0;
            toolTip1.BackColor = Color.FromArgb(61, 59, 60);
            toolTip1.ForeColor = Color.FromArgb(40, 146, 215);
        }

        // SearchByDate Radiobutton Control
        private void radSearchByDate_CheckedChanged(object sender, EventArgs e)
        {
            // Reset all error images
            picErrorOne.Visible = false;
            picErrorTwo.Visible = false;
            picErrorThree.Visible = false;
            picErrorFour.Visible = false;

            // Change panel visibility
            panelBackground.Visible = false;
            panelUserSearch.Visible = false;
            panelDateSearch.Visible = true;
        }

        // SearchByUser Radiobutton Control
        private void radSearchByUser_CheckedChanged(object sender, EventArgs e)
        {
            // Reset all error images
            picErrorOne.Visible = false;
            picErrorTwo.Visible = false;
            picErrorThree.Visible = false;
            picErrorFour.Visible = false;

            // Change panel visibility
            panelBackground.Visible = false;
            panelDateSearch.Visible = false;
            panelUserSearch.Visible = true;
        }

        // SearchByDate Button Control
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Use SQL connection to connect to database
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                // Try to query database, if exception display error message
                try
                {
                    // Clear listview at beginning of each search
                    listView1.Items.Clear();

                    // Reset all error images
                    picErrorOne.Visible = false;
                    picErrorTwo.Visible = false;

                    // Get search start / end date from user
                    startSearch = dateTimePicker1.Value;
                    endSearch = dateTimePicker2.Value;

                    // Database query
                    string query = $"Select * from DateOfCalculations where Date_Completed between '{startSearch}' and '{endSearch}'";

                    // Create SQL command
                    SqlCommand command = new SqlCommand(query, connection);

                    // Open connection
                    connection.Open();

                    // Create DataReader object
                    SqlDataReader dataReader = command.ExecuteReader();

                    //Create array to hold data
                    string[] items = new string[3];

                    // Display 
                    while (dataReader.Read())
                    {
                        // Read and display items returned from search
                        // ID
                        items[0] = dataReader.GetValue(0).ToString();
                        // Date
                        items[1] = dataReader.GetValue(1).ToString();
                        // Type
                        items[2] = dataReader.GetValue(2).ToString();
                        ListViewItem row = new ListViewItem(items);
                        listView1.Items.Add(row);
                    }

                    // Close connection
                    connection.Close();
                }
                catch (Exception)
                {
                    listView1.Visible = false;
                    panelBackground.Visible = true;
                    lblError.Visible = true;
                }
            }
        }

        // ListView1 Controls
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // To handle error if user changes selection
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            // Get selected info from listview1
            ListViewItem item = listView1.SelectedItems[0];
            dateId = item.SubItems[0].Text;
            dateCalcType = item.SubItems[2].Text.Trim();
        }

        // ShowDeatailsDate Button
        private void btnShowDetails_Click_1(object sender, EventArgs e)
        {
            // Reset all error images
            picErrorOne.Visible = false;
            picErrorTwo.Visible = false;

            // Verify a specific calculation has been selected before continuing
            if (listView1.SelectedItems.Count > 0)
            {
                // Show result page associated with id and type
                OpenChildForm(new DateSearchResult(dateId, dateCalcType));
            }
            // Error to notify user they need to make a selection
            else
            {
                picErrorTwo.Visible = true;
            }
        }

        // SearchByUser Button Control
        private void btnSearchByUser_Click(object sender, EventArgs e)
        {
            // Use SQL connection to connect to database
            using (SqlConnection connection = new SqlConnection(Main.connectionString))
            {
                // Try to query database, if exception display error message
                try
                {
                    // Clear listview at beginning of each search
                    listView2.Items.Clear();

                    // Reset all error images
                    picErrorThree.Visible = false;
                    picErrorFour.Visible = false;

                    // Check if search box is not empty
                    if (txtUserToSearch.Text != "")
                    {
                        // Get user to search, else display error image
                        try
                        {
                            user = txtUserToSearch.Text;
                        }
                        catch (Exception)
                        {
                            picErrorThree.Visible = true;
                        }

                        // Database query
                        string query = $"Select * from BasicCalcInput Where Username like '%{user}%'";

                        // Create SQL command
                        SqlCommand command = new SqlCommand(query, connection);

                        // Open connection
                        connection.Open();

                        // Create DataReader object
                        SqlDataReader dataReader = command.ExecuteReader();

                        // Create array to hold data
                        string[] basicItems = new string[3];

                        // Display
                        while (dataReader.Read())
                        {
                            // Read and display items returned from search
                            // ID
                            basicItems[0] = dataReader.GetValue(0).ToString();
                            // Type
                            basicItems[1] = "Basic";
                            // User
                            basicItems[2] = dataReader.GetValue(10).ToString();
                            ListViewItem row = new ListViewItem(basicItems);
                            listView2.Items.Add(row);
                        }

                        // Close DataReader
                        dataReader.Close();

                        // Database query
                        query = $"Select * from AdvCalcInput where Username Like '%{user}%'";

                        // Modify SQL connection
                        command = new SqlCommand(query, connection);

                        // Modify DataReader object
                        dataReader = command.ExecuteReader();

                        // Create array to hold data
                        string[] advItems = new string[3];

                        // Display
                        while (dataReader.Read())
                        {
                            // Read and display items returned from search
                            // ID
                            advItems[0] = dataReader.GetValue(0).ToString();
                            // Type
                            advItems[1] = "Advanced";
                            // User
                            advItems[2] = dataReader.GetValue(12).ToString();
                            ListViewItem row = new ListViewItem(advItems);
                            listView2.Items.Add(row);
                        }

                        // Close connection
                        connection.Close();
                    }
                    // If empty, display error image
                    else
                    {
                        picErrorThree.Visible = true;
                    }
                }
                catch (Exception)
                {
                    listView1.Visible = false;
                    panelBackground.Visible = true;
                    lblError.Visible = true;
                }
            }
        }

        // ListView2 Control
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // To handle errors if user changes selection
            if (listView2.SelectedItems.Count == 0)
            {
                return;
            }

            // Get selected info from listview2
            ListViewItem item = listView2.SelectedItems[0];
            userId = int.Parse(item.SubItems[0].Text);
            userCalcType = item.SubItems[1].Text;
            username = item.SubItems[2].Text;
        }

        // ShowDetailsUser Button
        private void btnShowDetailsUser_Click(object sender, EventArgs e)
        {
            // Reset all error images
            picErrorThree.Visible = false;
            picErrorFour.Visible = false;

            // Verify a specific calculation has been selected before continuing
            if (listView2.SelectedItems.Count > 0)
            {
                OpenChildForm(new UserSearchResult(userId, userCalcType, username));
            }
            // Error to notify user they need to make a selection
            else
            {
                picErrorFour.Visible = true;
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
