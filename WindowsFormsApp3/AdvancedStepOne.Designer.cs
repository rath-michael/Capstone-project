namespace WindowsFormsApp3
{
    partial class AdvancedStepOne
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
            this.cboState = new System.Windows.Forms.ComboBox();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelError = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.picErrorTwo = new System.Windows.Forms.PictureBox();
            this.txtCeilingHeight = new System.Windows.Forms.TextBox();
            this.picErrorFour = new System.Windows.Forms.PictureBox();
            this.picErrorThree = new System.Windows.Forms.PictureBox();
            this.picErrorOne = new System.Windows.Forms.PictureBox();
            this.txtNumAppliances = new System.Windows.Forms.TextBox();
            this.txtNumPeople = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHouseArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelMain.SuspendLayout();
            this.panelError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorOne)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.lblMain.Location = new System.Drawing.Point(448, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(123, 28);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Step One";
            // 
            // cboState
            // 
            this.cboState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboState.DropDownHeight = 200;
            this.cboState.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.cboState.FormattingEnabled = true;
            this.cboState.IntegralHeight = false;
            this.cboState.Location = new System.Drawing.Point(253, 148);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(246, 27);
            this.cboState.TabIndex = 1;
            this.cboState.Text = "Select State";
            this.cboState.SelectedIndexChanged += new System.EventHandler(this.cboState_SelectedIndexChanged);
            // 
            // cboCity
            // 
            this.cboCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCity.DropDownHeight = 200;
            this.cboCity.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.cboCity.FormattingEnabled = true;
            this.cboCity.IntegralHeight = false;
            this.cboCity.Location = new System.Drawing.Point(545, 148);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(246, 27);
            this.cboCity.TabIndex = 2;
            this.cboCity.Text = "Select Nearest City";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label6.Location = new System.Drawing.Point(302, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Select State";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label2.Location = new System.Drawing.Point(577, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Nearest City";
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
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelError);
            this.panelMain.Controls.Add(this.btnHome);
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Controls.Add(this.picErrorTwo);
            this.panelMain.Controls.Add(this.txtCeilingHeight);
            this.panelMain.Controls.Add(this.picErrorFour);
            this.panelMain.Controls.Add(this.picErrorThree);
            this.panelMain.Controls.Add(this.picErrorOne);
            this.panelMain.Controls.Add(this.txtNumAppliances);
            this.panelMain.Controls.Add(this.txtNumPeople);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.txtHouseArea);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.btnNext);
            this.panelMain.Controls.Add(this.lblMain);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.cboCity);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.cboState);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(992, 656);
            this.panelMain.TabIndex = 10;
            // 
            // panelError
            // 
            this.panelError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
            this.panelError.Controls.Add(this.lblError);
            this.panelError.Location = new System.Drawing.Point(121, 87);
            this.panelError.Name = "panelError";
            this.panelError.Size = new System.Drawing.Size(749, 454);
            this.panelError.TabIndex = 65;
            this.panelError.Visible = false;
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
            this.btnHome.TabIndex = 56;
            this.toolTip1.SetToolTip(this.btnHome, "Go To Home Page");
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label7.Location = new System.Drawing.Point(302, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 22);
            this.label7.TabIndex = 55;
            this.label7.Text = "Ceiling Height (FT):";
            // 
            // picErrorTwo
            // 
            this.picErrorTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picErrorTwo.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorTwo.Location = new System.Drawing.Point(777, 355);
            this.picErrorTwo.Name = "picErrorTwo";
            this.picErrorTwo.Size = new System.Drawing.Size(35, 28);
            this.picErrorTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorTwo.TabIndex = 54;
            this.picErrorTwo.TabStop = false;
            this.picErrorTwo.Visible = false;
            // 
            // txtCeilingHeight
            // 
            this.txtCeilingHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCeilingHeight.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCeilingHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.txtCeilingHeight.Location = new System.Drawing.Point(567, 355);
            this.txtCeilingHeight.Name = "txtCeilingHeight";
            this.txtCeilingHeight.Size = new System.Drawing.Size(204, 28);
            this.txtCeilingHeight.TabIndex = 53;
            // 
            // picErrorFour
            // 
            this.picErrorFour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picErrorFour.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorFour.Location = new System.Drawing.Point(777, 467);
            this.picErrorFour.Name = "picErrorFour";
            this.picErrorFour.Size = new System.Drawing.Size(35, 28);
            this.picErrorFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorFour.TabIndex = 51;
            this.picErrorFour.TabStop = false;
            this.picErrorFour.Visible = false;
            // 
            // picErrorThree
            // 
            this.picErrorThree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picErrorThree.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorThree.Location = new System.Drawing.Point(777, 415);
            this.picErrorThree.Name = "picErrorThree";
            this.picErrorThree.Size = new System.Drawing.Size(35, 28);
            this.picErrorThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorThree.TabIndex = 50;
            this.picErrorThree.TabStop = false;
            this.picErrorThree.Visible = false;
            // 
            // picErrorOne
            // 
            this.picErrorOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picErrorOne.Image = global::WindowsFormsApp3.Properties.Resources.icons8_exclamation_mark_20px;
            this.picErrorOne.Location = new System.Drawing.Point(777, 299);
            this.picErrorOne.Name = "picErrorOne";
            this.picErrorOne.Size = new System.Drawing.Size(35, 28);
            this.picErrorOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picErrorOne.TabIndex = 49;
            this.picErrorOne.TabStop = false;
            this.picErrorOne.Visible = false;
            // 
            // txtNumAppliances
            // 
            this.txtNumAppliances.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumAppliances.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAppliances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.txtNumAppliances.Location = new System.Drawing.Point(567, 467);
            this.txtNumAppliances.Name = "txtNumAppliances";
            this.txtNumAppliances.Size = new System.Drawing.Size(204, 28);
            this.txtNumAppliances.TabIndex = 15;
            // 
            // txtNumPeople
            // 
            this.txtNumPeople.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumPeople.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.txtNumPeople.Location = new System.Drawing.Point(567, 411);
            this.txtNumPeople.Name = "txtNumPeople";
            this.txtNumPeople.Size = new System.Drawing.Size(204, 28);
            this.txtNumPeople.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label5.Location = new System.Drawing.Point(155, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(349, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Number of appliances in the home:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label4.Location = new System.Drawing.Point(193, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Number of people in the home:";
            // 
            // txtHouseArea
            // 
            this.txtHouseArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHouseArea.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHouseArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.txtHouseArea.Location = new System.Drawing.Point(567, 299);
            this.txtHouseArea.Name = "txtHouseArea";
            this.txtHouseArea.Size = new System.Drawing.Size(204, 28);
            this.txtHouseArea.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(146)))), ((int)(((byte)(215)))));
            this.label3.Location = new System.Drawing.Point(242, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "House Total Area (SQ FT):";
            // 
            // toolTip1
            // 
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // AdvancedStepOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(992, 656);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdvancedStepOne";
            this.Text = "Form3";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelError.ResumeLayout(false);
            this.panelError.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorOne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox txtHouseArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumAppliances;
        private System.Windows.Forms.TextBox txtNumPeople;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picErrorFour;
        private System.Windows.Forms.PictureBox picErrorThree;
        private System.Windows.Forms.PictureBox picErrorOne;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picErrorTwo;
        private System.Windows.Forms.TextBox txtCeilingHeight;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelError;
        private System.Windows.Forms.Label lblError;
    }
}