namespace Ward_Management
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
            this.Patient = new System.Windows.Forms.Button();
            this.Nurse = new System.Windows.Forms.Button();
            this.Ward = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Patient
            // 
            this.Patient.Location = new System.Drawing.Point(69, 22);
            this.Patient.Name = "Patient";
            this.Patient.Size = new System.Drawing.Size(75, 23);
            this.Patient.TabIndex = 0;
            this.Patient.Text = "Patient";
            this.Patient.UseVisualStyleBackColor = true;
            this.Patient.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nurse
            // 
            this.Nurse.Location = new System.Drawing.Point(69, 68);
            this.Nurse.Name = "Nurse";
            this.Nurse.Size = new System.Drawing.Size(75, 23);
            this.Nurse.TabIndex = 1;
            this.Nurse.Text = "Nurse";
            this.Nurse.UseVisualStyleBackColor = true;
            this.Nurse.Click += new System.EventHandler(this.Nurse_Click);
            // 
            // Ward
            // 
            this.Ward.Location = new System.Drawing.Point(69, 115);
            this.Ward.Name = "Ward";
            this.Ward.Size = new System.Drawing.Size(75, 23);
            this.Ward.TabIndex = 2;
            this.Ward.Text = "Ward";
            this.Ward.UseVisualStyleBackColor = true;
            this.Ward.Click += new System.EventHandler(this.Ward_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(69, 160);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 214);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Ward);
            this.Controls.Add(this.Nurse);
            this.Controls.Add(this.Patient);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Patient;
        private System.Windows.Forms.Button Nurse;
        private System.Windows.Forms.Button Ward;
        private System.Windows.Forms.Button Exit;

    }
}