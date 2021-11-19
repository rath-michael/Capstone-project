namespace WindowsFormsApp3
{
    partial class BasicStepOne
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
            this.lblMain = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblRegion = new System.Windows.Forms.Label();
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnHome = new System.Windows.Forms.Button();
            this.picErrorOne = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.picHeatMap = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeatMap)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblMain.Location = new System.Drawing.Point(333, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(123, 28);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Step One";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lblRegion);
            this.panelMain.Controls.Add(this.btnHome);
            this.panelMain.Controls.Add(this.picErrorOne);
            this.panelMain.Controls.Add(this.cboRegion);
            this.panelMain.Controls.Add(this.btnNext);
            this.panelMain.Controls.Add(this.picHeatMap);
            this.panelMain.Controls.Add(this.lblMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(992, 656);
            this.panelMain.TabIndex = 6;
            // 
            // lblRegion
            // 
            this.lblRegion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblRegion.Location = new System.Drawing.Point(371, 99);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(190, 22);
            this.lblRegion.TabIndex = 59;
            this.lblRegion.Text = "Select Your Region";
            // 
            // cboRegion
            // 
            this.cboRegion.AccessibleName = "cboRegion";
            this.cboRegion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboRegion.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRegion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.cboRegion.FormattingEnabled = true;
            this.cboRegion.Items.AddRange(new object[] {
            "Region 1 - Blue",
            "Region 2 - Green",
            "Region 3 - Yellow",
            "Region 4 - Orange",
            "Region 5 - Red"});
            this.cboRegion.Location = new System.Drawing.Point(359, 123);
            this.cboRegion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(225, 30);
            this.cboRegion.TabIndex = 6;
            this.cboRegion.Text = "Make Selection";
            this.myToolTip.SetToolTip(this.cboRegion, "Select Your Region");
            // 
            // myToolTip
            // 
            this.myToolTip.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.myToolTip_Draw);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHome.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_home_page_50px_1;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(471, 589);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(72, 63);
            this.btnHome.TabIndex = 21;
            this.myToolTip.SetToolTip(this.btnHome, "Go To Home Page");
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // picErrorOne
            // 
            this.picErrorOne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picErrorOne.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorOne.Location = new System.Drawing.Point(612, 125);
            this.picErrorOne.Name = "picErrorOne";
            this.picErrorOne.Size = new System.Drawing.Size(35, 28);
            this.picErrorOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorOne.TabIndex = 20;
            this.picErrorOne.TabStop = false;
            this.picErrorOne.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_right_50px;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(916, 589);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(72, 63);
            this.btnNext.TabIndex = 4;
            this.myToolTip.SetToolTip(this.btnNext, "Go To Next Step");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnForm2Next_Click);
            // 
            // picHeatMap
            // 
            this.picHeatMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picHeatMap.Image = global::WindowsFormsApp3.Properties.Resources.climate_map;
            this.picHeatMap.Location = new System.Drawing.Point(170, 160);
            this.picHeatMap.Margin = new System.Windows.Forms.Padding(4);
            this.picHeatMap.Name = "picHeatMap";
            this.picHeatMap.Size = new System.Drawing.Size(619, 387);
            this.picHeatMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHeatMap.TabIndex = 5;
            this.picHeatMap.TabStop = false;
            // 
            // BasicStepOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(992, 656);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BasicStepOne";
            this.Text = "Form2";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeatMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox picHeatMap;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.PictureBox picErrorOne;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ToolTip myToolTip;
        private System.Windows.Forms.Label lblRegion;
    }
}