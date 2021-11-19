namespace WindowsFormsApp3
{
    partial class HowItWorks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowItWorks));
            this.lblMain = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBasic = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelAdvanced = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnHome = new System.Windows.Forms.Button();
            this.btnGoAdvanced = new System.Windows.Forms.Button();
            this.btnGoBasic = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelBasic.SuspendLayout();
            this.panelAdvanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblMain.Location = new System.Drawing.Point(408, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(175, 28);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "How It Works";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnHome);
            this.panelMain.Controls.Add(this.btnGoAdvanced);
            this.panelMain.Controls.Add(this.btnGoBasic);
            this.panelMain.Controls.Add(this.panelBasic);
            this.panelMain.Controls.Add(this.panelAdvanced);
            this.panelMain.Controls.Add(this.lblMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(992, 656);
            this.panelMain.TabIndex = 1;
            // 
            // panelBasic
            // 
            this.panelBasic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBasic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
            this.panelBasic.Controls.Add(this.label6);
            this.panelBasic.Controls.Add(this.label2);
            this.panelBasic.Controls.Add(this.label4);
            this.panelBasic.Location = new System.Drawing.Point(146, 65);
            this.panelBasic.Name = "panelBasic";
            this.panelBasic.Size = new System.Drawing.Size(700, 250);
            this.panelBasic.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label6.Location = new System.Drawing.Point(23, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(598, 54);
            this.label6.TabIndex = 4;
            this.label6.Text = "Things you\'ll need to complete this calculation: the square footage of the\r\nbuild" +
    "ing in question, the number of occupants and appliances, and some\r\nbasic knowled" +
    "ge about the building\'s surroundings.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label2.Location = new System.Drawing.Point(311, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Basic";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label4.Location = new System.Drawing.Point(21, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(608, 90);
            this.label4.TabIndex = 3;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // panelAdvanced
            // 
            this.panelAdvanced.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAdvanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
            this.panelAdvanced.Controls.Add(this.label7);
            this.panelAdvanced.Controls.Add(this.label5);
            this.panelAdvanced.Controls.Add(this.label3);
            this.panelAdvanced.Location = new System.Drawing.Point(146, 321);
            this.panelAdvanced.Name = "panelAdvanced";
            this.panelAdvanced.Size = new System.Drawing.Size(700, 250);
            this.panelAdvanced.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label7.Location = new System.Drawing.Point(23, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(598, 54);
            this.label7.TabIndex = 5;
            this.label7.Text = "Things you\'ll need to complete this calculation: the square footage of the\r\nbuild" +
    "ing, the number of occupants and appliances, the size and\r\nconstruction type of " +
    "all exterior walls, windows and doors.";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label5.Location = new System.Drawing.Point(21, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(585, 72);
            this.label5.TabIndex = 4;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label3.Location = new System.Drawing.Point(292, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Advanced";
            // 
            // toolTip1
            // 
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHome.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_home_page_50px_1;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(450, 589);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(72, 63);
            this.btnHome.TabIndex = 64;
            this.toolTip1.SetToolTip(this.btnHome, "Go To Home Page");
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnGoAdvanced
            // 
            this.btnGoAdvanced.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGoAdvanced.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_go_50px;
            this.btnGoAdvanced.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGoAdvanced.FlatAppearance.BorderSize = 0;
            this.btnGoAdvanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoAdvanced.Location = new System.Drawing.Point(853, 398);
            this.btnGoAdvanced.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoAdvanced.Name = "btnGoAdvanced";
            this.btnGoAdvanced.Size = new System.Drawing.Size(72, 82);
            this.btnGoAdvanced.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnGoAdvanced, "Go To Advanced Calculation");
            this.btnGoAdvanced.UseVisualStyleBackColor = true;
            this.btnGoAdvanced.Click += new System.EventHandler(this.btnGoAdvanced_Click);
            // 
            // btnGoBasic
            // 
            this.btnGoBasic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGoBasic.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_go_50px;
            this.btnGoBasic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGoBasic.FlatAppearance.BorderSize = 0;
            this.btnGoBasic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBasic.Location = new System.Drawing.Point(853, 146);
            this.btnGoBasic.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoBasic.Name = "btnGoBasic";
            this.btnGoBasic.Size = new System.Drawing.Size(72, 82);
            this.btnGoBasic.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnGoBasic, "Go To Basic Calculation");
            this.btnGoBasic.UseVisualStyleBackColor = true;
            this.btnGoBasic.Click += new System.EventHandler(this.btnGoBasic_Click);
            // 
            // HowItWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(992, 656);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HowItWorks";
            this.Text = "Form4";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelBasic.ResumeLayout(false);
            this.panelBasic.PerformLayout();
            this.panelAdvanced.ResumeLayout(false);
            this.panelAdvanced.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelBasic;
        private System.Windows.Forms.Panel panelAdvanced;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGoAdvanced;
        private System.Windows.Forms.Button btnGoBasic;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}