namespace StoreManager.App.DetailsForm
{
    partial class ContactInfoDetails
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
            this.txtEmployeeIDValue = new System.Windows.Forms.TextBox();
            this.txtContactTypeValue = new System.Windows.Forms.TextBox();
            this.txtContactDataValue = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblContactType = new System.Windows.Forms.Label();
            this.lblContactData = new System.Windows.Forms.Label();
            this.lblIsPrimary = new System.Windows.Forms.Label();
            this.cmbIsPrimaryValue = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmployeeIDValue
            // 
            this.txtEmployeeIDValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeIDValue.Location = new System.Drawing.Point(125, 6);
            this.txtEmployeeIDValue.Name = "txtEmployeeIDValue";
            this.txtEmployeeIDValue.Size = new System.Drawing.Size(344, 22);
            this.txtEmployeeIDValue.TabIndex = 0;
            // 
            // txtContactTypeValue
            // 
            this.txtContactTypeValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContactTypeValue.Location = new System.Drawing.Point(125, 34);
            this.txtContactTypeValue.Name = "txtContactTypeValue";
            this.txtContactTypeValue.Size = new System.Drawing.Size(344, 22);
            this.txtContactTypeValue.TabIndex = 1;
            // 
            // txtContactDataValue
            // 
            this.txtContactDataValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContactDataValue.Location = new System.Drawing.Point(125, 62);
            this.txtContactDataValue.Name = "txtContactDataValue";
            this.txtContactDataValue.Size = new System.Drawing.Size(344, 22);
            this.txtContactDataValue.TabIndex = 2;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(11, 9);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(85, 16);
            this.lblEmployeeID.TabIndex = 4;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // lblContactType
            // 
            this.lblContactType.AutoSize = true;
            this.lblContactType.Location = new System.Drawing.Point(12, 37);
            this.lblContactType.Name = "lblContactType";
            this.lblContactType.Size = new System.Drawing.Size(87, 16);
            this.lblContactType.TabIndex = 5;
            this.lblContactType.Text = "Contact Type";
            // 
            // lblContactData
            // 
            this.lblContactData.AutoSize = true;
            this.lblContactData.Location = new System.Drawing.Point(11, 65);
            this.lblContactData.Name = "lblContactData";
            this.lblContactData.Size = new System.Drawing.Size(84, 16);
            this.lblContactData.TabIndex = 6;
            this.lblContactData.Text = "Contact Data";
            // 
            // lblIsPrimary
            // 
            this.lblIsPrimary.AutoSize = true;
            this.lblIsPrimary.Location = new System.Drawing.Point(11, 93);
            this.lblIsPrimary.Name = "lblIsPrimary";
            this.lblIsPrimary.Size = new System.Drawing.Size(53, 16);
            this.lblIsPrimary.TabIndex = 7;
            this.lblIsPrimary.Text = "Primary";
            // 
            // cmbIsPrimaryValue
            // 
            this.cmbIsPrimaryValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIsPrimaryValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsPrimaryValue.FormattingEnabled = true;
            this.cmbIsPrimaryValue.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbIsPrimaryValue.Location = new System.Drawing.Point(125, 90);
            this.cmbIsPrimaryValue.Name = "cmbIsPrimaryValue";
            this.cmbIsPrimaryValue.Size = new System.Drawing.Size(344, 24);
            this.cmbIsPrimaryValue.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(302, 133);
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
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(394, 133);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ContactInfoDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(481, 169);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbIsPrimaryValue);
            this.Controls.Add(this.lblIsPrimary);
            this.Controls.Add(this.lblContactData);
            this.Controls.Add(this.lblContactType);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.txtContactDataValue);
            this.Controls.Add(this.txtContactTypeValue);
            this.Controls.Add(this.txtEmployeeIDValue);
            this.Name = "ContactInfoDetails";
            this.Text = "ContactInfoDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployeeIDValue;
        private System.Windows.Forms.TextBox txtContactTypeValue;
        private System.Windows.Forms.TextBox txtContactDataValue;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblContactType;
        private System.Windows.Forms.Label lblContactData;
        private System.Windows.Forms.Label lblIsPrimary;
        private System.Windows.Forms.ComboBox cmbIsPrimaryValue;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}