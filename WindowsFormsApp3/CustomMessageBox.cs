using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }

        public CustomMessageBox(string displayMessage)
        {
            InitializeComponent();
            LayoutSetup(displayMessage);
        }

        // Panel layout/design setup
        private void LayoutSetup(string displayMessage)
        {
            btnOk.Left = (int)(this.Width * 0.5f - btnOk.Width * 0.5f);
            lblDisplay.Text = displayMessage;
            lblDisplay.Left = (int)(this.Width * 0.5f - lblDisplay.Width * 0.5f);
            
        }

        // Ok button to close CustomMessageBox
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
