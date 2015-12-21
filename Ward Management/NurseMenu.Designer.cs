namespace Ward_Management
{
    partial class NurseMenu
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NidGen = new System.Windows.Forms.Button();
            this._AssignedWardComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this._RankComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this._AgeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this._LastName = new System.Windows.Forms.TextBox();
            this._FirstName = new System.Windows.Forms.TextBox();
            this._NurseID = new System.Windows.Forms.TextBox();
            this._Gender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DisplayAW = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.IDListBox = new System.Windows.Forms.ListBox();
            this.NameListBox = new System.Windows.Forms.ListBox();
            this.SearchNurseID = new System.Windows.Forms.TextBox();
            this.DisplayR = new System.Windows.Forms.TextBox();
            this.DisplayG = new System.Windows.Forms.TextBox();
            this.DisplayA = new System.Windows.Forms.TextBox();
            this.DisplayLN = new System.Windows.Forms.TextBox();
            this.DisplayFN = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._AgeNumericUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(507, 405);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NidGen);
            this.tabPage1.Controls.Add(this._AssignedWardComboBox);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this._RankComboBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.feedbackLabel);
            this.tabPage1.Controls.Add(this.SaveButton);
            this.tabPage1.Controls.Add(this._AgeNumericUpDown);
            this.tabPage1.Controls.Add(this._LastName);
            this.tabPage1.Controls.Add(this._FirstName);
            this.tabPage1.Controls.Add(this._NurseID);
            this.tabPage1.Controls.Add(this._Gender);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(499, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Nurse";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // NidGen
            // 
            this.NidGen.Location = new System.Drawing.Point(402, 51);
            this.NidGen.Name = "NidGen";
            this.NidGen.Size = new System.Drawing.Size(75, 23);
            this.NidGen.TabIndex = 50;
            this.NidGen.Text = "Generate";
            this.NidGen.UseVisualStyleBackColor = true;
            this.NidGen.Click += new System.EventHandler(this.NidGen_Click);
            // 
            // _AssignedWardComboBox
            // 
            this._AssignedWardComboBox.FormattingEnabled = true;
            this._AssignedWardComboBox.Items.AddRange(new object[] {
            "W001",
            "W002",
            "W003",
            "W004",
            "W005",
            "ICU01",
            "ICU02",
            "ICU03"});
            this._AssignedWardComboBox.Location = new System.Drawing.Point(262, 246);
            this._AssignedWardComboBox.Name = "_AssignedWardComboBox";
            this._AssignedWardComboBox.Size = new System.Drawing.Size(121, 21);
            this._AssignedWardComboBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Assigned Ward";
            // 
            // _RankComboBox
            // 
            this._RankComboBox.FormattingEnabled = true;
            this._RankComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this._RankComboBox.Location = new System.Drawing.Point(262, 212);
            this._RankComboBox.Name = "_RankComboBox";
            this._RankComboBox.Size = new System.Drawing.Size(121, 21);
            this._RankComboBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Rank";
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Location = new System.Drawing.Point(372, 311);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(52, 13);
            this.feedbackLabel.TabIndex = 35;
            this.feedbackLabel.Text = "feedback";
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(201, 301);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // _AgeNumericUpDown
            // 
            this._AgeNumericUpDown.Location = new System.Drawing.Point(262, 147);
            this._AgeNumericUpDown.Name = "_AgeNumericUpDown";
            this._AgeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this._AgeNumericUpDown.TabIndex = 3;
            // 
            // _LastName
            // 
            this._LastName.Location = new System.Drawing.Point(262, 116);
            this._LastName.Name = "_LastName";
            this._LastName.Size = new System.Drawing.Size(120, 20);
            this._LastName.TabIndex = 2;
            // 
            // _FirstName
            // 
            this._FirstName.Location = new System.Drawing.Point(262, 84);
            this._FirstName.Name = "_FirstName";
            this._FirstName.Size = new System.Drawing.Size(120, 20);
            this._FirstName.TabIndex = 1;
            // 
            // _NurseID
            // 
            this._NurseID.Location = new System.Drawing.Point(262, 51);
            this._NurseID.Name = "_NurseID";
            this._NurseID.ReadOnly = true;
            this._NurseID.Size = new System.Drawing.Size(120, 20);
            this._NurseID.TabIndex = 0;
            // 
            // _Gender
            // 
            this._Gender.FormattingEnabled = true;
            this._Gender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this._Gender.Location = new System.Drawing.Point(262, 177);
            this._Gender.Name = "_Gender";
            this._Gender.Size = new System.Drawing.Size(121, 21);
            this._Gender.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nurse ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DisplayAW);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.DeleteButton);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.IDListBox);
            this.tabPage2.Controls.Add(this.NameListBox);
            this.tabPage2.Controls.Add(this.SearchNurseID);
            this.tabPage2.Controls.Add(this.DisplayR);
            this.tabPage2.Controls.Add(this.DisplayG);
            this.tabPage2.Controls.Add(this.DisplayA);
            this.tabPage2.Controls.Add(this.DisplayLN);
            this.tabPage2.Controls.Add(this.DisplayFN);
            this.tabPage2.Controls.Add(this.SearchButton);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(499, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search Nurse";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // DisplayAW
            // 
            this.DisplayAW.Location = new System.Drawing.Point(337, 246);
            this.DisplayAW.Name = "DisplayAW";
            this.DisplayAW.ReadOnly = true;
            this.DisplayAW.Size = new System.Drawing.Size(120, 20);
            this.DisplayAW.TabIndex = 59;
            this.DisplayAW.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Assigned Ward";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(373, 297);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(25, 54);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 13);
            this.label23.TabIndex = 56;
            this.label23.Text = "All Nurse:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(98, 88);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(18, 13);
            this.label24.TabIndex = 55;
            this.label24.Text = "ID";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(23, 88);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 13);
            this.label25.TabIndex = 54;
            this.label25.Text = "Name";
            // 
            // IDListBox
            // 
            this.IDListBox.FormattingEnabled = true;
            this.IDListBox.Location = new System.Drawing.Point(98, 105);
            this.IDListBox.Name = "IDListBox";
            this.IDListBox.Size = new System.Drawing.Size(67, 225);
            this.IDListBox.TabIndex = 1;
            this.IDListBox.SelectedIndexChanged += new System.EventHandler(this.IDListBox_SelectedIndexChanged);
            // 
            // NameListBox
            // 
            this.NameListBox.Enabled = false;
            this.NameListBox.FormattingEnabled = true;
            this.NameListBox.Location = new System.Drawing.Point(25, 105);
            this.NameListBox.Name = "NameListBox";
            this.NameListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.NameListBox.Size = new System.Drawing.Size(67, 225);
            this.NameListBox.TabIndex = 52;
            this.NameListBox.TabStop = false;
            // 
            // SearchNurseID
            // 
            this.SearchNurseID.Location = new System.Drawing.Point(267, 51);
            this.SearchNurseID.Name = "SearchNurseID";
            this.SearchNurseID.Size = new System.Drawing.Size(100, 20);
            this.SearchNurseID.TabIndex = 0;
            // 
            // DisplayR
            // 
            this.DisplayR.Location = new System.Drawing.Point(337, 212);
            this.DisplayR.Name = "DisplayR";
            this.DisplayR.ReadOnly = true;
            this.DisplayR.Size = new System.Drawing.Size(120, 20);
            this.DisplayR.TabIndex = 39;
            this.DisplayR.TabStop = false;
            // 
            // DisplayG
            // 
            this.DisplayG.Location = new System.Drawing.Point(337, 180);
            this.DisplayG.Name = "DisplayG";
            this.DisplayG.ReadOnly = true;
            this.DisplayG.Size = new System.Drawing.Size(120, 20);
            this.DisplayG.TabIndex = 38;
            this.DisplayG.TabStop = false;
            // 
            // DisplayA
            // 
            this.DisplayA.Location = new System.Drawing.Point(337, 148);
            this.DisplayA.Name = "DisplayA";
            this.DisplayA.ReadOnly = true;
            this.DisplayA.Size = new System.Drawing.Size(120, 20);
            this.DisplayA.TabIndex = 37;
            this.DisplayA.TabStop = false;
            // 
            // DisplayLN
            // 
            this.DisplayLN.Location = new System.Drawing.Point(337, 117);
            this.DisplayLN.Name = "DisplayLN";
            this.DisplayLN.ReadOnly = true;
            this.DisplayLN.Size = new System.Drawing.Size(120, 20);
            this.DisplayLN.TabIndex = 36;
            this.DisplayLN.TabStop = false;
            // 
            // DisplayFN
            // 
            this.DisplayFN.Location = new System.Drawing.Point(337, 85);
            this.DisplayFN.Name = "DisplayFN";
            this.DisplayFN.ReadOnly = true;
            this.DisplayFN.Size = new System.Drawing.Size(120, 20);
            this.DisplayFN.TabIndex = 35;
            this.DisplayFN.TabStop = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(373, 49);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(198, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Rank";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(198, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Gender";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(198, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Age";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(198, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Last Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(198, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "First Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(203, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Nurse ID";
            // 
            // NurseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 403);
            this.Controls.Add(this.tabControl1);
            this.Name = "NurseMenu";
            this.Text = "NurseMenu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._AgeNumericUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.NumericUpDown _AgeNumericUpDown;
        private System.Windows.Forms.TextBox _LastName;
        private System.Windows.Forms.TextBox _FirstName;
        private System.Windows.Forms.TextBox _NurseID;
        private System.Windows.Forms.ComboBox _Gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _RankComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ListBox IDListBox;
        private System.Windows.Forms.ListBox NameListBox;
        private System.Windows.Forms.TextBox SearchNurseID;
        private System.Windows.Forms.TextBox DisplayR;
        private System.Windows.Forms.TextBox DisplayG;
        private System.Windows.Forms.TextBox DisplayA;
        private System.Windows.Forms.TextBox DisplayLN;
        private System.Windows.Forms.TextBox DisplayFN;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox _AssignedWardComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DisplayAW;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button NidGen;
    }
}