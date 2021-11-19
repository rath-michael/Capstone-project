namespace WindowsFormsApp3
{
    partial class BasicStepThree
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAppliances = new System.Windows.Forms.TextBox();
            this.txtOccupants = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.picErrorTwo = new System.Windows.Forms.PictureBox();
            this.picErrorOne = new System.Windows.Forms.PictureBox();
            this.btnQuestionAppliances = new System.Windows.Forms.Button();
            this.btnQuestionOccupants = new System.Windows.Forms.Button();
            this.panelKitchen = new System.Windows.Forms.Panel();
            this.picErrorThree = new System.Windows.Forms.PictureBox();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorOne)).BeginInit();
            this.panelKitchen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorThree)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnHome);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.txtAppliances);
            this.panelMain.Controls.Add(this.txtOccupants);
            this.panelMain.Controls.Add(this.txtUsername);
            this.panelMain.Controls.Add(this.lblUsername);
            this.panelMain.Controls.Add(this.picErrorTwo);
            this.panelMain.Controls.Add(this.picErrorOne);
            this.panelMain.Controls.Add(this.btnQuestionAppliances);
            this.panelMain.Controls.Add(this.btnQuestionOccupants);
            this.panelMain.Controls.Add(this.panelKitchen);
            this.panelMain.Controls.Add(this.btnPrevious);
            this.panelMain.Controls.Add(this.btnFinish);
            this.panelMain.Controls.Add(this.lblMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(992, 656);
            this.panelMain.TabIndex = 8;
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
            this.btnHome.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btnHome, "Go To Home Page");
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label3.Location = new System.Drawing.Point(171, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Number of Appliances:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label2.Location = new System.Drawing.Point(175, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Number of Occupants:";
            // 
            // txtAppliances
            // 
            this.txtAppliances.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAppliances.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppliances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.txtAppliances.Location = new System.Drawing.Point(442, 224);
            this.txtAppliances.Name = "txtAppliances";
            this.txtAppliances.Size = new System.Drawing.Size(214, 28);
            this.txtAppliances.TabIndex = 25;
            // 
            // txtOccupants
            // 
            this.txtOccupants.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOccupants.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOccupants.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.txtOccupants.Location = new System.Drawing.Point(442, 162);
            this.txtOccupants.Name = "txtOccupants";
            this.txtOccupants.Size = new System.Drawing.Size(214, 28);
            this.txtOccupants.TabIndex = 24;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.txtUsername.Location = new System.Drawing.Point(381, 427);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(239, 28);
            this.txtUsername.TabIndex = 23;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblUsername.Location = new System.Drawing.Point(295, 389);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(418, 22);
            this.lblUsername.TabIndex = 22;
            this.lblUsername.Text = "(Optional) Add a name to this calculation?\r\n";
            // 
            // picErrorTwo
            // 
            this.picErrorTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picErrorTwo.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorTwo.Location = new System.Drawing.Point(703, 225);
            this.picErrorTwo.Name = "picErrorTwo";
            this.picErrorTwo.Size = new System.Drawing.Size(35, 28);
            this.picErrorTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorTwo.TabIndex = 21;
            this.picErrorTwo.TabStop = false;
            this.picErrorTwo.Visible = false;
            // 
            // picErrorOne
            // 
            this.picErrorOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picErrorOne.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorOne.Location = new System.Drawing.Point(703, 161);
            this.picErrorOne.Name = "picErrorOne";
            this.picErrorOne.Size = new System.Drawing.Size(35, 28);
            this.picErrorOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorOne.TabIndex = 20;
            this.picErrorOne.TabStop = false;
            this.picErrorOne.Visible = false;
            // 
            // btnQuestionAppliances
            // 
            this.btnQuestionAppliances.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuestionAppliances.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_question_mark_20px;
            this.btnQuestionAppliances.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQuestionAppliances.FlatAppearance.BorderSize = 0;
            this.btnQuestionAppliances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestionAppliances.Location = new System.Drawing.Point(662, 223);
            this.btnQuestionAppliances.Name = "btnQuestionAppliances";
            this.btnQuestionAppliances.Size = new System.Drawing.Size(35, 30);
            this.btnQuestionAppliances.TabIndex = 18;
            this.btnQuestionAppliances.UseVisualStyleBackColor = true;
            this.btnQuestionAppliances.Click += new System.EventHandler(this.btnQuestionAppliances_Click);
            // 
            // btnQuestionOccupants
            // 
            this.btnQuestionOccupants.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuestionOccupants.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_question_mark_20px;
            this.btnQuestionOccupants.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQuestionOccupants.FlatAppearance.BorderSize = 0;
            this.btnQuestionOccupants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestionOccupants.Location = new System.Drawing.Point(662, 161);
            this.btnQuestionOccupants.Name = "btnQuestionOccupants";
            this.btnQuestionOccupants.Size = new System.Drawing.Size(35, 30);
            this.btnQuestionOccupants.TabIndex = 17;
            this.btnQuestionOccupants.UseVisualStyleBackColor = true;
            this.btnQuestionOccupants.Click += new System.EventHandler(this.btnQuestionOccupants_Click);
            // 
            // panelKitchen
            // 
            this.panelKitchen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelKitchen.Controls.Add(this.picErrorThree);
            this.panelKitchen.Controls.Add(this.radNo);
            this.panelKitchen.Controls.Add(this.radYes);
            this.panelKitchen.Controls.Add(this.label6);
            this.panelKitchen.Location = new System.Drawing.Point(327, 273);
            this.panelKitchen.Name = "panelKitchen";
            this.panelKitchen.Size = new System.Drawing.Size(386, 59);
            this.panelKitchen.TabIndex = 16;
            // 
            // picErrorThree
            // 
            this.picErrorThree.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorThree.Location = new System.Drawing.Point(286, 17);
            this.picErrorThree.Name = "picErrorThree";
            this.picErrorThree.Size = new System.Drawing.Size(35, 28);
            this.picErrorThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorThree.TabIndex = 22;
            this.picErrorThree.TabStop = false;
            this.picErrorThree.Visible = false;
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.radNo.Location = new System.Drawing.Point(224, 19);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(56, 26);
            this.radNo.TabIndex = 9;
            this.radNo.TabStop = true;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.radYes.Location = new System.Drawing.Point(151, 19);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(63, 26);
            this.radYes.TabIndex = 8;
            this.radYes.TabStop = true;
            this.radYes.Text = "Yes";
            this.radYes.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label6.Location = new System.Drawing.Point(38, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kitchen?";
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
            this.btnPrevious.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnPrevious, "Go To Previous Step");
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.button3_Click);
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
            this.btnFinish.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnFinish, "Get Results");
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblMain
            // 
            this.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblMain.Location = new System.Drawing.Point(333, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(144, 28);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Step Three";
            // 
            // toolTip1
            // 
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // BasicStepThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(992, 656);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BasicStepThree";
            this.Text = "Form7";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorOne)).EndInit();
            this.panelKitchen.ResumeLayout(false);
            this.panelKitchen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorThree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Panel panelKitchen;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnQuestionAppliances;
        private System.Windows.Forms.Button btnQuestionOccupants;
        private System.Windows.Forms.PictureBox picErrorTwo;
        private System.Windows.Forms.PictureBox picErrorOne;
        private System.Windows.Forms.PictureBox picErrorThree;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAppliances;
        private System.Windows.Forms.TextBox txtOccupants;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}