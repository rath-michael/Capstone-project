namespace WindowsFormsApp3
{
    partial class Search
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
            this.panelBackground = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.panelType = new System.Windows.Forms.Panel();
            this.radSearchByUser = new System.Windows.Forms.RadioButton();
            this.radSearchByDate = new System.Windows.Forms.RadioButton();
            this.panelUserSearch = new System.Windows.Forms.Panel();
            this.picErrorFour = new System.Windows.Forms.PictureBox();
            this.picErrorThree = new System.Windows.Forms.PictureBox();
            this.btnShowDetailsUser = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.txtUserToSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelDateSearch = new System.Windows.Forms.Panel();
            this.picErrorTwo = new System.Windows.Forms.PictureBox();
            this.picErrorOne = new System.Windows.Forms.PictureBox();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.btnShowDetailsDate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelMain.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.panelType.SuspendLayout();
            this.panelUserSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorThree)).BeginInit();
            this.panelDateSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorOne)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.panelMain.Controls.Add(this.panelBackground);
            this.panelMain.Controls.Add(this.panelType);
            this.panelMain.Controls.Add(this.panelUserSearch);
            this.panelMain.Controls.Add(this.panelDateSearch);
            this.panelMain.Controls.Add(this.btnHome);
            this.panelMain.Controls.Add(this.lblMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(992, 656);
            this.panelMain.TabIndex = 0;
            // 
            // panelBackground
            // 
            this.panelBackground.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
            this.panelBackground.Controls.Add(this.lblError);
            this.panelBackground.Location = new System.Drawing.Point(120, 117);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(749, 454);
            this.panelBackground.TabIndex = 64;
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblError.Location = new System.Drawing.Point(134, 185);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(504, 28);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "A database error occured. Please restart.";
            this.lblError.Visible = false;
            // 
            // panelType
            // 
            this.panelType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelType.Controls.Add(this.radSearchByUser);
            this.panelType.Controls.Add(this.radSearchByDate);
            this.panelType.Location = new System.Drawing.Point(274, 40);
            this.panelType.Name = "panelType";
            this.panelType.Size = new System.Drawing.Size(426, 43);
            this.panelType.TabIndex = 63;
            // 
            // radSearchByUser
            // 
            this.radSearchByUser.AutoSize = true;
            this.radSearchByUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSearchByUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.radSearchByUser.Location = new System.Drawing.Point(228, 3);
            this.radSearchByUser.Name = "radSearchByUser";
            this.radSearchByUser.Size = new System.Drawing.Size(176, 26);
            this.radSearchByUser.TabIndex = 62;
            this.radSearchByUser.TabStop = true;
            this.radSearchByUser.Text = "Search By User";
            this.radSearchByUser.UseVisualStyleBackColor = true;
            this.radSearchByUser.CheckedChanged += new System.EventHandler(this.radSearchByUser_CheckedChanged);
            // 
            // radSearchByDate
            // 
            this.radSearchByDate.AutoSize = true;
            this.radSearchByDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSearchByDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.radSearchByDate.Location = new System.Drawing.Point(3, 3);
            this.radSearchByDate.Name = "radSearchByDate";
            this.radSearchByDate.Size = new System.Drawing.Size(178, 26);
            this.radSearchByDate.TabIndex = 61;
            this.radSearchByDate.TabStop = true;
            this.radSearchByDate.Text = "Search By Date";
            this.radSearchByDate.UseVisualStyleBackColor = true;
            this.radSearchByDate.CheckedChanged += new System.EventHandler(this.radSearchByDate_CheckedChanged);
            // 
            // panelUserSearch
            // 
            this.panelUserSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelUserSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
            this.panelUserSearch.Controls.Add(this.picErrorFour);
            this.panelUserSearch.Controls.Add(this.picErrorThree);
            this.panelUserSearch.Controls.Add(this.btnShowDetailsUser);
            this.panelUserSearch.Controls.Add(this.listView2);
            this.panelUserSearch.Controls.Add(this.btnSearchUser);
            this.panelUserSearch.Controls.Add(this.txtUserToSearch);
            this.panelUserSearch.Controls.Add(this.label3);
            this.panelUserSearch.Location = new System.Drawing.Point(120, 117);
            this.panelUserSearch.Name = "panelUserSearch";
            this.panelUserSearch.Size = new System.Drawing.Size(749, 454);
            this.panelUserSearch.TabIndex = 61;
            // 
            // picErrorFour
            // 
            this.picErrorFour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picErrorFour.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorFour.Location = new System.Drawing.Point(603, 216);
            this.picErrorFour.Name = "picErrorFour";
            this.picErrorFour.Size = new System.Drawing.Size(35, 28);
            this.picErrorFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorFour.TabIndex = 50;
            this.picErrorFour.TabStop = false;
            this.picErrorFour.Visible = false;
            // 
            // picErrorThree
            // 
            this.picErrorThree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picErrorThree.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorThree.Location = new System.Drawing.Point(557, 18);
            this.picErrorThree.Name = "picErrorThree";
            this.picErrorThree.Size = new System.Drawing.Size(35, 28);
            this.picErrorThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorThree.TabIndex = 49;
            this.picErrorThree.TabStop = false;
            this.picErrorThree.Visible = false;
            // 
            // btnShowDetailsUser
            // 
            this.btnShowDetailsUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnShowDetailsUser.FlatAppearance.BorderSize = 0;
            this.btnShowDetailsUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDetailsUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetailsUser.ForeColor = System.Drawing.Color.White;
            this.btnShowDetailsUser.Location = new System.Drawing.Point(282, 358);
            this.btnShowDetailsUser.Name = "btnShowDetailsUser";
            this.btnShowDetailsUser.Size = new System.Drawing.Size(177, 47);
            this.btnShowDetailsUser.TabIndex = 13;
            this.btnShowDetailsUser.Text = "Show Details";
            this.btnShowDetailsUser.UseVisualStyleBackColor = false;
            this.btnShowDetailsUser.Click += new System.EventHandler(this.btnShowDetailsUser_Click);
            // 
            // listView2
            // 
            this.listView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(152, 135);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(445, 217);
            this.listView2.TabIndex = 12;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Type";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "User";
            this.columnHeader6.Width = 120;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnSearchUser.FlatAppearance.BorderSize = 0;
            this.btnSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUser.ForeColor = System.Drawing.Color.White;
            this.btnSearchUser.Location = new System.Drawing.Point(282, 52);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(177, 47);
            this.btnSearchUser.TabIndex = 2;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.UseVisualStyleBackColor = false;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchByUser_Click);
            // 
            // txtUserToSearch
            // 
            this.txtUserToSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserToSearch.Location = new System.Drawing.Point(357, 18);
            this.txtUserToSearch.Name = "txtUserToSearch";
            this.txtUserToSearch.Size = new System.Drawing.Size(198, 28);
            this.txtUserToSearch.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label3.Location = new System.Drawing.Point(171, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "User to search:";
            // 
            // panelDateSearch
            // 
            this.panelDateSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDateSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
            this.panelDateSearch.Controls.Add(this.picErrorTwo);
            this.panelDateSearch.Controls.Add(this.picErrorOne);
            this.panelDateSearch.Controls.Add(this.btnSearchDate);
            this.panelDateSearch.Controls.Add(this.btnShowDetailsDate);
            this.panelDateSearch.Controls.Add(this.label6);
            this.panelDateSearch.Controls.Add(this.label2);
            this.panelDateSearch.Controls.Add(this.listView1);
            this.panelDateSearch.Controls.Add(this.dateTimePicker2);
            this.panelDateSearch.Controls.Add(this.dateTimePicker1);
            this.panelDateSearch.Location = new System.Drawing.Point(120, 117);
            this.panelDateSearch.Name = "panelDateSearch";
            this.panelDateSearch.Size = new System.Drawing.Size(749, 454);
            this.panelDateSearch.TabIndex = 60;
            // 
            // picErrorTwo
            // 
            this.picErrorTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picErrorTwo.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorTwo.Location = new System.Drawing.Point(603, 216);
            this.picErrorTwo.Name = "picErrorTwo";
            this.picErrorTwo.Size = new System.Drawing.Size(35, 28);
            this.picErrorTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorTwo.TabIndex = 61;
            this.picErrorTwo.TabStop = false;
            this.picErrorTwo.Visible = false;
            // 
            // picErrorOne
            // 
            this.picErrorOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picErrorOne.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorOne.Location = new System.Drawing.Point(645, 39);
            this.picErrorOne.Name = "picErrorOne";
            this.picErrorOne.Size = new System.Drawing.Size(35, 28);
            this.picErrorOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorOne.TabIndex = 60;
            this.picErrorOne.TabStop = false;
            this.picErrorOne.Visible = false;
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnSearchDate.FlatAppearance.BorderSize = 0;
            this.btnSearchDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDate.ForeColor = System.Drawing.Color.White;
            this.btnSearchDate.Location = new System.Drawing.Point(292, 73);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(177, 47);
            this.btnSearchDate.TabIndex = 58;
            this.btnSearchDate.Text = "Search";
            this.btnSearchDate.UseVisualStyleBackColor = false;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowDetailsDate
            // 
            this.btnShowDetailsDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowDetailsDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnShowDetailsDate.FlatAppearance.BorderSize = 0;
            this.btnShowDetailsDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDetailsDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetailsDate.ForeColor = System.Drawing.Color.White;
            this.btnShowDetailsDate.Location = new System.Drawing.Point(282, 358);
            this.btnShowDetailsDate.Name = "btnShowDetailsDate";
            this.btnShowDetailsDate.Size = new System.Drawing.Size(177, 47);
            this.btnShowDetailsDate.TabIndex = 59;
            this.btnShowDetailsDate.Text = "Show Details";
            this.btnShowDetailsDate.UseVisualStyleBackColor = false;
            this.btnShowDetailsDate.Click += new System.EventHandler(this.btnShowDetails_Click_1);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label6.Location = new System.Drawing.Point(161, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label2.Location = new System.Drawing.Point(452, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "End Date";
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(152, 135);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(445, 217);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date Completed";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width = 120;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.Location = new System.Drawing.Point(384, 45);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(255, 22);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHome.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_home_page_50px_1;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(459, 589);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(72, 63);
            this.btnHome.TabIndex = 57;
            this.toolTip1.SetToolTip(this.btnHome, "Go To Home Page");
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblMain
            // 
            this.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblMain.Location = new System.Drawing.Point(327, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(354, 28);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = "Search Previous Calculations";
            // 
            // toolTip1
            // 
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(992, 656);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.Text = "SignIn";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.panelType.ResumeLayout(false);
            this.panelType.PerformLayout();
            this.panelUserSearch.ResumeLayout(false);
            this.panelUserSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorThree)).EndInit();
            this.panelDateSearch.ResumeLayout(false);
            this.panelDateSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorOne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnShowDetailsDate;
        private System.Windows.Forms.Panel panelDateSearch;
        private System.Windows.Forms.Panel panelType;
        private System.Windows.Forms.RadioButton radSearchByUser;
        private System.Windows.Forms.RadioButton radSearchByDate;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.Panel panelUserSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.TextBox txtUserToSearch;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnShowDetailsUser;
        private System.Windows.Forms.PictureBox picErrorThree;
        private System.Windows.Forms.PictureBox picErrorOne;
        private System.Windows.Forms.PictureBox picErrorFour;
        private System.Windows.Forms.PictureBox picErrorTwo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblError;
    }
}