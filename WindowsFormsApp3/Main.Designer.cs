namespace WindowsFormsApp3
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelWeatherFail = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWeatherCondition = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.panelHelp = new System.Windows.Forms.Panel();
            this.btnContactUs = new System.Windows.Forms.Button();
            this.btnHowItWorks = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panelGetStarted = new System.Windows.Forms.Panel();
            this.btnAdvancedEdition = new System.Windows.Forms.Button();
            this.btnBasicEdition = new System.Windows.Forms.Button();
            this.btnGetStarted = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picWeatherIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelWeatherFail.SuspendLayout();
            this.panelAccount.SuspendLayout();
            this.panelHelp.SuspendLayout();
            this.panelGetStarted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.MinimumSize = new System.Drawing.Size(1213, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 89);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label3.Location = new System.Drawing.Point(87, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "HVAC Load Calculator";
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(102)))));
            this.panelSideMenu.Controls.Add(this.panelWeatherFail);
            this.panelSideMenu.Controls.Add(this.lblWeatherCondition);
            this.panelSideMenu.Controls.Add(this.picWeatherIcon);
            this.panelSideMenu.Controls.Add(this.lblTemp);
            this.panelSideMenu.Controls.Add(this.panelAccount);
            this.panelSideMenu.Controls.Add(this.btnHistory);
            this.panelSideMenu.Controls.Add(this.panelHelp);
            this.panelSideMenu.Controls.Add(this.btnHelp);
            this.panelSideMenu.Controls.Add(this.panelGetStarted);
            this.panelSideMenu.Controls.Add(this.btnGetStarted);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 89);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(221, 703);
            this.panelSideMenu.TabIndex = 1;
            // 
            // panelWeatherFail
            // 
            this.panelWeatherFail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelWeatherFail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(102)))));
            this.panelWeatherFail.Controls.Add(this.label2);
            this.panelWeatherFail.Controls.Add(this.label1);
            this.panelWeatherFail.Location = new System.Drawing.Point(6, 481);
            this.panelWeatherFail.Name = "panelWeatherFail";
            this.panelWeatherFail.Size = new System.Drawing.Size(212, 219);
            this.panelWeatherFail.TabIndex = 7;
            this.panelWeatherFail.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Not Available";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Weather Data";
            // 
            // lblWeatherCondition
            // 
            this.lblWeatherCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWeatherCondition.AutoSize = true;
            this.lblWeatherCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeatherCondition.Location = new System.Drawing.Point(12, 671);
            this.lblWeatherCondition.Name = "lblWeatherCondition";
            this.lblWeatherCondition.Size = new System.Drawing.Size(104, 25);
            this.lblWeatherCondition.TabIndex = 7;
            this.lblWeatherCondition.Text = "Condition";
            this.lblWeatherCondition.Visible = false;
            // 
            // lblTemp
            // 
            this.lblTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(12, 639);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(67, 25);
            this.lblTemp.TabIndex = 2;
            this.lblTemp.Text = "Temp";
            this.lblTemp.Visible = false;
            // 
            // panelAccount
            // 
            this.panelAccount.Controls.Add(this.btnViewAll);
            this.panelAccount.Controls.Add(this.btnSearch);
            this.panelAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAccount.Location = new System.Drawing.Point(0, 330);
            this.panelAccount.Margin = new System.Windows.Forms.Padding(4);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(221, 97);
            this.panelAccount.TabIndex = 7;
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(97)))), ((int)(((byte)(120)))));
            this.btnViewAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewAll.FlatAppearance.BorderSize = 0;
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnViewAll.Location = new System.Drawing.Point(0, 46);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnViewAll.Size = new System.Drawing.Size(221, 46);
            this.btnViewAll.TabIndex = 5;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(97)))), ((int)(((byte)(120)))));
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(221, 46);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(102)))));
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnHistory.Location = new System.Drawing.Point(0, 284);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnHistory.Size = new System.Drawing.Size(221, 46);
            this.btnHistory.TabIndex = 6;
            this.btnHistory.Text = "History";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // panelHelp
            // 
            this.panelHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(97)))), ((int)(((byte)(120)))));
            this.panelHelp.Controls.Add(this.btnContactUs);
            this.panelHelp.Controls.Add(this.btnHowItWorks);
            this.panelHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHelp.Location = new System.Drawing.Point(0, 188);
            this.panelHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(221, 96);
            this.panelHelp.TabIndex = 3;
            // 
            // btnContactUs
            // 
            this.btnContactUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(97)))), ((int)(((byte)(120)))));
            this.btnContactUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContactUs.FlatAppearance.BorderSize = 0;
            this.btnContactUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContactUs.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContactUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnContactUs.Location = new System.Drawing.Point(0, 46);
            this.btnContactUs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContactUs.Name = "btnContactUs";
            this.btnContactUs.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnContactUs.Size = new System.Drawing.Size(221, 46);
            this.btnContactUs.TabIndex = 4;
            this.btnContactUs.Text = "Contact Us";
            this.btnContactUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContactUs.UseVisualStyleBackColor = false;
            this.btnContactUs.Click += new System.EventHandler(this.btnContactUs_Click);
            // 
            // btnHowItWorks
            // 
            this.btnHowItWorks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(97)))), ((int)(((byte)(120)))));
            this.btnHowItWorks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHowItWorks.FlatAppearance.BorderSize = 0;
            this.btnHowItWorks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHowItWorks.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowItWorks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnHowItWorks.Location = new System.Drawing.Point(0, 0);
            this.btnHowItWorks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHowItWorks.Name = "btnHowItWorks";
            this.btnHowItWorks.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnHowItWorks.Size = new System.Drawing.Size(221, 46);
            this.btnHowItWorks.TabIndex = 3;
            this.btnHowItWorks.Text = "How It Works";
            this.btnHowItWorks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHowItWorks.UseVisualStyleBackColor = false;
            this.btnHowItWorks.Click += new System.EventHandler(this.btnHowItWorks_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(102)))));
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnHelp.Location = new System.Drawing.Point(0, 142);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(221, 46);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panelGetStarted
            // 
            this.panelGetStarted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(97)))), ((int)(((byte)(120)))));
            this.panelGetStarted.Controls.Add(this.btnAdvancedEdition);
            this.panelGetStarted.Controls.Add(this.btnBasicEdition);
            this.panelGetStarted.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGetStarted.Location = new System.Drawing.Point(0, 46);
            this.panelGetStarted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelGetStarted.Name = "panelGetStarted";
            this.panelGetStarted.Size = new System.Drawing.Size(221, 96);
            this.panelGetStarted.TabIndex = 1;
            // 
            // btnAdvancedEdition
            // 
            this.btnAdvancedEdition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(97)))), ((int)(((byte)(120)))));
            this.btnAdvancedEdition.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdvancedEdition.FlatAppearance.BorderSize = 0;
            this.btnAdvancedEdition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvancedEdition.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvancedEdition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnAdvancedEdition.Location = new System.Drawing.Point(0, 46);
            this.btnAdvancedEdition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdvancedEdition.Name = "btnAdvancedEdition";
            this.btnAdvancedEdition.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAdvancedEdition.Size = new System.Drawing.Size(221, 46);
            this.btnAdvancedEdition.TabIndex = 2;
            this.btnAdvancedEdition.Text = "Advanced Edition";
            this.btnAdvancedEdition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdvancedEdition.UseVisualStyleBackColor = false;
            this.btnAdvancedEdition.Click += new System.EventHandler(this.btnAdvancedEdition_Click);
            // 
            // btnBasicEdition
            // 
            this.btnBasicEdition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(97)))), ((int)(((byte)(120)))));
            this.btnBasicEdition.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBasicEdition.FlatAppearance.BorderSize = 0;
            this.btnBasicEdition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasicEdition.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasicEdition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnBasicEdition.Location = new System.Drawing.Point(0, 0);
            this.btnBasicEdition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBasicEdition.Name = "btnBasicEdition";
            this.btnBasicEdition.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnBasicEdition.Size = new System.Drawing.Size(221, 46);
            this.btnBasicEdition.TabIndex = 1;
            this.btnBasicEdition.Text = "Basic Edition";
            this.btnBasicEdition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBasicEdition.UseVisualStyleBackColor = false;
            this.btnBasicEdition.Click += new System.EventHandler(this.btnBasicEdition_Click);
            // 
            // btnGetStarted
            // 
            this.btnGetStarted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(102)))));
            this.btnGetStarted.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGetStarted.FlatAppearance.BorderSize = 0;
            this.btnGetStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetStarted.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetStarted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.btnGetStarted.Location = new System.Drawing.Point(0, 0);
            this.btnGetStarted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetStarted.Name = "btnGetStarted";
            this.btnGetStarted.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnGetStarted.Size = new System.Drawing.Size(221, 46);
            this.btnGetStarted.TabIndex = 0;
            this.btnGetStarted.Text = "Get Started";
            this.btnGetStarted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetStarted.UseVisualStyleBackColor = false;
            this.btnGetStarted.Click += new System.EventHandler(this.btnGetStarted_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(221, 89);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1010, 703);
            this.panelMain.TabIndex = 2;
            // 
            // toolTip1
            // 
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // picWeatherIcon
            // 
            this.picWeatherIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picWeatherIcon.Location = new System.Drawing.Point(55, 525);
            this.picWeatherIcon.Name = "picWeatherIcon";
            this.picWeatherIcon.Size = new System.Drawing.Size(115, 108);
            this.picWeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWeatherIcon.TabIndex = 7;
            this.picWeatherIcon.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.icons8_fan_head_70px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnMinimize.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_subtract_25px;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(1111, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 89);
            this.btnMinimize.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnMaximize.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_full_screen_25px;
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(1151, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(40, 89);
            this.btnMaximize.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnMaximize, "Maximize");
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnExit.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_delete_25px_1;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1191, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 89);
            this.btnExit.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnExit, "Close");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1231, 792);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1231, 792);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HVAC Load Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.panelWeatherFail.ResumeLayout(false);
            this.panelWeatherFail.PerformLayout();
            this.panelAccount.ResumeLayout(false);
            this.panelHelp.ResumeLayout(false);
            this.panelGetStarted.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnGetStarted;
        private System.Windows.Forms.Panel panelHelp;
        private System.Windows.Forms.Button btnContactUs;
        private System.Windows.Forms.Button btnHowItWorks;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel panelGetStarted;
        private System.Windows.Forms.Button btnAdvancedEdition;
        private System.Windows.Forms.Button btnBasicEdition;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.PictureBox picWeatherIcon;
        private System.Windows.Forms.Label lblWeatherCondition;
        private System.Windows.Forms.Panel panelWeatherFail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

