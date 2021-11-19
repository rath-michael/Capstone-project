namespace WindowsFormsApp3
{
    partial class AdvancedStepFive
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.picErrorFour = new System.Windows.Forms.PictureBox();
            this.picErrorThree = new System.Windows.Forms.PictureBox();
            this.picErrorTwo = new System.Windows.Forms.PictureBox();
            this.picErrorOne = new System.Windows.Forms.PictureBox();
            this.cboRoofConst = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboRoofColor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboFloorType = new System.Windows.Forms.ComboBox();
            this.cboFloorConst = new System.Windows.Forms.ComboBox();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblCeiling = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorOne)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.txtUsername);
            this.panelMain.Controls.Add(this.lblUsername);
            this.panelMain.Controls.Add(this.btnHome);
            this.panelMain.Controls.Add(this.btnPrevious);
            this.panelMain.Controls.Add(this.btnFinish);
            this.panelMain.Controls.Add(this.picErrorFour);
            this.panelMain.Controls.Add(this.picErrorThree);
            this.panelMain.Controls.Add(this.picErrorTwo);
            this.panelMain.Controls.Add(this.picErrorOne);
            this.panelMain.Controls.Add(this.cboRoofConst);
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.cboRoofColor);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.cboFloorType);
            this.panelMain.Controls.Add(this.cboFloorConst);
            this.panelMain.Controls.Add(this.lblFloor);
            this.panelMain.Controls.Add(this.lblCeiling);
            this.panelMain.Controls.Add(this.lblMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(992, 656);
            this.panelMain.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.txtUsername.Location = new System.Drawing.Point(382, 487);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(239, 28);
            this.txtUsername.TabIndex = 57;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblUsername.Location = new System.Drawing.Point(296, 449);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(418, 22);
            this.lblUsername.TabIndex = 56;
            this.lblUsername.Text = "(Optional) Add a name to this calculation?\r\n";
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
            this.btnHome.TabIndex = 55;
            this.toolTip1.SetToolTip(this.btnHome, "Go To Home Page");
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevious.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_left_50px;
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(4, 589);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(72, 63);
            this.btnPrevious.TabIndex = 54;
            this.toolTip1.SetToolTip(this.btnPrevious, "Go To Previous Page");
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_checked_50px;
            this.btnFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFinish.FlatAppearance.BorderSize = 0;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Location = new System.Drawing.Point(916, 589);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(72, 63);
            this.btnFinish.TabIndex = 53;
            this.toolTip1.SetToolTip(this.btnFinish, "Get Results");
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // picErrorFour
            // 
            this.picErrorFour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picErrorFour.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorFour.Location = new System.Drawing.Point(723, 380);
            this.picErrorFour.Name = "picErrorFour";
            this.picErrorFour.Size = new System.Drawing.Size(35, 28);
            this.picErrorFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorFour.TabIndex = 52;
            this.picErrorFour.TabStop = false;
            this.picErrorFour.Visible = false;
            // 
            // picErrorThree
            // 
            this.picErrorThree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picErrorThree.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorThree.Location = new System.Drawing.Point(723, 308);
            this.picErrorThree.Name = "picErrorThree";
            this.picErrorThree.Size = new System.Drawing.Size(35, 28);
            this.picErrorThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorThree.TabIndex = 51;
            this.picErrorThree.TabStop = false;
            this.picErrorThree.Visible = false;
            // 
            // picErrorTwo
            // 
            this.picErrorTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picErrorTwo.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorTwo.Location = new System.Drawing.Point(723, 219);
            this.picErrorTwo.Name = "picErrorTwo";
            this.picErrorTwo.Size = new System.Drawing.Size(35, 28);
            this.picErrorTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorTwo.TabIndex = 50;
            this.picErrorTwo.TabStop = false;
            this.picErrorTwo.Visible = false;
            // 
            // picErrorOne
            // 
            this.picErrorOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picErrorOne.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorOne.Location = new System.Drawing.Point(723, 147);
            this.picErrorOne.Name = "picErrorOne";
            this.picErrorOne.Size = new System.Drawing.Size(35, 28);
            this.picErrorOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorOne.TabIndex = 49;
            this.picErrorOne.TabStop = false;
            this.picErrorOne.Visible = false;
            // 
            // cboRoofConst
            // 
            this.cboRoofConst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboRoofConst.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoofConst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.cboRoofConst.FormattingEnabled = true;
            this.cboRoofConst.Items.AddRange(new object[] {
            "Ceiling under vented attic",
            "Roof on exposed beams/rafters",
            "Roof-ceiling combination"});
            this.cboRoofConst.Location = new System.Drawing.Point(415, 219);
            this.cboRoofConst.Name = "cboRoofConst";
            this.cboRoofConst.Size = new System.Drawing.Size(302, 30);
            this.cboRoofConst.TabIndex = 42;
            this.cboRoofConst.Text = "Make Selection";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label7.Location = new System.Drawing.Point(205, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 22);
            this.label7.TabIndex = 41;
            this.label7.Text = "Roof construction";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label6.Location = new System.Drawing.Point(247, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 22);
            this.label6.TabIndex = 40;
            this.label6.Text = "Roof coloring";
            // 
            // cboRoofColor
            // 
            this.cboRoofColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboRoofColor.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoofColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.cboRoofColor.FormattingEnabled = true;
            this.cboRoofColor.Items.AddRange(new object[] {
            "Dark colored roof",
            "Light colored roof"});
            this.cboRoofColor.Location = new System.Drawing.Point(415, 147);
            this.cboRoofColor.Name = "cboRoofColor";
            this.cboRoofColor.Size = new System.Drawing.Size(302, 30);
            this.cboRoofColor.TabIndex = 39;
            this.cboRoofColor.Text = "Make Selection";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label4.Location = new System.Drawing.Point(246, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 22);
            this.label4.TabIndex = 38;
            this.label4.Text = "Flooring type";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label3.Location = new System.Drawing.Point(200, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 22);
            this.label3.TabIndex = 37;
            this.label3.Text = "Floor construction";
            // 
            // cboFloorType
            // 
            this.cboFloorType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboFloorType.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFloorType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.cboFloorType.FormattingEnabled = true;
            this.cboFloorType.Items.AddRange(new object[] {
            "Majority hardwood flooring",
            "Majority carpet flooring"});
            this.cboFloorType.Location = new System.Drawing.Point(415, 380);
            this.cboFloorType.Name = "cboFloorType";
            this.cboFloorType.Size = new System.Drawing.Size(302, 30);
            this.cboFloorType.TabIndex = 36;
            this.cboFloorType.Text = "Make Selection";
            // 
            // cboFloorConst
            // 
            this.cboFloorConst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboFloorConst.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFloorConst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.cboFloorConst.FormattingEnabled = true;
            this.cboFloorConst.Items.AddRange(new object[] {
            "Flooring over crawlspace",
            "Flooring over basement",
            "Flooring over concrete slab"});
            this.cboFloorConst.Location = new System.Drawing.Point(415, 308);
            this.cboFloorConst.Name = "cboFloorConst";
            this.cboFloorConst.Size = new System.Drawing.Size(302, 30);
            this.cboFloorConst.TabIndex = 35;
            this.cboFloorConst.Text = "Make Selection";
            // 
            // lblFloor
            // 
            this.lblFloor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFloor.AutoSize = true;
            this.lblFloor.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblFloor.Location = new System.Drawing.Point(432, 272);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(67, 22);
            this.lblFloor.TabIndex = 34;
            this.lblFloor.Text = "Floors";
            // 
            // lblCeiling
            // 
            this.lblCeiling.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCeiling.AutoSize = true;
            this.lblCeiling.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCeiling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblCeiling.Location = new System.Drawing.Point(432, 100);
            this.lblCeiling.Name = "lblCeiling";
            this.lblCeiling.Size = new System.Drawing.Size(86, 22);
            this.lblCeiling.TabIndex = 33;
            this.lblCeiling.Text = "Ceilings";
            // 
            // lblMain
            // 
            this.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblMain.Location = new System.Drawing.Point(326, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(125, 28);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = "Step Five";
            // 
            // toolTip1
            // 
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // AdvancedStepFive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(992, 656);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdvancedStepFive";
            this.Text = "AdvancedStepFive";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorOne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Label lblCeiling;
        private System.Windows.Forms.ComboBox cboFloorConst;
        private System.Windows.Forms.ComboBox cboRoofConst;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboRoofColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboFloorType;
        private System.Windows.Forms.PictureBox picErrorFour;
        private System.Windows.Forms.PictureBox picErrorThree;
        private System.Windows.Forms.PictureBox picErrorTwo;
        private System.Windows.Forms.PictureBox picErrorOne;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}