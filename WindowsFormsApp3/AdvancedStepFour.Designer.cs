namespace WindowsFormsApp3
{
    partial class AdvancedStepFour
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.picErrorOne = new System.Windows.Forms.PictureBox();
            this.picErrorThree = new System.Windows.Forms.PictureBox();
            this.picErrorTwo = new System.Windows.Forms.PictureBox();
            this.picErrorFour = new System.Windows.Forms.PictureBox();
            this.picErrorFive = new System.Windows.Forms.PictureBox();
            this.picErrorSix = new System.Windows.Forms.PictureBox();
            this.picErrorSeven = new System.Windows.Forms.PictureBox();
            this.picErrorEight = new System.Windows.Forms.PictureBox();
            this.cboEastWallSiding = new System.Windows.Forms.ComboBox();
            this.cboEastWallInsulation = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboEastWallFrame = new System.Windows.Forms.ComboBox();
            this.txtEastWall = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblWalls = new System.Windows.Forms.Label();
            this.cboEastDoor = new System.Windows.Forms.ComboBox();
            this.txtEastDoor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDoors = new System.Windows.Forms.Label();
            this.lblWindows = new System.Windows.Forms.Label();
            this.cboEastWindow = new System.Windows.Forms.ComboBox();
            this.txtEastWindow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEast = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorSix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorSeven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorEight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblMain.Location = new System.Drawing.Point(425, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(129, 28);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Step Four";
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
            this.btnNext.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnNext, "Go To Next Step");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            this.btnPrevious.TabIndex = 31;
            this.toolTip1.SetToolTip(this.btnPrevious, "Go To Previous Step");
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnHome);
            this.panelMain.Controls.Add(this.picErrorOne);
            this.panelMain.Controls.Add(this.picErrorThree);
            this.panelMain.Controls.Add(this.picErrorTwo);
            this.panelMain.Controls.Add(this.picErrorFour);
            this.panelMain.Controls.Add(this.picErrorFive);
            this.panelMain.Controls.Add(this.picErrorSix);
            this.panelMain.Controls.Add(this.picErrorSeven);
            this.panelMain.Controls.Add(this.picErrorEight);
            this.panelMain.Controls.Add(this.cboEastWallSiding);
            this.panelMain.Controls.Add(this.cboEastWallInsulation);
            this.panelMain.Controls.Add(this.label9);
            this.panelMain.Controls.Add(this.label10);
            this.panelMain.Controls.Add(this.cboEastWallFrame);
            this.panelMain.Controls.Add(this.txtEastWall);
            this.panelMain.Controls.Add(this.label11);
            this.panelMain.Controls.Add(this.label12);
            this.panelMain.Controls.Add(this.lblWalls);
            this.panelMain.Controls.Add(this.cboEastDoor);
            this.panelMain.Controls.Add(this.txtEastDoor);
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Controls.Add(this.label8);
            this.panelMain.Controls.Add(this.lblDoors);
            this.panelMain.Controls.Add(this.lblWindows);
            this.panelMain.Controls.Add(this.cboEastWindow);
            this.panelMain.Controls.Add(this.txtEastWindow);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.lblEast);
            this.panelMain.Controls.Add(this.btnPrevious);
            this.panelMain.Controls.Add(this.btnNext);
            this.panelMain.Controls.Add(this.lblMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(992, 656);
            this.panelMain.TabIndex = 13;
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
            this.btnHome.TabIndex = 76;
            this.toolTip1.SetToolTip(this.btnHome, "Go To Home Page");
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // picErrorOne
            // 
            this.picErrorOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picErrorOne.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorOne.Location = new System.Drawing.Point(625, 103);
            this.picErrorOne.Name = "picErrorOne";
            this.picErrorOne.Size = new System.Drawing.Size(35, 28);
            this.picErrorOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorOne.TabIndex = 75;
            this.picErrorOne.TabStop = false;
            this.picErrorOne.Visible = false;
            // 
            // picErrorThree
            // 
            this.picErrorThree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picErrorThree.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorThree.Location = new System.Drawing.Point(625, 231);
            this.picErrorThree.Name = "picErrorThree";
            this.picErrorThree.Size = new System.Drawing.Size(35, 28);
            this.picErrorThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorThree.TabIndex = 74;
            this.picErrorThree.TabStop = false;
            this.picErrorThree.Visible = false;
            // 
            // picErrorTwo
            // 
            this.picErrorTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picErrorTwo.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorTwo.Location = new System.Drawing.Point(718, 159);
            this.picErrorTwo.Name = "picErrorTwo";
            this.picErrorTwo.Size = new System.Drawing.Size(35, 28);
            this.picErrorTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorTwo.TabIndex = 73;
            this.picErrorTwo.TabStop = false;
            this.picErrorTwo.Visible = false;
            // 
            // picErrorFour
            // 
            this.picErrorFour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picErrorFour.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorFour.Location = new System.Drawing.Point(718, 287);
            this.picErrorFour.Name = "picErrorFour";
            this.picErrorFour.Size = new System.Drawing.Size(35, 28);
            this.picErrorFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorFour.TabIndex = 72;
            this.picErrorFour.TabStop = false;
            this.picErrorFour.Visible = false;
            // 
            // picErrorFive
            // 
            this.picErrorFive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picErrorFive.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorFive.Location = new System.Drawing.Point(625, 370);
            this.picErrorFive.Name = "picErrorFive";
            this.picErrorFive.Size = new System.Drawing.Size(35, 28);
            this.picErrorFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorFive.TabIndex = 71;
            this.picErrorFive.TabStop = false;
            this.picErrorFive.Visible = false;
            // 
            // picErrorSix
            // 
            this.picErrorSix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picErrorSix.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorSix.Location = new System.Drawing.Point(718, 426);
            this.picErrorSix.Name = "picErrorSix";
            this.picErrorSix.Size = new System.Drawing.Size(35, 28);
            this.picErrorSix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorSix.TabIndex = 70;
            this.picErrorSix.TabStop = false;
            this.picErrorSix.Visible = false;
            // 
            // picErrorSeven
            // 
            this.picErrorSeven.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picErrorSeven.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorSeven.Location = new System.Drawing.Point(718, 484);
            this.picErrorSeven.Name = "picErrorSeven";
            this.picErrorSeven.Size = new System.Drawing.Size(35, 28);
            this.picErrorSeven.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorSeven.TabIndex = 69;
            this.picErrorSeven.TabStop = false;
            this.picErrorSeven.Visible = false;
            // 
            // picErrorEight
            // 
            this.picErrorEight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picErrorEight.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorEight.Location = new System.Drawing.Point(718, 542);
            this.picErrorEight.Name = "picErrorEight";
            this.picErrorEight.Size = new System.Drawing.Size(35, 28);
            this.picErrorEight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorEight.TabIndex = 68;
            this.picErrorEight.TabStop = false;
            this.picErrorEight.Visible = false;
            // 
            // cboEastWallSiding
            // 
            this.cboEastWallSiding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEastWallSiding.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEastWallSiding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.cboEastWallSiding.FormattingEnabled = true;
            this.cboEastWallSiding.Items.AddRange(new object[] {
            "Gypsum",
            "Poly-board",
            "R-8 Sheathing"});
            this.cboEastWallSiding.Location = new System.Drawing.Point(488, 542);
            this.cboEastWallSiding.Name = "cboEastWallSiding";
            this.cboEastWallSiding.Size = new System.Drawing.Size(224, 30);
            this.cboEastWallSiding.TabIndex = 67;
            this.cboEastWallSiding.Text = "Make Selection";
            // 
            // cboEastWallInsulation
            // 
            this.cboEastWallInsulation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEastWallInsulation.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEastWallInsulation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.cboEastWallInsulation.FormattingEnabled = true;
            this.cboEastWallInsulation.Items.AddRange(new object[] {
            "None",
            "R-11",
            "R-13",
            "R-19"});
            this.cboEastWallInsulation.Location = new System.Drawing.Point(488, 484);
            this.cboEastWallInsulation.Name = "cboEastWallInsulation";
            this.cboEastWallInsulation.Size = new System.Drawing.Size(224, 30);
            this.cboEastWallInsulation.TabIndex = 66;
            this.cboEastWallInsulation.Text = "Make Selection";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label9.Location = new System.Drawing.Point(332, 545);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 22);
            this.label9.TabIndex = 65;
            this.label9.Text = "Siding Type:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label10.Location = new System.Drawing.Point(296, 487);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 22);
            this.label10.TabIndex = 64;
            this.label10.Text = "Insulation Type:";
            // 
            // cboEastWallFrame
            // 
            this.cboEastWallFrame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEastWallFrame.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEastWallFrame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.cboEastWallFrame.FormattingEnabled = true;
            this.cboEastWallFrame.Items.AddRange(new object[] {
            "Wood",
            "Wood With Partition",
            "Masonry"});
            this.cboEastWallFrame.Location = new System.Drawing.Point(488, 426);
            this.cboEastWallFrame.Name = "cboEastWallFrame";
            this.cboEastWallFrame.Size = new System.Drawing.Size(224, 30);
            this.cboEastWallFrame.TabIndex = 63;
            this.cboEastWallFrame.Text = "Make Selection";
            // 
            // txtEastWall
            // 
            this.txtEastWall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEastWall.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEastWall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.txtEastWall.Location = new System.Drawing.Point(488, 370);
            this.txtEastWall.Name = "txtEastWall";
            this.txtEastWall.Size = new System.Drawing.Size(131, 28);
            this.txtEastWall.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label11.Location = new System.Drawing.Point(334, 429);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 22);
            this.label11.TabIndex = 61;
            this.label11.Text = "Frame Type:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label12.Location = new System.Drawing.Point(274, 373);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 22);
            this.label12.TabIndex = 60;
            this.label12.Text = "Total Area (SQFT):";
            // 
            // lblWalls
            // 
            this.lblWalls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWalls.AutoSize = true;
            this.lblWalls.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWalls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblWalls.Location = new System.Drawing.Point(420, 342);
            this.lblWalls.Name = "lblWalls";
            this.lblWalls.Size = new System.Drawing.Size(143, 22);
            this.lblWalls.TabIndex = 59;
            this.lblWalls.Text = "Exterior Walls";
            // 
            // cboEastDoor
            // 
            this.cboEastDoor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEastDoor.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEastDoor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.cboEastDoor.FormattingEnabled = true;
            this.cboEastDoor.Items.AddRange(new object[] {
            "Solid Wood",
            "Metal-Fiber Core",
            "Metal-Urethane Core",
            "Metal-Polystyrene Core"});
            this.cboEastDoor.Location = new System.Drawing.Point(488, 287);
            this.cboEastDoor.Name = "cboEastDoor";
            this.cboEastDoor.Size = new System.Drawing.Size(224, 30);
            this.cboEastDoor.TabIndex = 58;
            this.cboEastDoor.Text = "Make Selection";
            // 
            // txtEastDoor
            // 
            this.txtEastDoor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEastDoor.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEastDoor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.txtEastDoor.Location = new System.Drawing.Point(488, 231);
            this.txtEastDoor.Name = "txtEastDoor";
            this.txtEastDoor.Size = new System.Drawing.Size(131, 28);
            this.txtEastDoor.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label7.Location = new System.Drawing.Point(272, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 22);
            this.label7.TabIndex = 56;
            this.label7.Text = "Construction Type:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label8.Location = new System.Drawing.Point(274, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 22);
            this.label8.TabIndex = 55;
            this.label8.Text = "Total Area (SQFT):";
            // 
            // lblDoors
            // 
            this.lblDoors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDoors.AutoSize = true;
            this.lblDoors.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblDoors.Location = new System.Drawing.Point(451, 206);
            this.lblDoors.Name = "lblDoors";
            this.lblDoors.Size = new System.Drawing.Size(64, 22);
            this.lblDoors.TabIndex = 54;
            this.lblDoors.Text = "Doors";
            // 
            // lblWindows
            // 
            this.lblWindows.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWindows.AutoSize = true;
            this.lblWindows.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblWindows.Location = new System.Drawing.Point(430, 78);
            this.lblWindows.Name = "lblWindows";
            this.lblWindows.Size = new System.Drawing.Size(94, 22);
            this.lblWindows.TabIndex = 53;
            this.lblWindows.Text = "Windows";
            // 
            // cboEastWindow
            // 
            this.cboEastWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEastWindow.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEastWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.cboEastWindow.FormattingEnabled = true;
            this.cboEastWindow.Items.AddRange(new object[] {
            "Single Pane",
            "Double Pane"});
            this.cboEastWindow.Location = new System.Drawing.Point(488, 159);
            this.cboEastWindow.Name = "cboEastWindow";
            this.cboEastWindow.Size = new System.Drawing.Size(224, 30);
            this.cboEastWindow.TabIndex = 52;
            this.cboEastWindow.Text = "Make Selection";
            // 
            // txtEastWindow
            // 
            this.txtEastWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEastWindow.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEastWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.txtEastWindow.Location = new System.Drawing.Point(488, 103);
            this.txtEastWindow.Name = "txtEastWindow";
            this.txtEastWindow.Size = new System.Drawing.Size(131, 28);
            this.txtEastWindow.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label4.Location = new System.Drawing.Point(272, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 22);
            this.label4.TabIndex = 50;
            this.label4.Text = "Construction Type:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label3.Location = new System.Drawing.Point(274, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 22);
            this.label3.TabIndex = 49;
            this.label3.Text = "Total Area (SQFT):";
            // 
            // lblEast
            // 
            this.lblEast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEast.AutoSize = true;
            this.lblEast.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(207)))), ((int)(((byte)(38)))));
            this.lblEast.Location = new System.Drawing.Point(296, 37);
            this.lblEast.Name = "lblEast";
            this.lblEast.Size = new System.Drawing.Size(422, 22);
            this.lblEast.TabIndex = 48;
            this.lblEast.Text = "Information for buildings eastern exposure";
            // 
            // toolTip1
            // 
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // AdvancedStepFour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(992, 656);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdvancedStepFour";
            this.Text = "AdvancedStepFour";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorSix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorSeven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorEight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ComboBox cboEastWallSiding;
        private System.Windows.Forms.ComboBox cboEastWallInsulation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboEastWallFrame;
        private System.Windows.Forms.TextBox txtEastWall;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblWalls;
        private System.Windows.Forms.ComboBox cboEastDoor;
        private System.Windows.Forms.TextBox txtEastDoor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDoors;
        private System.Windows.Forms.Label lblWindows;
        private System.Windows.Forms.ComboBox cboEastWindow;
        private System.Windows.Forms.TextBox txtEastWindow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEast;
        private System.Windows.Forms.PictureBox picErrorOne;
        private System.Windows.Forms.PictureBox picErrorThree;
        private System.Windows.Forms.PictureBox picErrorTwo;
        private System.Windows.Forms.PictureBox picErrorFour;
        private System.Windows.Forms.PictureBox picErrorFive;
        private System.Windows.Forms.PictureBox picErrorSix;
        private System.Windows.Forms.PictureBox picErrorSeven;
        private System.Windows.Forms.PictureBox picErrorEight;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}