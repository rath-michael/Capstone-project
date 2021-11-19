using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class HowItWorks : Form
    {
        public HowItWorks()
        {
            InitializeComponent();
            LayoutSetup();
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
            panelBasic.Left = (int)(panelMain.Width * 0.5f - panelBasic.Width * 0.5f);
            panelAdvanced.Left = (int)(panelMain.Width * 0.5f - panelAdvanced.Width * 0.5f);
            btnHome.Left = (int)(panelMain.Width * 0.5f - btnHome.Width * 0.5f);

            //ToolTip design
            toolTip1.OwnerDraw = true;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 0;
            toolTip1.BackColor = Color.FromArgb(61, 59, 60);
            toolTip1.ForeColor = Color.FromArgb(40, 146, 215);
        }

        // Go To Basic Calculation Button
        private void btnGoBasic_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BasicStepOne());
        }

        // Go To Advanced Calculation Button
        private void btnGoAdvanced_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdvancedStepOne());
        }

        // Go Home Button
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
