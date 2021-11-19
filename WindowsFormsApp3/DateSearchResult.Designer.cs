namespace WindowsFormsApp3
{
    partial class DateSearchResult
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
            this.components = new System.ComponentModel.Container();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.listDisplay = new System.Windows.Forms.ListBox();
            this.btnNewSearch = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.lblErrorTwo = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelMain.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.panelMain.Controls.Add(this.btnHome);
            this.panelMain.Controls.Add(this.listDisplay);
            this.panelMain.Controls.Add(this.btnNewSearch);
            this.panelMain.Controls.Add(this.lblMain);
            this.panelMain.Controls.Add(this.panelBackground);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(992, 656);
            this.panelMain.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHome.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_home_page_50px_1;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(4, 589);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(72, 63);
            this.btnHome.TabIndex = 58;
            this.toolTip1.SetToolTip(this.btnHome, "Go To Home Page");
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // listDisplay
            // 
            this.listDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDisplay.FormattingEnabled = true;
            this.listDisplay.ItemHeight = 22;
            this.listDisplay.Location = new System.Drawing.Point(256, 61);
            this.listDisplay.Name = "listDisplay";
            this.listDisplay.Size = new System.Drawing.Size(468, 510);
            this.listDisplay.TabIndex = 11;
            // 
            // btnNewSearch
            // 
            this.btnNewSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewSearch.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_restart_50px;
            this.btnNewSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNewSearch.FlatAppearance.BorderSize = 0;
            this.btnNewSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSearch.Location = new System.Drawing.Point(916, 589);
            this.btnNewSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewSearch.Name = "btnNewSearch";
            this.btnNewSearch.Size = new System.Drawing.Size(72, 63);
            this.btnNewSearch.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnNewSearch, "Start Over");
            this.btnNewSearch.UseVisualStyleBackColor = true;
            this.btnNewSearch.Click += new System.EventHandler(this.btnNewSearch_Click);
            // 
            // lblMain
            // 
            this.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblMain.Location = new System.Drawing.Point(387, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(188, 28);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = "Search Results";
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
            this.panelBackground.Controls.Add(this.lblErrorTwo);
            this.panelBackground.Controls.Add(this.lblError);
            this.panelBackground.Location = new System.Drawing.Point(256, 61);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(468, 510);
            this.panelBackground.TabIndex = 59;
            this.panelBackground.Visible = false;
            // 
            // lblErrorTwo
            // 
            this.lblErrorTwo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblErrorTwo.AutoSize = true;
            this.lblErrorTwo.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblErrorTwo.Location = new System.Drawing.Point(56, 262);
            this.lblErrorTwo.Name = "lblErrorTwo";
            this.lblErrorTwo.Size = new System.Drawing.Size(185, 28);
            this.lblErrorTwo.TabIndex = 4;
            this.lblErrorTwo.Text = "Please restart.";
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblError.Location = new System.Drawing.Point(56, 225);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(322, 28);
            this.lblError.TabIndex = 3;
            this.lblError.Text = "A database error occured.";
            // 
            // toolTip1
            // 
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // DateSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(992, 656);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DateSearchResult";
            this.Text = "SearchResult";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button btnNewSearch;
        private System.Windows.Forms.ListBox listDisplay;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label lblErrorTwo;
        private System.Windows.Forms.Label lblError;
    }
}