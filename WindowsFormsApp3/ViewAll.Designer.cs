namespace WindowsFormsApp3
{
    partial class ViewAll
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
            this.panelType = new System.Windows.Forms.Panel();
            this.radBasic = new System.Windows.Forms.RadioButton();
            this.radAdvanced = new System.Windows.Forms.RadioButton();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.lblErrorTwo = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnNextCalc = new System.Windows.Forms.Button();
            this.btnPrevCalc = new System.Windows.Forms.Button();
            this.listDisplay = new System.Windows.Forms.ListBox();
            this.lblMain = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelMain.SuspendLayout();
            this.panelType.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.panelMain.Controls.Add(this.panelType);
            this.panelMain.Controls.Add(this.btnHome);
            this.panelMain.Controls.Add(this.panelBackground);
            this.panelMain.Controls.Add(this.btnNextCalc);
            this.panelMain.Controls.Add(this.btnPrevCalc);
            this.panelMain.Controls.Add(this.listDisplay);
            this.panelMain.Controls.Add(this.lblMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(992, 656);
            this.panelMain.TabIndex = 1;
            // 
            // panelType
            // 
            this.panelType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelType.Controls.Add(this.radBasic);
            this.panelType.Controls.Add(this.radAdvanced);
            this.panelType.Location = new System.Drawing.Point(373, 40);
            this.panelType.Name = "panelType";
            this.panelType.Size = new System.Drawing.Size(221, 33);
            this.panelType.TabIndex = 18;
            // 
            // radBasic
            // 
            this.radBasic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radBasic.AutoSize = true;
            this.radBasic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBasic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.radBasic.Location = new System.Drawing.Point(3, 3);
            this.radBasic.Name = "radBasic";
            this.radBasic.Size = new System.Drawing.Size(78, 24);
            this.radBasic.TabIndex = 2;
            this.radBasic.TabStop = true;
            this.radBasic.Text = "Basic";
            this.radBasic.UseVisualStyleBackColor = true;
            this.radBasic.CheckedChanged += new System.EventHandler(this.radBasic_CheckedChanged);
            // 
            // radAdvanced
            // 
            this.radAdvanced.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radAdvanced.AutoSize = true;
            this.radAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdvanced.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.radAdvanced.Location = new System.Drawing.Point(98, 3);
            this.radAdvanced.Name = "radAdvanced";
            this.radAdvanced.Size = new System.Drawing.Size(111, 24);
            this.radAdvanced.TabIndex = 3;
            this.radAdvanced.TabStop = true;
            this.radAdvanced.Text = "Advanced";
            this.radAdvanced.UseVisualStyleBackColor = true;
            this.radAdvanced.CheckedChanged += new System.EventHandler(this.radAdvanced_CheckedChanged);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHome.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_home_page_50px_1;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(476, 589);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(72, 63);
            this.btnHome.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnHome, "Go To Home Page");
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelBackground
            // 
            this.panelBackground.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
            this.panelBackground.Controls.Add(this.lblErrorTwo);
            this.panelBackground.Controls.Add(this.lblError);
            this.panelBackground.Location = new System.Drawing.Point(261, 101);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(468, 450);
            this.panelBackground.TabIndex = 16;
            // 
            // lblErrorTwo
            // 
            this.lblErrorTwo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblErrorTwo.AutoSize = true;
            this.lblErrorTwo.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblErrorTwo.Location = new System.Drawing.Point(30, 201);
            this.lblErrorTwo.Name = "lblErrorTwo";
            this.lblErrorTwo.Size = new System.Drawing.Size(185, 28);
            this.lblErrorTwo.TabIndex = 3;
            this.lblErrorTwo.Text = "Please restart.";
            this.lblErrorTwo.Visible = false;
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblError.Location = new System.Drawing.Point(30, 173);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(322, 28);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "A database error occured.";
            this.lblError.Visible = false;
            // 
            // btnNextCalc
            // 
            this.btnNextCalc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextCalc.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_right_button_50px;
            this.btnNextCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNextCalc.FlatAppearance.BorderSize = 0;
            this.btnNextCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextCalc.Location = new System.Drawing.Point(736, 261);
            this.btnNextCalc.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextCalc.Name = "btnNextCalc";
            this.btnNextCalc.Size = new System.Drawing.Size(72, 63);
            this.btnNextCalc.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnNextCalc, "Next Calculation");
            this.btnNextCalc.UseVisualStyleBackColor = true;
            this.btnNextCalc.Click += new System.EventHandler(this.btnNextCalc_Click);
            // 
            // btnPrevCalc
            // 
            this.btnPrevCalc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrevCalc.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_prev_50px;
            this.btnPrevCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrevCalc.FlatAppearance.BorderSize = 0;
            this.btnPrevCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevCalc.Location = new System.Drawing.Point(182, 261);
            this.btnPrevCalc.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevCalc.Name = "btnPrevCalc";
            this.btnPrevCalc.Size = new System.Drawing.Size(72, 63);
            this.btnPrevCalc.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnPrevCalc, "Previous Calculation");
            this.btnPrevCalc.UseVisualStyleBackColor = true;
            this.btnPrevCalc.Click += new System.EventHandler(this.btnPrevCalc_Click);
            // 
            // listDisplay
            // 
            this.listDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDisplay.FormattingEnabled = true;
            this.listDisplay.ItemHeight = 22;
            this.listDisplay.Location = new System.Drawing.Point(261, 101);
            this.listDisplay.Name = "listDisplay";
            this.listDisplay.Size = new System.Drawing.Size(468, 444);
            this.listDisplay.TabIndex = 13;
            this.listDisplay.Visible = false;
            // 
            // lblMain
            // 
            this.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblMain.Location = new System.Drawing.Point(347, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(259, 28);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = "View All Calculations";
            // 
            // toolTip1
            // 
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // ViewAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(992, 656);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAll";
            this.Text = "SignUp";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelType.ResumeLayout(false);
            this.panelType.PerformLayout();
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.RadioButton radAdvanced;
        private System.Windows.Forms.RadioButton radBasic;
        private System.Windows.Forms.ListBox listDisplay;
        private System.Windows.Forms.Button btnNextCalc;
        private System.Windows.Forms.Button btnPrevCalc;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelType;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblErrorTwo;
    }
}