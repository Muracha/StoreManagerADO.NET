namespace StoreManager.App.DetailsForm
{
    partial class EmployeeDetails
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.ditBirthDateValue = new System.Windows.Forms.DateTimePicker();
            this.txtFirstNameValue = new System.Windows.Forms.TextBox();
            this.txtLastNameValue = new System.Windows.Forms.TextBox();
            this.ditHireDateValue = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 22);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(72, 16);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 55);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(72, 16);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(12, 86);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(65, 16);
            this.lblBirthDate.TabIndex = 2;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Location = new System.Drawing.Point(12, 115);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(64, 16);
            this.lblHireDate.TabIndex = 3;
            this.lblHireDate.Text = "Hire Date";
            // 
            // ditBirthDateValue
            // 
            this.ditBirthDateValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ditBirthDateValue.Location = new System.Drawing.Point(142, 80);
            this.ditBirthDateValue.Name = "ditBirthDateValue";
            this.ditBirthDateValue.Size = new System.Drawing.Size(268, 22);
            this.ditBirthDateValue.TabIndex = 5;
            // 
            // txtFirstNameValue
            // 
            this.txtFirstNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstNameValue.Location = new System.Drawing.Point(142, 19);
            this.txtFirstNameValue.Name = "txtFirstNameValue";
            this.txtFirstNameValue.Size = new System.Drawing.Size(268, 22);
            this.txtFirstNameValue.TabIndex = 6;
            // 
            // txtLastNameValue
            // 
            this.txtLastNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastNameValue.Location = new System.Drawing.Point(142, 52);
            this.txtLastNameValue.Name = "txtLastNameValue";
            this.txtLastNameValue.Size = new System.Drawing.Size(268, 22);
            this.txtLastNameValue.TabIndex = 7;
            // 
            // ditHireDateValue
            // 
            this.ditHireDateValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ditHireDateValue.Location = new System.Drawing.Point(142, 109);
            this.ditHireDateValue.Name = "ditHireDateValue";
            this.ditHireDateValue.Size = new System.Drawing.Size(268, 22);
            this.ditHireDateValue.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(238, 168);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(335, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 207);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ditHireDateValue);
            this.Controls.Add(this.txtLastNameValue);
            this.Controls.Add(this.txtFirstNameValue);
            this.Controls.Add(this.ditBirthDateValue);
            this.Controls.Add(this.lblHireDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "EmployeeDetails";
            this.Text = "EmployeeDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.DateTimePicker ditBirthDateValue;
        private System.Windows.Forms.TextBox txtFirstNameValue;
        private System.Windows.Forms.TextBox txtLastNameValue;
        private System.Windows.Forms.DateTimePicker ditHireDateValue;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}