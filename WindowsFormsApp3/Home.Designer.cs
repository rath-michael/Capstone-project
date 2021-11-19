namespace WindowsFormsApp3
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.lblParagraph = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHistory = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblGetStarted = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picRealEstate = new System.Windows.Forms.PictureBox();
            this.picHouse = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRealEstate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelBackground);
            this.panelMain.Controls.Add(this.lblHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(992, 656);
            this.panelMain.TabIndex = 0;
            // 
            // panelBackground
            // 
            this.panelBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
            this.panelBackground.Controls.Add(this.picRealEstate);
            this.panelBackground.Controls.Add(this.picHouse);
            this.panelBackground.Controls.Add(this.lblParagraph);
            this.panelBackground.Controls.Add(this.label1);
            this.panelBackground.Controls.Add(this.lblHistory);
            this.panelBackground.Controls.Add(this.lblHelp);
            this.panelBackground.Controls.Add(this.lblGetStarted);
            this.panelBackground.Location = new System.Drawing.Point(128, 96);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(736, 465);
            this.panelBackground.TabIndex = 66;
            // 
            // lblParagraph
            // 
            this.lblParagraph.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblParagraph.AutoSize = true;
            this.lblParagraph.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParagraph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblParagraph.Location = new System.Drawing.Point(110, 130);
            this.lblParagraph.Name = "lblParagraph";
            this.lblParagraph.Size = new System.Drawing.Size(490, 66);
            this.lblParagraph.TabIndex = 5;
            this.lblParagraph.Text = "This product is designed to assist you in getting\r\nthe correct size cooling equip" +
    "ment for your home,\r\noffice, or commercial building.";
            this.lblParagraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label1.Location = new System.Drawing.Point(212, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Building HVAC Load Calculator";
            // 
            // lblHistory
            // 
            this.lblHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblHistory.Location = new System.Drawing.Point(110, 393);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(516, 24);
            this.lblHistory.TabIndex = 3;
            this.lblHistory.Text = "To view all previous calculations, click \'History\'";
            this.lblHistory.MouseEnter += new System.EventHandler(this.lblHistory_MouseEnter);
            this.lblHistory.MouseLeave += new System.EventHandler(this.lblHistory_MouseLeave);
            // 
            // lblHelp
            // 
            this.lblHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblHelp.Location = new System.Drawing.Point(179, 345);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(354, 24);
            this.lblHelp.TabIndex = 2;
            this.lblHelp.Text = "To see how it works, click \'Help\'";
            this.lblHelp.MouseEnter += new System.EventHandler(this.lblHelp_MouseEnter);
            this.lblHelp.MouseLeave += new System.EventHandler(this.lblHelp_MouseLeave);
            // 
            // lblGetStarted
            // 
            this.lblGetStarted.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGetStarted.AutoSize = true;
            this.lblGetStarted.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetStarted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblGetStarted.Location = new System.Drawing.Point(130, 297);
            this.lblGetStarted.Name = "lblGetStarted";
            this.lblGetStarted.Size = new System.Drawing.Size(473, 24);
            this.lblGetStarted.TabIndex = 1;
            this.lblGetStarted.Text = "To start your calculation, click \'Get Started\'";
            this.lblGetStarted.MouseEnter += new System.EventHandler(this.lblGetStarted_MouseEnter);
            this.lblGetStarted.MouseLeave += new System.EventHandler(this.lblGetStarted_MouseLeave);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblHeader.Location = new System.Drawing.Point(432, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(97, 28);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Header";
            // 
            // picRealEstate
            // 
            this.picRealEstate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picRealEstate.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_real_estate_50px;
            this.picRealEstate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picRealEstate.Location = new System.Drawing.Point(673, 3);
            this.picRealEstate.Name = "picRealEstate";
            this.picRealEstate.Size = new System.Drawing.Size(60, 58);
            this.picRealEstate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picRealEstate.TabIndex = 7;
            this.picRealEstate.TabStop = false;
            // 
            // picHouse
            // 
            this.picHouse.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_house_50px;
            this.picHouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picHouse.Location = new System.Drawing.Point(3, 3);
            this.picHouse.Name = "picHouse";
            this.picHouse.Size = new System.Drawing.Size(60, 58);
            this.picHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picHouse.TabIndex = 6;
            this.picHouse.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(992, 656);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRealEstate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label lblGetStarted;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblParagraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picRealEstate;
        private System.Windows.Forms.PictureBox picHouse;
    }
}