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
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtContactType = new System.Windows.Forms.TextBox();
            this.txtContactData = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblContactType = new System.Windows.Forms.Label();
            this.lblContactData = new System.Windows.Forms.Label();
            this.lblIsPrimary = new System.Windows.Forms.Label();
            this.cbIsPrimary = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtIsPrimary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeID.Location = new System.Drawing.Point(125, 6);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(344, 22);
            this.txtEmployeeID.TabIndex = 0;
            // 
            // txtContactType
            // 
            this.txtContactType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContactType.Location = new System.Drawing.Point(125, 34);
            this.txtContactType.Name = "txtContactType";
            this.txtContactType.Size = new System.Drawing.Size(344, 22);
            this.txtContactType.TabIndex = 1;
            // 
            // txtContactData
            // 
            this.txtContactData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContactData.Location = new System.Drawing.Point(125, 62);
            this.txtContactData.Name = "txtContactData";
            this.txtContactData.Size = new System.Drawing.Size(344, 22);
            this.txtContactData.TabIndex = 2;
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
            // cbIsPrimary
            // 
            this.cbIsPrimary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIsPrimary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsPrimary.FormattingEnabled = true;
            this.cbIsPrimary.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cbIsPrimary.Location = new System.Drawing.Point(125, 90);
            this.cbIsPrimary.Name = "cbIsPrimary";
            this.cbIsPrimary.Size = new System.Drawing.Size(344, 24);
            this.cbIsPrimary.TabIndex = 8;
            this.cbIsPrimary.SelectedIndexChanged += new System.EventHandler(this.cbIsPrimary_SelectedIndexChanged);
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
            // txtIsPrimary
            // 
            this.txtIsPrimary.Location = new System.Drawing.Point(369, 90);
            this.txtIsPrimary.Name = "txtIsPrimary";
            this.txtIsPrimary.Size = new System.Drawing.Size(100, 22);
            this.txtIsPrimary.TabIndex = 11;
            this.txtIsPrimary.Visible = false;
            this.txtIsPrimary.TextChanged += new System.EventHandler(this.txtPrimary_TextChanged);
            // 
            // ContactInfoDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(481, 169);
            this.Controls.Add(this.txtIsPrimary);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbIsPrimary);
            this.Controls.Add(this.lblIsPrimary);
            this.Controls.Add(this.lblContactData);
            this.Controls.Add(this.lblContactType);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.txtContactData);
            this.Controls.Add(this.txtContactType);
            this.Controls.Add(this.txtEmployeeID);
            this.Name = "ContactInfoDetails";
            this.Text = "ContactInfoDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtContactType;
        private System.Windows.Forms.TextBox txtContactData;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblContactType;
        private System.Windows.Forms.Label lblContactData;
        private System.Windows.Forms.Label lblIsPrimary;
        private System.Windows.Forms.ComboBox cbIsPrimary;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtIsPrimary;
    }
}